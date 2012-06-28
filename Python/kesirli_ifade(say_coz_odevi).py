#!/usr/bin/env python
# -*- coding: utf-8 -*-

import random

def bul(pay,payda):
	i = 2
	if pay > payda:
		print "lütfen basit kesirler ile işlem yapınız."
		return
	while i < 1234:
		if i * pay != payda:
			j = (float(i) * payda) / (i * pay - payda)
			if int(j) == j and j > 0 and i != j:
				print pay, "/", payda, "=", "1 /", i,"+ 1 /", int(j)
				return
			j = 2
			while j < 1234:
				if (i * j * pay) != (payda * (i + j)):
					z = (i * j * payda) / ((i * j * pay) - (payda * (i + j)))
					if int(j) == j and j > 0 and z > 0 and int(z) == z and i != j and j != z and i != z:
						print pay, "/", payda, "=", "1 /", i,"+ 1 /", int(j), "+ 1 /", int(z)
						return
				j += 1
		i += 1
	print "uygun değerler bulamadık.Neyse artık bir dahaki sefere :("

#~ bul(1,2)
#~ bul(4,5)
#~ bul(3,4)
#~ bul(4,2)
#~ bul(31,97)
#~ bul(1234,2345)
