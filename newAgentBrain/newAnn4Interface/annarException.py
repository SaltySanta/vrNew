# TODO: enum annarExceptionTypes

class annarExceptionTypes(Enum):

    exception_LAYER_NO_EXIST =



class AnnarException(object):

    def __init__(self, type, object1, object2=""):

        self.type_ = type
        self.object1_ = object1
        self.object2_ = object2

    def getType(self):

        return self.type_

    def what(self):

        # nochma anschauen
        # switch case


        return msg