class MinStack:

    def __init__(self):
        self.s1 = []
        self.mins1 = []

    def push(self, val: int) -> None:
        self.s1.append(val)
        if self.mins1:
            self.mins1.append(min(val, self.mins1[-1]))
        else:
            self.mins1.append(val)

    def pop(self) -> None:
        self.mins1.pop()
        return self.s1.pop()

    def top(self) -> int:
        return self.s1[-1]

    def getMin(self) -> int:
        return self.mins1[-1]
        
