def donusum(a):
    b=[]
    for i in a:
        b=b+[i]
    if b[0]== "0":
        if b[1]=="b":
            print("Binary: ",int(a, 2))
        elif b[1]=="x":
            print ("hexadecimal: ",int(a, 16))
        else:
            print("Octal: ",int(a, 8))
    else:
        print("Decimal: ", int(a))

donusum("0b1011")
