def en_buyuk_eleman(listem, x = []):
	#~ a = []
	for i in listem:
		if type(i) == type([]):
			en_buyuk_eleman(i)
		elif type(i) == type(5):
			x.append(i)
	return max(x)
print en_buyuk_eleman([1, 5, 78, 54, 489, [5456885,[1111111111111, 54789658565, 4645186748518452], 45], 54, 788, 26, 6554])
