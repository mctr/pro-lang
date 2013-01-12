#! usr/bin/python
# -*- coding :utf-8 -*-
def fib(a):
	if a < 2:
		return 1
	else:
		return fib(a-1) + fib(a-2)
		
#~ print fib(6)

def fak(a):
	if a < 2:
		return 1
	else:
		return a * fak(a -1)
		
#~ print fak(15)


