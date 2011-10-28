#!/usr/bin/python
#-*-coding:utf-8-*-
liste = ["kde", 124, "mesut", 145, 478, 5562, 456, "", 2.4, 4.4, ["a", 14, 1.5], True, ]
def liste_analizi(liste):
	str_sayisi, int_sayisi, flt_sayisi, lst_sayisi, bln_sayisi = 0, 0, 0, 0, 0
	for i in liste:
		if type(i) == type("mesut"):
			str_sayisi += 1
		elif type(i) == type(1254):
			int_sayisi += 1
		elif type(i) == type(0.1):
			flt_sayisi += 1
		elif type(i) == type(True):
			bln_sayisi += 1
		elif type(i) == type([]):
			lst_sayisi += 1
	print "karekter dizisi sayisi:", str_sayisi, "\ntamsayi sayisi:", int_sayisi, "\nondalikli sayi sayisi:", flt_sayisi, "\nboolean sayisi:", bln_sayisi, "\nliste sayisi:", lst_sayisi
liste_analizi(liste)








