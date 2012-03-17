def fill(a,b):
    import Image
    resim=Image.open("Adsiz.png")
    S=[]
    Q=[]
    T=[]
    renk=resim.getpixel((a,b))
    Q.append([a,b])
    while(len(Q)>=1):
        P=Q.pop(0)
        x=P[0]
        y=P[1]
        if(resim.getpixel((x,y))==renk):
            if ([x,y] not in S) :
                S.append([x,y])
                T.append([x,y])

                
                if (x>0) :
                    if([x-1,y] not in S and resim.getpixel((x-1,y))==renk):
                        Q.append([x-1,y])
                    if(y+1<resim.size[1]):
                        if ([x-1,y+1] not in S and resim.getpixel((x-1,y+1))==renk):
                            Q.append([x-1,y+1])
                    if (y>0):
                        if ([x-1,y-1] not in S and resim.getpixel((x-1,y-1))==renk):
                            Q.append([x-1,y-1])
                        

                if (y>0) :
                    if ([x,y-1] not in S and resim.getpixel((x,y-1))==renk):
                                Q.append([x,y-1])
                if (y+1<resim.size[1]):
                    if ([x,y+1] not in S and resim.getpixel((x,y+1))==renk ):
                        Q.append([x,y+1] )
                        
               
                if (x+1<resim.size[0]):
                    if ([x+1,y] not in S and resim.getpixel((x+1,y))==renk) :
                        Q.append([x+1,y])
                    if ( y+1<resim.size[1]):
                        if ([x+1,y+1] not in S and resim.getpixel((x+1,y+1))==renk):
                            Q.append([x+1,y+1])
                    if (y>0):
                       if ([x+1,y-1] not in S and resim.getpixel((x+1,y-1))==renk):
                            Q.append([x+1,y-1])
                    
    while(len(S)>0):
        elemanimiz=S.pop()
        resim.putpixel((elemanimiz[0],elemanimiz[1]),(0, 0, 255, 255))
    resim.show()
            
            
fill(50, 100)
