def ustun_modunu_alma(taban,ust,mod):
	if ust == 0:
		return 1
	t = (taban * taban) % mod
	tmp = ustun_modunu_alma(t, ust / 2, mod)
	if ust % 2 != 0:
		tmp = (tmp * taban) % mod
	return tmp
	
#~ print ustun_modunu_alma(2,6,10)
