# ------------- Exercice 8.29 ------------- #
# Écrivez un programme dans lequel évoluent plusieurs balles de couleurs différentes,
# qui rebondissent les unes sur les autres ainsi que sur les parois.

from tkinter import *
from math import *
from random import randrange

"""
def zoneI():
    global x,y,d,zi,dy,dy2,dx,dx2,x2,y2
    if x >zi[1][0][0] and x <zi[1][0][1] and y >zi[1][1][0] and y <zi[1][1][1]:
        dxd,x2=-dx,-dx2
        dy,dy2=-dy,-dy2
        print("ok")
    del zi
    zi=[((x-d,x+d),(y-d,y+d)),((x2-d,x2+d),(y2-d,y2+d))]
    print(zi,x,y,x2,y2)"""

def bordure():
    global d,dx,dy,dv,x,x2,y,y2,dx2,dy2,al

    if x+d > 600-d:
        dx=-dx
    if x-d < 0+d:
        dx=-dx
    if y+d > 500-d:
        dy=-dy
    if y-d < 0+d:
        dy=-dy
    if x2 > 600-d:
        dx2=-dx2
    if x2 < 0+d:
        dx2=-dx2
    if y2 > 500-d:
        dy2=-dy2
    if y2 < 0+d:
        dy2=-dy2
    if len(can.find_overlapping(x+d, y-d, x-d, y+d))>1:
        while True:
            dx,dy=al[randrange(3)],al[randrange(3)]
            if dx==0 and dy==0:
                dx,dy=al[randrange(3)],al[randrange(3)]
            else:
                break
    if len(can.find_overlapping(x2+d, y2-d, x2-d, y2+d))>1:
        while True:
            dx2,dy2=al[randrange(3)],al[randrange(3)]
            if dx2==0 and dy2==0:
                dx2,dy2=al[randrange(3)],al[randrange(3)]
            else:
                break
    x, y = (x+(dx*dv)),(y+(dy*dv))
    x2,y2= (x2+(dx2*dv)),(y2+(dy2*dv))
    can.coords(1,x+d,y-d,x-d,y+d)
    can.coords(2,x2+d,y2-d,x2-d,y2+d)
    fen.after(50,bordure)
al=(-1,1,0)
dv,d=5,10
x,y=50,100
dx,dy=1,1
x2,y2=250,300
dx2,dy2=-1,-1
zi=[((x-d,x+d),(y-d,y+d)),((x2-d,x2+d),(y2-d,y2+d))]
x3,y3=400,400
fen=Tk()
can=Canvas(fen,width=600,height=500,bg="white")
can.grid(row=10,column=10)
Button(fen,text="quitter",bg="red",command=fen.quit).grid(row=9,column=10,sticky=E)
Button(fen,text="Start",command=bordure).grid(row=9,column=10,sticky=W)
#Button(fen,text="Stop",command=stop).grid(row=9,column=10,sticky=W,padx=50)
#Button(fen,text="Ajouter balle",command=add_boule).grid(row=9,column=10,sticky=W,padx=100)
can.create_oval(x+d,y-d,x-d,y+d,fill="red")
can.create_oval(x2+d,y2-d,x2-d,y2+d,fill="orange")
can.create_oval(x3+d+30,y3-d-30,x3-d-30,y3+d+30,fill="orange")
fen.mainloop()
fen.destroy()
