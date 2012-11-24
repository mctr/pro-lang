def gcd(a, b):
	if b == 0:
		return a
	else:
		return gcd(b,a%b)
#~ print gcd(8,6)

def obeb(a ,b):
	while a % b != 0:
		olda = a
		oldb = b
		
		a = oldb
		b = olda % oldb
	return b
#~ print obeb(2, 5)
