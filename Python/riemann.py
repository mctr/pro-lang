#! usr/bin/python
# -*- coding: utf-8 -*-

# f(x) = x^2 fonksiyonunun [0, 1]'de n'ye kadar olan yarılanma için alt ve üst toplamları

def function(x):
	return x * x

def main(n):
	sub_sum, top_sum = 0, 0
	
	piece = 1.0 / n
	liste = [0]
	
	for i in range(n):
		liste.append(liste[i] + piece)
		
	for i in range(n):
		sub_sum += piece * (function(liste[i]))
	
	for i in range(1,n+1):
		top_sum += piece *(function(liste[i]))
	
	print "Alt Toplam :", sub_sum
	print "Üst Toplam :", top_sum
	print "Fark :", (top_sum - sub_sum)

main(10000)
### main(4)
### n = 4 için Örnek Çıktı
# Alt Toplam : 0.21875
# Üst Toplam : 0.46875
# Fark : 0.25

### main(10)
### n = 10 için Örnek Çıktı
# Alt Toplam : 0.285
# Üst Toplam : 0.385
# Fark : 0.1
