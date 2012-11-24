def parantezkontrol(ifade):
	s = Stack()
	index = 0
	durum = True
	while index < len(ifade) and durum:
		sembol = ifade[index]
		if sembol == "(":
			s.push(sembol)
		else:
			if s.isEmpty():
				durum = False
			else:
				s.pop()
		index += 1
	if durum and s.isEmpty():
		return True
	else:
		return False
#~ print parantezkontrol("()()()())))(((")
