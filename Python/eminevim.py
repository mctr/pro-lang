#! usr/bin/python
# -*- coding: utf-8 -*-

# Eminevim sisteminin nasıl çalıştıgını nasıl ve ne kadar kar elde ettiklerini araştırıyorum.


def main(): # n = 100 için işlem yapacagız.
	n = 100
	first_charge = 7000
	aylik_dokum = []
	total_first_charge = first_charge * n
	gived_charge = 140000

	m = n / 2


	collected_money = total_first_charge

	for i in range(1, m):
		collected_money -= gived_charge
		collected_money += 700 * (m - i)
		collected_money += 1900 * (i)

		aylik_dokum.append(collected_money)
	
	collected_money -= 140000 * 50

	for i in range(51, 100):
    	collected_money += 1900 * 100
    	aylik_dokum.append(collected_money)
    


	print aylik_dokum
	print aylik_dokum[len(aylik_dokum) - 1]


