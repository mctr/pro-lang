from polindrom import Deque

def topla(string):
	d = Deque()
	for i in string:
		d.addRear(int(i))
	toplam = 0
	while d.size() > 1:
		toplam += (d.removeFront() * d.removeRear())
	toplam += d.removeRear()
	return toplam
	
print topla("52125")
