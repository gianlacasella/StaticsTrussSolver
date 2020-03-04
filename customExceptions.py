
class HyperstaticSystem(Exception):
    def __str__(self):
        return 'The system is hyperstatic'
        
class MechanismSystem(Exception):
    def __str__(self):
        return 'The system is a mechanism'

        