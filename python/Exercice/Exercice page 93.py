# Exercice 8.9 Inspirez-vous du script précédent pour écrire une petite
# application qui fait apparaître un damier (dessin
# de cases noires sur fond blanc) lorsque l’on clique sur
# un bouton :

from tkinter import *

def case(couleur):
    global x1,y1,x2,y2
    canvas.create_rectangle(x1,y1,x2,y2,width=1,fill=couleur)

def damier():
    colone,rangee=0,0
    global x1,y1,x2,y2,couleur1,couleur2
    while colone!=10:
        while rangee!=10:
            if (colone+rangee)%2:
                case(couleur1)
                x1,x2=x1+40,x2+40
                rangee+=1
            else:
                case(couleur2)
                x1,x2=x1+40,x2+40
                rangee+=1
        colone+=1
        x1,y1,x2,y2,rangee=0,y1+40,40,y2+40,0
                
    

x1,y1,x2,y2,couleur1,couleur2=40,0,0,40,"black","white"
fenetre=Tk()
canvas=Canvas(fenetre,width=400,height=400,bg="grey")
canvas.pack(side=TOP,padx=10,pady=10)
bouton1=Button(fenetre,text="quitter",command=fenetre.quit)
bouton1.pack(padx=3,pady=3)
bouton2=Button(fenetre,text="damier",command=damier)
bouton2.pack(side=LEFT,padx=3,pady=3)
fenetre.mainloop()
fenetre.destroy()

# Exercice 8.10. À l'application de l'exercice précédent, ajoutez un bouton
# qui fera apparaître des pions au hasard sur le damier
# (chaque pression sur le bouton fera apparaître un nouveau pion).

from tkinter import *
from random import randrange

def case(couleur):
    global x1,y1,x2,y2
    canvas.create_rectangle(x1,y1,x2,y2,width=1,fill=couleur)

def damier():
    colone,rangee=0,0
    global x1,y1,x2,y2,couleur1,couleur2,pions
    while colone!=10:
        while rangee!=10:
            if (colone+rangee)%2:
                case(couleur1)
                x1,x2=x1+40,x2+40
                rangee+=1
            else:
                case(couleur2)
                x1,x2=x1+40,x2+40
                rangee+=1
        colone+=1
        x1,y1,x2,y2,rangee=0,y1+40,40,y2+40,0
    x1,y1,x2,y2,pions=40,0,0,40,[]
def pion():
    global pions,x1,y1,x2,y2
    xy=(randrange(10)+1,randrange(10)+1)
    while True:
        if len(pions)==100:
            xy=(0,0)
            break
        if xy not in pions:
            pions.append(xy)
            break
        else:
            xy=(randrange(10)+1,randrange(10)+1)
    canvas.create_oval(40*xy[0],40*(xy[1]-1),40*(xy[0]-1),40*xy[1],width=1,fill="red")
        

x1,y1,x2,y2,couleur1,couleur2=40,0,0,40,"black","white"
pions=[]
fenetre=Tk()
canvas=Canvas(fenetre,width=400,height=400,bg="grey")
canvas.pack(side=TOP,padx=10,pady=10)
bouton1=Button(fenetre,text="quitter",command=fenetre.quit)
bouton1.pack(padx=3,pady=3)
bouton2=Button(fenetre,text="damier",command=damier)
bouton2.pack(side=LEFT,padx=3,pady=3)
bouton3=Button(fenetre,text="piona léatoire",command=pion)
bouton3.pack(side=RIGHT,padx=3,pady=3)
fenetre.mainloop()
fenetre.destroy()
