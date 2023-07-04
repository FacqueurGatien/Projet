# Exercice 8.17
# Écrivez un programme qui fait apparaître une fenêtre avec un canevas.
# Dans ce canevas, placez un petit cercle censé représenter une balle.
# Sous le canevas, placez un bouton.
# Chaque fois que l’on clique sur le bouton, la balle doit avancer d’une petite distance vers la droite,
# jusqu’à ce qu’elle atteigne l’extrémité du canevas.
# Si l’on continue à cliquer, la balle doit alors revenir en arrière jusqu’à l’autre extrémité, et ainsi de suite.

from tkinter import *

def change_depl():
    global depl,x1
    if x1>=500:
        depl=-30
    if x1<=20:
        depl=30
    deplx()
    
def deplx():
    global depl,x1,x2,y1,y2
    x1,x2=x1+depl,x2+depl
    canvas.coords(boule,x1,y1,x2,y2)

x1,y1,x2,y2,depl=260,140,240,160,30
fenetre=Tk()
canvas=Canvas(fenetre,width=500,height=300,bg="black")
canvas.grid(row=10,column=10)
Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=11,column=10)
Button(fenetre,text="Deplacement",command=change_depl).grid(row=9,column=10)
boule=canvas.create_oval(x1,y1,x2,y2,width=1,outline="yellow",fill="yellow")

fenetre.mainloop()
fenetre.destroy()

##################################################
# Exercice 8.18 et 8.19
# Améliorez le programme ci-dessus pour que la balle décrive cette fois une trajectoire circulaire ou elliptique dans le canevas (lorsque l’on clique continuellement). Note :
# pour arriver au résultat escompté, vous devrez nécessairement définir une variable qui représentera l’angle décrit,
# et utiliser les fonctions sinus et cosinus pour positionner la balle en fonction de cet angle.
###########################
# Modifiez le programme ci-dessus de telle manière que la balle, en se déplaçant,
# laisse derrière elle une trace de la trajectoire décrite.

from tkinter import *
from math import *
def anglex():
    global angle,x1,y1
    angle=angle+0.1
    x2,y2=x1,y1
    x1,y1=sin(angle),cos(angle)
    x1,y1=int(250+x1*160),int(250+y1*160)
    canvas.coords(boule,x1-2,y1-2,x1+2,y1+2)
    canvas.create_line(x2,y2,x1,y1,fill="blue")


angle,x1,y1=0.0,250.0+sin(0)*160.0,250+cos(0)*160.0
fenetre=Tk()
canvas=Canvas(fenetre,width=500,height=500,bg="black")
canvas.grid(row=10,column=10)
Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=12,column=10)
boule=canvas.create_oval(x1-2,y1-2,x1+2,y1+2,width=2,outline="yellow",fill="yellow")
Button(fenetre,text="deplace",command=anglex).grid(row=11,column=10)

fenetre.mainloop()
fenetre.destroy()

#############################################################
# Exercice 8.20
# Modifiez le programme ci-dessus de manière à tracer d’autres figures.
# Consultez votre professeur pour des suggestions (courbes de Lissajous).

from tkinter import *
from math import *
def anglex(x):
    global angle,x1,y1
    t=63
    if x==2:
        angle,x1,y1=0.0,250.0+sin(0)*160.0,250+cos(0)*160.0
        while t:
            angle=angle+0.1
            x2,y2=x1,y1
            x1,y1 = sin(2*angle), cos(3*angle)
            x1,y1=int(250+x1*160),int(250+y1*160)
            canvas.coords(boule,x1-2,y1-2,x1+2,y1+2)                            
            canvas.create_line(x2,y2,x1,y1,fill="blue")
            t-=1
    if x==3:
        angle,x1,y1=0.0,250.0+sin(0)*160.0,250+cos(0)*160.0
        while t:
            angle=angle+0.1
            x2,y2=x1,y1
            x1,y1=sin(angle),cos(angle)
            x1,y1=int(250+x1*160),int(250+y1*160)
            canvas.coords(boule,x1-2,y1-2,x1+2,y1+2)
            canvas.create_line(x2,y2,x1,y1,fill="blue")
            t-=1
    else:
        while t:
            angle=angle+0.1
            x2,y2=x1+20,y1     #jolie figure
            x1,y1=sin(angle),cos(angle)
            x1,y1=int(240+x1*160),int(250+y1*160)
            canvas.coords(boule,x1-2,y1-2,x1+2,y1+2)
            canvas.create_line(x2,y2,x1,y1,fill="blue")
            t-=1
