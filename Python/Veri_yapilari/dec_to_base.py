from Stack import *
#~ digits = "0123456789ABCDEF"

def dec_to_base(dec, base):
	digits = "0123456789ABCDEF"
	s = Stack()
	while dec > 0:
		s.push(dec % base)
		dec = dec / base
	yeni = ""
	while not s.isEmpty():
		yeni = yeni + digits[s.pop()]
		
	return yeni

print dec_to_base(10,16)
