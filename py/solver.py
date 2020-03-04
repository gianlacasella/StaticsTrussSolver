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
import customExceptions

# Codigo de prueba python solver.py -n [0;0],[3;0],[3;4],[9;0],[9;4],[12;0] -c [0;1],[0;2],[1;2],[1;4],[1;3],[2;4],[3;4],[3;5],[5;4] -r [0;3.14/2],[5;3.14/2],[5;0] -f [1;0.;-3000],[3;0.;-5000],[4;2000;0.]

class App:
    def __init__(self):
        self.processInput()
        self.preProcessData()
        self.solve()
        self.showResult()
        
    def showResult(self):
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
            pt.text(x0-0.5,y0,"{0:4.2f}kN".format(rk), fontsize = 14, color = "k")
            k+=1
        print(self._result)
        pt.show()
        
        
    
    def solve(self):
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

        # Axis limits
        pt.ylim(bottom = -3, top = 5)
        pt.xlim(left = -3, right = 15)
        
        # Solve the system
        self._result = scisolve(C, -f)
         

         
         
    def preProcessData(self):
        self._n = self._nodes.shape[0]
        self._b = len(self._connections)
        self._r = len(self._restrictions)
        # Degree of static indeterminacy
        self._GIE = self._b+self._r - 2*self._n
        print('b: ', self._b, 'r: ', self._r, 'n: ', self._n)
        if self._GIE > 0 :
            raise customExceptions.HyperstaticSystem
            exit(-1)
        elif self._GIE < 0 :
            raise customExceptions.MechanismSystem
            exit(-1)
        
    def processInput(self):
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
            


if __name__ == "__main__":
    pySolver = App()
    
