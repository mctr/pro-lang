#! usr/bin/python
# -*- coding: utf-8 -*-

class Soru:
	def __init__(self):
		self.soru = raw_input("Soru Cümlesi :")
	

class Secenek(Soru):
	def __init__(self):
		Soru.__init__(self)
		self.dogru = []
		
	def secenekler(self):
		self.secenek1 = raw_input("Secenek 1 :")
		cevap = raw_input("Dogru mu? :(E/H)")
		if cevap in "Ee":
			self.dogru.append("A")
		
		self.secenek2 = raw_input("Secenek 2 :")
		cevap = raw_input("Dogru mu? :(E/H)")
		if cevap in "Ee":
			self.dogru.append("B")
		
		self.secenek3 = raw_input("Secenek 3 :")
		cevap = raw_input("Dogru mu? :(E/H)")
		if cevap in "Ee":
			self.dogru.append("C")
	
		self.secenek4 = raw_input("Secenek 4 :")
		cevap = raw_input("Dogru mu? :(E/H)")
		if cevap in "Ee":
			self.dogru.append("D")
	
		self.secenek5 = raw_input("Secenek 5 :")
		cevap = raw_input("Dogru mu? :(E/H)")
		if cevap in "Ee":
			self.dogru.append("E")


class Dogru(Secenek):
	def __init__(self):
		self.yanit = None
		Secenek.__init__(self)
		
	def soru_yazdir(self):       # Ekrana soruyu yazdırmamızı saglayan fonksiyon
		print self.soru
		print "A )", self.secenek1
		print "B )", self.secenek2
		print "C )", self.secenek3
		print "D )", self.secenek4
		print "E )", self.secenek5
	
	def Kontrol_CTS(self):       # Çoktan Tek seçmeli soruların dogrulugunu kontrol eden fonksiyon
		self.yanit = raw_input("Cevabiniz (A..E):")
		if self.yanit not in self.dogru:
			print "Yanitiniz-",self.yanit,",", "Dogrusu-", self.dogru[0], ".", "Puan: 0"
		elif self.yanit in self.dogru:
			print "Tebrikler dogru yanit", "Puan: 1"
			
	def Kontrol_CCS(self):        # Çoktan Çok seçmeli soruların dogrulugunu kontrol eden fonksiyon
		self.yanit = raw_input("Cevabiniz (A..E):(Lütfen cevaplarınızı sırayla ve  aralarında boşluk bırakarak giriniz!!)")
		if self.yanit.split() != self.dogru:
			print "Yanitiniz-",self.yanit,",", "Dogrusu-", self.dogru, ".", "Puan: 0"
		
		else:
			print "Tebrikler dogru yanit", "Puan: 1"

class SoruCTS(Dogru):
	
	def __init__(self):
		Dogru.__init__(self)
		self.secenekler()
		
	def sor(self): 
		self.soru_yazdir()
		self.Kontrol_CTS()
	
class SoruCCS(Dogru):
	
	def __init__(self):
		Dogru.__init__(self)
		self.secenekler()
		
	def sor(self):
		self.soru_yazdir()
		self.Kontrol_CCS()


s1 = SoruCTS()
s1.sor()
