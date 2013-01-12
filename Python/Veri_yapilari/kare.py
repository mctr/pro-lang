from graphics import *



def kare(points,level,win):    

    colormap = ['blue','red','green','white'] #,'yellow','violet','orange']

    

    p = Polygon(points)

    p.setFill(colormap[level-1])

    p.draw(win)    

    time.sleep(0.2)

    

    if level > 0:

        # sol-alt kare

        kare([points[0],getMid(points[0],points[1]),getMid(points[0],points[2]),getMid(points[0],points[3])],level-1,win)
       
		# sol-ust kare

        kare([getMid(points[0],points[1]),points[1],getMid(points[1],points[2]),getMid(points[1],points[3])],level-1,win)        

        # sag-ust kare

        kare([  getMid(points[0],points[2]),getMid(points[1],points[2]),points[2],getMid(points[2],points[3])],level-1,win)        

        # sag-alt kare

        kare([  getMid(points[0],points[3]),getMid(points[1],points[3]),getMid(points[2],points[3]),points[3]],level-1,win)

    
def getMid(p1,p2):

    return Point( ((p1.getX()+p2.getX()) / 2.0),((p1.getY()+p2.getY()) / 2.0) )


if __name__ == '__main__':

    win = GraphWin('screen',750,750)

    win.setCoords(-30,-30,80,80)

    myPoints = [Point(0,0),Point(0,60),Point(60,60),Point(60,0)]

    kare(myPoints,2,win)



