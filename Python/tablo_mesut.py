#!/usr/bin/python
#-*-coding:utf-8-*-
from gasp import *
import time

begin_graphics(background = (0, 0, 245))
ogr_sayi = input("Lutfen ogrenci sayisini giriniz:")
	
		
def arkaplan_ciz():
	j = 390
	Text("İSİMLER", (50, j+50), color = (255, 0, 0), size=30)
	Text("PUANLAR", (300, j+50), color = (255, 0, 0), size=30)
	Line((0, j+40), (1000, j+40), color = (0, 0, 25))
	Line((250, 0), (250, 1000), color = (0, 0, 25))

def bilgi_al():
	j = 400
	for i in range(ogr_sayi):
		isim = raw_input("Ogrenci ismini giriniz")
		puan = input("Bu ogrencinin notunu giriniz (0-100)")
		Text(isim, (50, j), color = (255, 255, 255), size=25)
		Box((300, j), puan , 25, filled = True, color = (255, 255, 0))
		j = j - 50
	sleep(3)
	end_graphics()	
arkaplan_ciz()
bilgi_al()
