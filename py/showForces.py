from optparse import OptionParser
from scipy import array as sciarray
from matplotlib import pyplot as pt

class App:
    def __init__(self):
        self.processInput()
        self.showForces()
        
    
    def processInput(self):
        #Reading input
        parser = OptionParser()
        parser.add_option('-n')
        parser.add_option('-c')
        parser.add_option('-f')
        (options, args) = parser.parse_args()
        options = vars(options)
        nodeElements,connectionElements,forceElements = options['n'].split(','),options['c'].split(','),options['f'].split(',')
        if(len(nodeElements) == 0 or len(connectionElements) == 0 or len(forceElements) == 0):
            print('ERROR')
            exit(1)
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
        #Processing forces
        self._forces = []
        for element in forceElements:
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
    

            
    def showForces(self):
        #Plotting nodes
        #All elements of Column 0 and 1
        pt.plot(self._nodes[:, 0], self._nodes[:, 1], "ok")
        k=0
        #Plotting connections
        for bar in self._connections:
            x = self._nodes[bar,0]
            y = self._nodes[bar,1]
            pt.plot(x,y,color="black",linewidth = 2)
            k+=1
            
        minx = self._nodes[:,0].min()+1
        miny = self._nodes[:,1].min()+1
        maxx = self._nodes[:,0].max()+1
        maxy = self._nodes[:,1].max()+1
        #Plotting forces
        for force in self._forces:
            node_coordinates = self._nodesAsList[int(force[0])]
            ax = pt.axes()
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
        pt.xlim(minx-1,maxx+1)
        pt.ylim(miny-1,maxy+1)
        pt.savefig(pt.savefig('forces/forces.jpg',dpi=1000,quality=95,format='jpg',optimize=True))
        print('Done')
        exit(0)
        
if __name__ == "__main__":
    pySolver = App()
    
    
    
    
    
    
    
    
    