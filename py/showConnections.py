from optparse import OptionParser
from scipy import array as sciarray
from matplotlib import pyplot as pt
from os import chdir
from glob import glob

# [0;1],[0;2],[1;2],[1;4],[1;3],[2;4],[3;4],[3;5],[5;4]

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
    
            
    def showConnections(self):
        #Plotting nodes
        pt.plot(self._nodes[:, 0], self._nodes[:, 1], "ok")
        i=0
        for node in self._nodesAsList:
            pt.text(node[0]-0.5, node[1]+0.1, i)
            i+=1
        k=0
        for bar in self._connections:
            x = self._nodes[bar,0]
            y = self._nodes[bar,1]
            pt.plot(x,y,color="black",linewidth = 2)
            k+=1
        fileNumber= self.findNumber()
        print(fileNumber)
        path = "connections"+fileNumber+".jpg"
        pt.savefig(path,dpi=1000,quality=95,format='jpg',optimize=True)
        print('    ***** SHOWING ' + str(k) + ' CONNECTIONS *****')
        exit(0)
        
    def findNumber(self):
        maxNumber = 0
        chdir("../../py")
        for file in glob("*.jpg"):
            if file[:11] == "connections":
                if file[11] != ".":
                    if(int(file[11]) > maxNumber):
                        maxNumber = int(file[11])
        return str(maxNumber+1)
        
if __name__ == "__main__":
    pySolver = App()
    
    
    
    
    
    
    
    
    