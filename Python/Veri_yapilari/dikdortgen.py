from graphics import *

def dikdortgen(points,level,win):    

    colormap = ['blue','red','green','white'] #,'yellow','violet','orange']

    p = Polygon(points)

    p.setFill(colormap[level-1])

    p.draw(win)    

    time.sleep(1)

    if level > 0:
		
		# sol-alt dikdortgen
		
		dikdortgen([points[0], getir(points[0],points[1]),getir(points[0],points[2]),getir(points[0],points[3])],level-1 ,win)
		
		# sol-ust dikdortgen
		
		dikdortgen([getir(points[0],points[1]),points[1],getir(points[1],points[2]),getir(points[1],points[3])],level-1 ,win)
		
		# sag-ust dikdortgen
		
		dikdortgen([getir(points[0],points[2]),getir(points[1],points[2]),points[2],getir(points[2],points[3])],level-1 ,win)
		
		# sag-alt dikdortgen
		
		dikdortgen([getir(points[0],points[3]),getir(points[1],points[3]),getir(points[2],points[3]),points[3]],level-1 ,win)

    
def getir(p1,p2):

    return Point( ((p1.getX()+p2.getX()) / 2.0),((p1.getY()+p2.getY()) / 2.0) )

if __name__ == '__main__':

    win = GraphWin('screen',1000,500)

    win.setCoords(-30,-30,80,80)

    myPoints = [Point(0,0),Point(0,40),Point(60,40),Point(60,0)]

    dikdortgen(myPoints,3,win)



