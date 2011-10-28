#! usr/bin/python
# -*- coding: utf-8 -*-
import doctest
def egim_hesapla(x1, y1, x2, y2):
	"""
	>>> egim_hesapla(5, 3, 4, 2)
	1.0
	"""
	sonuc = (y2 - y1) / (x2 - x1)
	print float(sonuc)

if __name__ == '__main__':
	import doctest
	doctest.testmod()
	
	
egim_hesapla(5, 3, 4, 2)
egim_hesapla(1, 2, 3, 2)
