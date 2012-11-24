def postfixeval(ifadeler):
	s = Stack()
	tokenlist = ifadeler.split()
	for token in tokenlist:
		if token in "0123456789":
			s.push(int(token))
		else:
			sayi2 = s.pop()
			sayi1 = s.pop()
			sonuc = doMath(token, sayi1, sayi2)
			s.push(sonuc)
	return s.pop()
	
def doMath(islec, a, b):
	if islec == "*":
		return a * b
	else:
		if islec == "/":
			return a / b
		else:
			if islec == "+":
				return a + b
			return a - b
			
#~ print postfixeval("1 2 + 3 *")
