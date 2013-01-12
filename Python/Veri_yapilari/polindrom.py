class Deque:
	def __init__(self):
		self.items = []
		
	def isEmpty(self):
		return self.items == []
		
	def addFront(self, item):
		self.items.append(item)
		
	def addRear(self, item):
		self.items.insert(0, item)
		
	def removeFront(self):
		return self.items.pop()
		
	def removeRear(self):
		return self.items.pop(0)
		
	def size(self):
		return len(self.items)


def polindrom(string):
	d = Deque()
	for i in string:
		d.addRear(i)
	
	durum = True
	while d.size() > 1 and durum:
		ilk = d.removeFront()
		son = d.removeRear()
		if ilk != son:
			durum = False
			
	return durum

print polindrom("kavak")			
