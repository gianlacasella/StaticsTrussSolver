from optparse import OptionParser


class App:
    def __init__(self):
        self.processInput()
        
        
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
    
