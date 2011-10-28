#/usr/bin/python
#-*- coding: utf-8 -*-
def fakt(sayi):
	if sayi == 0 or sayi == 1:
		return 1
	elif sayi > 0:
		return sayi * fakt(sayi - 1)
	elif sayi < 0:
		return "negatif tamsayilarin faktoriyel hesaplamasi yapilamaz.."
print fakt(6)
print fakt(-5)
