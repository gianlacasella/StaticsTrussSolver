from optparse import OptionParser
from scipy import array as sciarray
from matplotlib import pyplot as pt

class App:
    def __init__(self):
        self.processInput()
        self.showConnections()
        
    def processInput(self):
        #Reading input
        parser = OptionParser()
        parser.add_option('-n')
        parser.add_option('-c')
        (options, args) = parser.parse_args()
        options = vars(options)
        nodeElements,connectionElements = options['n'].split(','),options['c'].split(',')
        if(len(nodeElements) == 0 or len(connectionElements) == 0):
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
    
            
    def showConnections(self):
        #Plotting nodes
        pt.plot(self._nodes[:, 0], self._nodes[:, 1], "ok")
        k=0
        for bar in self._connections:
            x = self._nodes[bar,0]
            y = self._nodes[bar,1]
            pt.plot(x,y,color="black",linewidth = 2)
            k+=1
        pt.savefig(pt.savefig('connections/connections.jpg',dpi=1000,quality=95,format='jpg',optimize=True))
        print('Done')
        exit(0)
        
if __name__ == "__main__":
    pySolver = App()
    
    
    
    
    
    
    
    
    