class Stack:
    def __init__(self):
        self.data = []

    def push(self, value):
        return self.data.append(value)

    def pop(self):
        return self.data.pop()

    def peek(self):
        return self.data[len(self.data) - 1]

    def printAll(self, separator):
        for val in self.data:
            print(val, end=separator)
