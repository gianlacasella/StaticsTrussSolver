from optparse import OptionParser
from scipy import array as sciarray
from scipy import asmatrix as sciasmatrix
from scipy import zeros as scizeros
from scipy import double as scidouble
from scipy import mean as scimean
from scipy import arctan2 as sciarctan2
from scipy import sin as scisin
from scipy import cos as scicos
from scipy.linalg import solve as scisolve
from matplotlib import pyplot as pt
from os import chdir
from glob import glob

# Codigo de prueba python solver.py -n [0;0],[3;0],[3;4],[9;0],[9;4],[12;0] -c [0;1],[0;2],[1;2],[1;4],[1;3],[2;4],[3;4],[3;5],[5;4] -r [0;3.14/2],[5;3.14/2],[5;0] -f [1;0.;-3000],[3;0.;-5000],[4;2000;0.]

class App:
    def __init__(self):
        self.processInput()
        self.preProcessData()
        self.solve()
        self.showResult()
        
        
        
    def showResult(self):
        try:
            # min and max colors 
            # Vectors represent [R,G,B] elements
            cmin = sciarray([1,0,0], dtype = scidouble)
            cmax = sciarray([0,0,1], dtype = scidouble)
            #[COMPRESSION]--> red [TRACTION]--> blue
            rmax = self._result.max()
            rmin = self._result.min()
            #Plotting nodes
            pt.plot(self._nodes[:, 0], self._nodes[:, 1], "ok")
            k=0
            for bar in self._connections:
                rk = self._result[k, 0]
                xi = (rk-rmin)/(rmax - rmin)
                c = cmin*(1-xi) + cmax*xi
                x = self._nodes[bar,0]
                y = self._nodes[bar,1]
                x0 = scimean(x)
                y0 = scimean(y)
                pt.plot(x,y,color = c,linewidth = 2)
                rk = rk/1000
                pt.text(x0-0.5,y0,"{0:4.1f}kN".format(rk), fontsize = 7, color = "k")
                k+=1
                
            #Plotting forces
            """
            minx = self._nodes[:,0].min()+1
            miny = self._nodes[:,1].min()+1
            maxx = self._nodes[:,0].max()+1
            maxy = self._nodes[:,1].max()+1
            #Plotting forces
            for force in self._forces:
                node_coordinates = self._nodesAsList[int(force[0])]
                ax = pt.axes()
                #If forces are too big, they neet to be divided by 1000
                if(abs(force[1])>10 or abs(force[2])>50):
                    extrapForce = [force[1]/1000,force[2]/1000]
                    ax.arrow(node_coordinates[0], node_coordinates[1], extrapForce[0], extrapForce[1], head_width=0.2, head_length=0.3, fc='lightblue', ec='black')
                    if(extrapForce[0]<minx):
                        minx=extrapForce[0]
                    elif(extrapForce[1]<miny):
                        miny=extrapForce[1]
                    if(extrapForce[0]>maxx):
                        maxx=extrapForce[0]
                    elif(extrapForce[1]>maxy):
                        maxy=extrapForce[1]
                    #pt.text(extrapForce[0]+node_coordinates[0]+0.3,extrapForce[1]+node_coordinates[1],'(' + str(extrapForce[0]) + ',' + str(extrapForce[1]) + ')')
                else:
                    ax.arrow(node_coordinates[0], node_coordinates[1], force[1], force[2], head_width=0.2, head_length=0.3, fc='lightblue', ec='black')
                    if(force[1]<minx):
                        minx=force[1]
                    elif(force[2]<miny):
                        miny=force[2]
                    if(force[1]>maxx):
                        maxx=force[1]
                    elif(force[2]>maxy):
                        maxy=force[2]
                    #pt.text(force[1]+node_coordinates[0]+0.3,force[2]+node_coordinates[1],'(' + str(force[1]) + ',' + str(force[2]) + ')')
            pt.xlim(minx-1,maxx+1)
            pt.ylim(miny-1,maxy+1)
            """
            
            #Showing result
            fileNumber= self.findNumber()
            print(fileNumber)
            path = "result"+fileNumber+".jpg"
            pt.savefig(path,dpi=1000,quality=95,format='jpg',optimize=True)
            print('    ***** SHOWING RESULT *****')
            print('    GIE:', self._GIE)
            print('    Solution: \n', self._result)
            exit(0)
        except:
            print('ERROR')
            exit(0)
        
    def findNumber(self):
        maxNumber = 0
        chdir("../../py")
        for file in glob("*.jpg"):
            if file[:6] == "result":
                if file[6] != ".":
                    if(int(file[6]) > maxNumber):
                        maxNumber = int(file[6])
        return str(maxNumber+1)
        
    
    def solve(self):
        try:
            C = sciasmatrix(scizeros((2*self._n, self._b+self._r), dtype = scidouble))
            f = sciasmatrix(scizeros(2*self._n, dtype = scidouble)).T
            
            # Connections
            k = 0
            for connection in self._connections:
            	ni = connection[0]
            	nj = connection[1];
            	x = self._nodes[connection,0]
            	y = self._nodes[connection,1]
            	theta = sciarctan2(y[1] - y[0], x[1] - x[0])
            	# Vamos llenando nuestra matriz con los valores necesarios de las barras
            	C[2*ni, k] = scicos(theta)
            	C[2*ni+1, k] = scisin(theta)
            	C[2*nj, k] = -scicos(theta)
            	C[2*nj+1, k] = -scisin(theta)
            	k+=1
            
             # Restrictions
            for rest in self._restrictions:
            	node = rest[0]
            	alpha = rest[1]
            	C[2*node, k] = scicos(alpha)
            	C[2*node+1, k] = scisin(alpha)
            	k += 1
             
             # Forces
            for force in self._forces:
            	node = force[0]
            	fx = force[1]
            	fy = force[2]
            	f[2*node] = fx
            	f[2*node+1] = fy

            # Solve the system
            self._result = scisolve(C, -f)
        except:
            print('ERROR')
            exit(0)
         

         
         
    def preProcessData(self):
        self._n = self._nodes.shape[0]
        self._b = len(self._connections)
        self._r = len(self._restrictions)
        # Degree of static indeterminacy
        self._GIE = self._b+self._r - 2*self._n
        if self._GIE > 0 :
            print('ERRORM')
            exit(1)
        elif self._GIE < 0 :
            print('ERRORI')
            exit(1)
            
    def processInput(self):
        try:
            #Reading input
            parser = OptionParser()
            parser.add_option('-n')
            parser.add_option('-c')
            parser.add_option('-r')
            parser.add_option('-f')
            (options, args) = parser.parse_args()
            options = vars(options)
            (connectionElements,nodeElements,forcesElements,restrictionElements)= options['c'].split(','),options['n'].split(','),options['f'].split(','),options['r'].split(',')
            #Processing connections
            self._connections = []
            for element in connectionElements:
                splitted = element.split(';')
                elementToAppend = []
                for subElement in splitted:
                    subElement = subElement.replace('[','')
                    subElement = subElement.replace(']','')
                    elementToAppend.append(int(subElement))
                self._connections.append(elementToAppend)
            #Processing nodes
            self._nodes = []
            for element in nodeElements:
                splitted = element.split(';')
                elementToAppend = []
                for subElement in splitted:
                    subElement = subElement.replace('[','')
                    subElement = subElement.replace(']','')
                    elementToAppend.append(float(subElement))
                self._nodes.append(elementToAppend)
            self._nodesAsList = self._nodes.copy()
            self._nodes = sciarray(self._nodes)
            #Processing restrictions
            self._restrictions = []
            for element in restrictionElements:
                splitted = element.split(';')
                elementToAppend = []
                for subElement in splitted:
                    subElement = subElement.replace('[','')
                    subElement = subElement.replace(']','')
                    elementToAppend.append(float(eval(subElement)))
                self._restrictions.append(elementToAppend)
            i = 0
            for element in self._restrictions:
                self._restrictions[i][0] = int(self._restrictions[i][0])
                i+=1
            #Processing forces
            self._forces = []
            for element in forcesElements:
                splitted = element.split(';')
                elementToAppend = []
                for subElement in splitted:
                    subElement = subElement.replace('[','')
                    subElement = subElement.replace(']','')
                    elementToAppend.append(float(subElement))
                self._forces.append(elementToAppend)
            i = 0
            for element in self._forces:
                self._forces[i][0] = int(self._forces[i][0])
                i+=1
        except:
            print('ERROR')
            exit(1)
            


if __name__ == "__main__":
    pySolver = App()
    