"""
def anglex():
    global angle,x1,y1
    t=63
    while t:
        angle=angle+0.1
        x2,y2=x1,y1
        x1,y1=sin(angle),cos(angle)
        x1,y1=int(250+x1*160),int(250+y1*160)
        canvas.coords(boule,x1-2,y1-2,x1+2,y1+2)
        canvas.create_line(x2,y2,x1,y1,fill="blue")
        t-=1
"""

x,angle,x1,y1=0,0.0,250.0+sin(0)*160.0,250+cos(0)*160.0
fenetre=Tk()
canvas=Canvas(fenetre,width=500,height=500,bg="black")
canvas.grid(row=10,column=10)
Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=15,column=10)
boule=canvas.create_oval(x1-2,y1-2,x1+2,y1+2,width=2,outline="yellow",fill="yellow")
Button(fenetre,text="jolie figure",command=lambda x=1:anglex(x)).grid(row=11,column=10)
Button(fenetre,text="courbe de Lissajous",command=lambda x=2:anglex(x)).grid(row=12,column=10)
Button(fenetre,text="cercle",command=lambda x=3:anglex(x)).grid(row=13,column=10)
fenetre.mainloop()
fenetre.destroy()

#####################################################################################
# Exercice 8.21
# Écrivez un programme qui fait apparaître une fenêtre avec un canevas et un bouton.
# Dans le canevas, tracez un rectangle gris foncé, lequel représentera une route,
# et par-dessus, une série de rectangles jaunes censés représenter un passage pour piétons.
# Ajoutez quatre cercles colorés pour figurer les feux de circulation concernant les piétons et les véhicules.
# Chaque utilisation du bouton devra provoquer le changement de couleur des feux :

from tkinter import *
from math import *

def switch_on_off ():
    global a,coul1,coul2
    if a%2:
        a
        canvas.itemconfigure(feux_HG,fill=coul1)
        canvas.itemconfigure(feux_BD,fill=coul1)
        canvas.itemconfigure(feux_HD,fill=coul2)
        canvas.itemconfigure(feux_BG,fill=coul2)
        a=2
        print(a)
    else:
        a
        canvas.itemconfigure(feux_HG,fill=coul2)
        canvas.itemconfigure(feux_BD,fill=coul2)
        canvas.itemconfigure(feux_HD,fill=coul1)
        canvas.itemconfigure(feux_BG,fill=coul1)
        a=1
        print(a)

def passage ():
    x,y,t=165,150,5
    canvas.create_rectangle(115,0,385,500,outline="white",fill="white")
    while t:
        canvas.create_rectangle(x,y,x-30,y+200,fill="yellow")
        x,t=x+50,t-1

a,coul1,coul2=2,"green","red"
fenetre=Tk()
canvas=Canvas(fenetre,width=500,height=500,bg="gray")
canvas.grid(row=10,column=10)

passage()
feux_HG=canvas.create_oval(110,90,90,110,fill=coul1)
feux_BD=canvas.create_oval(410,390,390,410,fill=coul1)
feux_HD=canvas.create_oval(410,90,390,110,fill=coul2)
feux_BG=canvas.create_oval(110,390,90,410,fill=coul2)

Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=20,column=10)
Button(fenetre,text="Switch",command=switch_on_off).grid(row=11,column=10)

fenetre.mainloop()
fenetre.destroy()

# Exercice 8.22
# Écrivez un programme qui montre un canevas dans lequel est dessiné un circuit électrique simple (générateur + interrupteur + résistance).
# La fenêtre doit être pourvue de champs d’entrée qui permettront de paramétrer chaque élément (c’est-à-dire choisir les valeurs des résistances et tensions).
# L’interrupteur doit être fonctionnel (prévoyez un bouton « Marche/arrêt » pour cela).
# Des « étiquettes » doivent afficher en permanence les tensions et intensités résultant des choix effectués par l’utilisateur.

from tkinter import *
from math import *
#Détéction du clique de la souris sur le bouton placé sur le canvas
def on_off(event):
    x,y=event.x,event.y
    int(x),int(y)
    if 415>x and x>385 and 265>y and y>235:
        change_color()
    else:
        pass
#Changement des couleur des élément du canvas en fonction de la pression du bouton 
def change_color():
    global coulAmp,coulLine,switch
    switch+=1
    if switch==10:
        switch=0
    if switch%2:
        coulLine,coulAmp="red","yellow"
        ok=(200,100)
        lineE(ok)
        convert()
    else:
        coulLine,coulAmp="black","white"
        nok=(250,50)
        lineE(nok)
        convert()
    recup("<Return>")
