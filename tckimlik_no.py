 #!/usr/bin/python
#-*-coding:-utf-8-*-
def tc_no_dogrula(no):
	if type(no) == type(12) and len(str(no)) == 11 and no > 0:
		x = list(str(no))
		a, b, c = 0, 0, 0
		for i in range(1, 10, 2):
			a += int(x[i - 1])
		for i in range(2, 9, 2):
			b += int(x[i - 1])
		d = (7 * a - b) % 10
		durum1 = d == int(x[9])
		for i in range(1, 11):
			c += int(x[i - 1])
		durum2 = (c % 10) == int(x[10])
		if durum1 and durum2:
			print "TC kimlik numarasi gecerlidir..."
		else:
			print "TC kimlik numarasi gecerli degildir..."
	else:
		print "lutfen 11 basamakli bir tamsayi giriniz..."
#örnek
tc_no_dogrula(10000000146)
tc_no_dogrula(15826446754)
