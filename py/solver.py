from optparse import OptionParser
from scipy import array as sciarr
import exceptions


class App:
    def __init__(self):
        self.processInput()
        self.preProcessData()
        
        
        
    def preProcessData(self):
        n = self._nodes.shape[0]
        b = len(self._connections)
        r = len(self._restrictions)
        # Degree of static indeterminacy
        self._GIE = b+r - 2*n
        # Salimos con mensaje de error si el sistema es hiperestatico o es un mecanismo
        if self._GIE > 0 :
            raise exceptions.HyperstaticSystem
            exit(-1)
        elif self._GIE < 0 :
            raise exceptions.MechanismSystem
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
                elementToAppend.append(float(subElement))
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
        self._nodes = sciarr(self._nodes)
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
            


if __name__ == "__main__":
    pySolver = App()
    