#Récuperation des valeur dans les zone de saisie
def recup(event):
    global uv,rr
    uv=tens.get()
    rr=resi.get()
    try:
        rr=eval(rr)
    except (NameError,ValueError,TypeError,SyntaxError,ZeroDivisionError):
        rr="Error"
    try:
        uv=eval(uv)
    except (NameError,ValueError,TypeError,SyntaxError,ZeroDivisionError):
        uv="Error"
    convert()
#Conversion de la résistance et du voltage pour calculer l'amperage
def convert():
    global uv,rr
    if uv=="Error" or rr=="Error":
        resultIA,="Error",
    else:
        try:
            resultIA=str(round((uv/rr),4))
        except (NameError,ValueError,TypeError,SyntaxError,ZeroDivisionError):
            resultIA="0.0"
    afficheLabel(resultIA)
#Affichage des élément selon 
def afficheLabel(resultIA):
    global aa,bb,cc,uv,rr,switch
    if switch%2:
        uva,rra=uv,rr
        resultIAa=resultIA
    else:
        uva,rra=0.,0.
        resultIAa="0.0"
    aa.destroy()
    bb.destroy()
    cc.destroy()
    aa=Label(fenetre,text=": "+resultIAa+" Amp")
    bb=Label(fenetre,text=": "+str(uva)+" Volt")
    cc=Label(fenetre,text=": "+str(rra)+" Ohm")
    aa.grid(row=1,column=0,sticky= W,padx=100)
    bb.grid(row=2,column=0,sticky= W,padx=100)
    cc.grid(row=3,column=0,sticky= W,padx=100)
#Affichage du circuit et de ses elements
def lineE(onOff=(250,50)):
    global coulAmp,coulLine,switch
    a,b,c,d,e,f,g,h,i,j=(100,220),(100,100),(200,100),(300,100),(400,100),(400,235),(400,265),(400,400),(100,400),(100,280)
    liste=[a,b,c,d,e,f,g,h,i,j]
    x1,y1,x2,y2=100,250,400,250
    t=2
    boule=canvas.create_oval(x1+30,y1-30,x1-30,y1+30,width=1,outline="black",fill=coulAmp)
    pressBoutton=canvas.create_rectangle(x2+15,y2-15,x2-15,y2+15,width=1,outline="black",fill="blue")
    canvas.coords(interupt,liste[3][0],liste[3][1],onOff[0],onOff[1])
    canvas.itemconfigure(interupt,fill=coulLine)
    while t:
        canvas.create_line(liste[0][0],liste[0][1],liste[1][0],liste[1][1],width=2,fill=coulLine)
        canvas.create_line(liste[3][0],liste[3][1],liste[4][0],liste[4][1],width=2,fill=coulLine)
        canvas.create_line(liste[6][0],liste[6][1],liste[7][0],liste[7][1],width=2,fill=coulLine)
        del liste[0]
        t-=1
    canvas.create_line(liste[6][0],liste[6][1],liste[7][0],liste[7][1],width=2,fill=coulLine)

#déclaration des variable
coulAmp,coulLine,switch="white","black",0
ia,uv,rr=1.,1.,1.
#création de la fenetre et du anvas
fenetre=Tk()
canvas=Canvas(fenetre,width=600,height=500,bg="gray")
canvas.grid(row=0,column=0,sticky=W,padx=0)
#Création des zonne Entry et des LAbel
tenV=StringVar(fenetre,value=uv)
resV=StringVar(fenetre,value=rr)
tens=Entry(fenetre,textvariable=tenV)
resi=Entry(fenetre,textvariable=resV)
tens.grid(row=1,column=0,sticky=W)
resi.grid(row=2,column=0,sticky=W)
tens.bind("<Return>",recup)
resi.bind("<Return>",recup)
Label(fenetre,text="L'intensité est de ").grid(row=3,column=0,sticky= W)
aa=Label(fenetre,text=":"+"0.0"+" Amp")
bb=Label(fenetre,text=": "+"0.0"+" Volt")
cc=Label(fenetre,text=": "+"0.0"+" Ohm")
aa.grid(row=1,column=0,sticky= W,padx=100)
bb.grid(row=2,column=0,sticky= W,padx=100)
cc.grid(row=3,column=0,sticky= W,padx=100)
#Création des bouton
Button(fenetre,text="Quitter",bg="red",command=fenetre.quit).grid(row=3,column=0,sticky=E,padx=0)
Button(fenetre,text="ON / OFF",command=change_color).grid(row=0,column=0,sticky=W,padx=250)
canvas.bind("<Button-1>",on_off)
interupt=canvas.create_line(300,100,250,50,width=2,fill=coulLine)
#Premiere affichage du circuit (ouvert)
lineE()
#lacement de l'observateur d'evenement
fenetre.mainloop()
fenetre.destroy()
