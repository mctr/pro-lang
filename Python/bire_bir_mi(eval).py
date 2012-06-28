#!usr/bin/python
# -*- coding:utf-8 -*-

from math import *
import string
def bire_bir(s, n):
    sonuc = []
    x = 1
    while True:
        liste = list(s)
        
        for indis in range(len(s)):
			if s[indis] == "x":
				#~ pass
				liste[indis]=str(x)

        fonk = eval(string.join(liste, ''))
        print fonk
        if (fonk in sonuc):
            return "bire-bir degil"
            #~ break
        else:
            sonuc.append(fonk)
            x += 1
        if n == x:
            return "birebir"
            #~ break
print bire_bir("x**3 + x - 2", 3)
#~ print bire_bir("sin(x)", 60)
#~ print bire_bir("x", 60)
#~ print bire_bir("sin(x) + factorial(5)", 360) # sin ve cos lu degerler verildiginde bire bir buluyor o yüzden pi / 2 veya pi seklinde kullanılacak...
#~ print bire_bir("(-1) ** x + 25", 360) # factorial(n) şeklinde kullanılacak yani pythondaki math kütüphanesinde nasılsa öyle kullanılacak...

