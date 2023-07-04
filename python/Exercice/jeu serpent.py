from tkinter import *
from math import*
from random import randrange
al=(5,-5)
def gauche(event):
    global dx,dy,flag
    if flag==0:
        flag=1
        move()
        dx,dy=-5,0
    if dx==-5 or dx==5:
        pass
    else:
        dx,dy=-5,0
        flag=0
        move()
        flag=1
def droite(event):
    global dx,dy,flag
    if flag==0:
        flag=1
        move()
        dx,dy=5,0
    if dx==-5 or dx==5:
        pass
    else:
        dx,dy=5,0
        flag=0
        move()
        flag=1
def haut(event):
    global dx,dy,flag
    if flag==0:
        flag=1
        move()
        dx,dy=0,-5
    if dy==-5 or dy==5:
        pass
    else:
        dx,dy=0,-5
        flag=0
        move()
        flag=1
def bas(event):
    global dx,dy,flag
    if flag==0:
        flag=1
        move()
        dx,dy=0,5
    if dy==-5 or dy==5:
        pass
    else:
        dx,dy=0,5
        flag=0
        move()
        flag=1
def add_serpent():
    global listeP,listeAdd,d,num,v
    num+=1
    if num%8==0 and v > 20:
        v=v-5
    listeP.append((listeAdd[0],listeAdd[1],num))
    can.create_rectangle(listeAdd[0]+d,listeAdd[1]-d,listeAdd[0]-d,listeAdd[1]+d,outline="gray",fill="gray")

        
    
def move():
    global listeP,dx,dy,dv,d,listeAdd,flag,proie,compare,v
    listePT=[]
    x,y=listeP[0][0],listeP[0][1]
    compare=(x,y)
    x,y=x+dx,y+dy
    can.coords(2,x+d,y-d,x-d,y+d)
    listePT.append((x,y,2))
    for n in listeP:
        xt,yt=n[0],n[1]
        can.coords(n[2]+1,xt+d,yt-d,xt-d,yt+d)
        listePT.append((xt,yt,n[2]+1))
    listeAdd=listePT[-1]
    del listePT[-1]
    listeP=listePT
    x,y=listeP[0][0],listeP[0][1]
    if (x-d)<0:
        end()
    if (x+d)>500:
        end()
    if (y-d)<0:
        end()
    if (y+d)>500:
        end()
    if len(can.find_overlapping(x+d,y-d,x+d,y-d))>1 and len(can.find_overlapping(x-d,y-d,x-d,y-d))>1 and len(can.find_overlapping(x+d,y+d,x+d,y+d))>1 and len(can.find_overlapping(x-d,y+d,x-d,y+d))>1:
        end()
    xp,yp=proie[0],proie[1]
    if len(can.find_overlapping(xp+dP,yp-dP,xp-dP,yp+dP))>1:
        colision()
    if flag>0:
        fen.after(v,move)
    
def colision():
    global listeP, point,proie,d,flag,can,dP
    xp,yp=proie[0],proie[1]
    if len(can.find_overlapping(xp+dP,yp-dP,xp-dP,yp+dP))>1:
        while True:
            xp,yp=randrange(20,480),randrange(20,480)
            can.coords(1,xp+dP,yp-dP,xp-dP,yp+dP)
            if len(can.find_overlapping(xp+dP,yp-dP,xp-dP,yp+dP))>1:
                pass
            else:
                break
        point+=1
        add_serpent()
        proie=(xp,yp,1)
def end():
    global listeP, point,proie,d,flag,can,dP
    listeP=[(250,250,2),(255,250,3)]
    print("Record: ",point,"pts")
    point=0
    flag=0
    can.delete("all")
    can=Canvas(fen,width=500,height=500,bg="white")
    can.grid(row=1,column=1)
    can.create_rectangle(proie[0]+dP,proie[1]-dP,proie[0]-dP,proie[1]+dP,fill="black")
    can.create_rectangle(250+d,250-d,250-d,250+d,outline="black",fill="gray")
    #can.create_rectangle(255+d,250-d,255-d,250+d,outline="gray",fill="gray")

listeP,d,listeAdd,dP=[(250,250,2),(255,250,3)],10,[],5
dx,dy,num,point=0,0,3,0
proie,flag,compare,v=(100,100,1),0,(0,0),50

fen=Tk()
can=Canvas(fen,width=500,height=500,bg="white")
can.grid(row=1,column=1)
can.create_rectangle(proie[0]+dP,proie[1]-dP,proie[0]-dP,proie[1]+dP,fill="black")
can.create_rectangle(250+d,250-d,250-d,250+d,outline="black",fill="gray")
#can.create_rectangle(255+d,250-d,255-d,250+d,outline="gray",fill="gray")
Button(fen,text="Quitter",bg="red",command=fen.quit).grid(row=0,column=1,sticky=E)
Button(fen,text="Add",bg="blue",command=add_serpent).grid(row=0,column=1,sticky=W,)
fen.bind("<Left>",gauche)
fen.bind("<Right>",droite)
fen.bind("<Up>",haut)
fen.bind("<Down>",bas)

fen.mainloop()
fen.destroy()
