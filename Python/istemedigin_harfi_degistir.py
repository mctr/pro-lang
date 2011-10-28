def sil(s, ch, nch):
	yeni_s = ""
	for i in s:
		if i == ch:
			yeni_s += nch
			#~ pass
		else:
			yeni_s += i
	print yeni_s
sil("mesut", "m", "t")
