from optparse import OptionParser
from scipy import array as sciarray
from matplotlib import pyplot as pt
from os import chdir
from glob import glob

# [0;0],[3;0],[3;4],[9;0],[9;4],[12;0]

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
        fileNumber= self.findNumber()
        print(fileNumber)
        path = "nodes"+fileNumber+".jpg"
        pt.savefig(path,dpi=1000,quality=95,format='jpg',optimize=True)
        print('Done')
        exit(0)
        
        
    def findNumber(self):
        maxNumber = 0
        chdir("../../py")
        for file in glob("*.jpg"):
            if file[:5] == "nodes":
                if file[5] != ".":
                    if(int(file[5]) > maxNumber):
                        maxNumber = int(file[5])
        return str(maxNumber+1)
        
        
        
        
if __name__ == "__main__":
    pySolver = App()
    
    
    