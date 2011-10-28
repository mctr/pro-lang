def maximum_sayi(sayi):
    buyukluk=[]
    for rakam in sayi:
        buyukluk.append(ord(rakam))
    n=len(buyukluk)
    while 0 < n:
        print str(max(buyukluk)-48),
        buyukluk.remove(max(buyukluk))
        n-=1
maximum_sayi("15487")

