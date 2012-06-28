#! usr/bin/python
# -*- coding: utf-8 -*-

import math

def f(x):
	return (math.e ** x - 5)
	
def f_trv(x):  #Türev fonksiyonu
	return (math.e ** x)

######################## Bisection(Yarilama) YÖntemi #############################

def bisection(a, b):
	if f(a) * f(b) < 0:
		m0 = (a + b) / 2.0
		if f(m0) == 0:
			print m0
		elif f(a) * f(m0) < 0:
			bisection(a, m0)
		elif f(a) * f(m0) > 0:
			bisection(m0, b)
	else:
		print "bu fonksiyonun bu aralikta koku yoktur.."

###################### Newton-Raphson yontemi ############################################

def Newton(x, eps):
	#~ x = input("lutfen baslangic degerini giriniz : ") #Başlangıç degeri ne verilirse verilsin sonuç degişmez
	#~ eps = input("epsilonu giriniz [10**n] : ")
	#~ x, eps = 1.5, 10 **-6
	while True:
		y = x - (float(f(x)) / f_trv(x))
		if abs(y - x) < eps:
			return y
		else:
			x = y
			# Başlangıç değeri fonksiyonun çalışma hızını etkiliyor. Zaman:başlangıç değerinin köke olan uzaklığına bağlı olarak artıyor. 

######################### Secont Yontemi ########################################

def Secont(a, b):
	#~ x = input("lutfen baslangic degerini giriniz : ") # x0 - Başlangıç degeri ne verilirse verilsin sonuç degişmez
	#~ y = input("lutfen ikinci baslangic degerini giriniz : ") # x1
	#~ eps = input("epsilonu giriniz [10**n] : ")
	x, y, eps = 2, 4, 10 ** -6
	while True:
		z = ((x * f(y)) - (y * f(x))) / (f(y) - f(x)) # x2 veya bir başka değişle xn
		if abs(z - y) < eps:
			return z
		else:
			x, y = y, z

##################### Regulafalsi Yöntemi ###################################

def Regulafalsi(a,b, eps):
	if (f(a) * f(b)) < 0:
		y = ((float(a) * f(b)) - (b * f(a))) / (f(b) - f(a))
		if f(a) * f(y) < 0:
			z = ((float(a) * f(y)) - (y * f(a))) / (f(y) - f(a))
			if abs(z - y) < eps:
				print z
			else:
				Regulafalsi(a, z, eps)
		elif f(y) * f(b) < 0:
			z = ((float(b) * f(y)) - (y * f(b))) / (f(y) - f(b))
			if abs(z - y) < eps:
				print z
			else:
				Regulafalsi(b, z, eps)
	else:
		print "bu fonksiyonun bu aralikta koku yoktur.."

bisection(1,2)
print Newton(1, 10**-6)
print Secont(1, 2)
Regulafalsi(1,2, 10**-6)
