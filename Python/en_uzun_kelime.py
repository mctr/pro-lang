def en_uzun(cumle):
	l = cumle.split()
	uzunluk = len(l)
	yeni = []
	for i in l:
		yeni.append(len(i))
	a = yeni.index(max(yeni))
	b = yeni.index(min(yeni))
	print "en uzun kelime:",l[a],"\nuzunluk:",len(l[a])
	print "en kisa kelime:",l[b],"\nuzunluk:",len(l[b])
en_uzun("seni cok seviyorum diyene inanma")
