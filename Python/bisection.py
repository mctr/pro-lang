#! usr/bin/python
# -*- coding: utf-8 -*-

from math import *
import string

def yarilama(s, a, b):
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


