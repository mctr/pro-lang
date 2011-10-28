liste = [1, 2, 3, 4, 5, 6]
def myappend(liste, item):
	liste = liste + [item]
	return liste
print myappend(liste, "mesut")

def myinsert(liste, indis, item):
		return liste[:indis] + [item] + liste[indis:]
print myinsert(liste, 1, 6)

def mypop():
	return liste[:len(liste) - 1]
print mypop()

def myindex(item):
	yeni = []
	for i in liste:
		if i != item:
			yeni.append(i)
		elif i == item:
			break
	print len(yeni)
myindex(6)

def myremove(item):
	yeni_liste = []
	for i in liste:
		if i != item:
			yeni_liste.append(i)
		elif i == item:
			pass 
	print yeni_liste
myremove(2)
def myreverse(liste):
	y_liste = []
	a = len(liste)
	for i in range(a - 1, -1, -1):
		y_liste.append(liste[i])
	print y_liste
myreverse(liste)






