import copy

def determinant(listem):
    result = 0

    if(len(listem) == 1):
        return listem[0][0]

    if(len(listem) == 2): #dogru
        # 2li matrisin determinanti
        return (listem[0][0] * listem[1][1]) - (listem[0][1] * listem[1][0])

    for sutun in range(len(listem)):

        # listeyi kopyala
        temporary = copy.deepcopy(listem)

        # satiri sil
        del temporary[0]

        for i in range(len(temporary)):
            # secilen elemanin sutunlarini sil
            del temporary[i][sutun]

        # kofaktor
        result += determinant(temporary) * ((-1) ** (0 + sutun)) * listem[0][sutun]

    return result


print determinant([[4, 9],[6, 4]])
print determinant([[5, 3, 7], [2, 4, 9], [3, 6, 4]])

