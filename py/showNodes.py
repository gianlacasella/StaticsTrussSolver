from optparse import OptionParser
from scipy import array as sciarray
from matplotlib import pyplot as pt

class App:
    def __init__(self):
        self.processInput()
        self.showNodes()
        
    def processInput(self):
        #Reading input
        parser = OptionParser()
        parser.add_option('-n')
        (options, args) = parser.parse_args()
        options = vars(options)
        nodeElements = options['n'].split(',')
        if(len(nodeElements) == 0):
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
    
    def showNodes(self):
        #Plotting nodes
        pt.plot(self._nodes[:, 0], self._nodes[:, 1], "ok")
        i=0
        for node in self._nodesAsList:
            pt.text(node[0]-0.5, node[1]+0.1, i)
            i+=1
        pt.savefig('../../py/nodes.jpg',dpi=1000,quality=95,format='jpg',optimize=True)
        print('Done')
        exit(0)
        
if __name__ == "__main__":
    pySolver = App()
    
    
    