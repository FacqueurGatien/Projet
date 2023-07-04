"""# ------------- Exercice 8.23 ------------- #
# Dans la fonction start_it(), supprimez l’instruction if flag == 0:
# (et l’indentationdes deux lignes suivantes).
#  Que se passe-t-il ?
# (Cliquez plusieurs fois sur le bouton « Démarrer ».)
# Tâchez d’exprimer le plus clairement possible votre explication des faits observés.

from tkinter import *
# définition des gestionnaires
# d'événements :
def move():
    "déplacement de la balle"
    global x1, y1, dx, dy, flag
    x1, y1 = x1 +dx, y1 + dy
    if x1 >210:
        x1, dx, dy = 210, 0, 15
    if y1 >210:
        y1, dx, dy = 210, -15, 0
    if x1 <10:
        x1, dx, dy = 10, 0, -15
    if y1 <10:
        y1, dx, dy = 10, 15, 0
    can1.coords(oval1,x1,y1,x1+30,y1+30)
    if flag >0:
        fen1.after(50,move) # => boucler, après 50 millisecondes
def stop_it():
    "arrêt de l'animation"
    global flag
    flag =0
def start_it():
    "démarrage de l'animation"
    global flag
    #if flag ==0: # pour ne lancer qu’une seule boucle
    flag =1
    move()
#========== Programme principal =============
# les variables suivantes seront utilisées de manière globale :
x1, y1 = 10, 10 # coordonnées initiales
dx, dy = 15, 0 # 'pas' du déplacement
flag =0 # commutateur
# Création du widget principal ("parent") :
fen1 = Tk()
fen1.title("Exercice d'animation avec tkinter")
# création des widgets "enfants" :
can1 = Canvas(fen1,bg='dark grey',height=250, width=250)
can1.pack(side=LEFT, padx =5, pady =5)
oval1 = can1.create_oval(x1, y1, x1+30, y1+30, width=2, fill='red')
bou1 = Button(fen1,text='Quitter', width =8, command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1, text='Démarrer', width =8, command=start_it)
bou2.pack()
bou3 = Button(fen1, text='Arrêter', width =8, command=stop_it)
bou3.pack()
# démarrage du réceptionnaire d'événements (boucle principale) :
fen1.mainloop()
fen1.destroy()
#-#-#-#-#-#
# Reponse #
#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#
# 1: La boucle se lance et s'arrete a chaque pression sur les boutons corespondant.                         #
# 2: A chaque pression du bouton start, l'apelle de la fonction move crer une nouvelle iteration,           #
# ce qui a pour efete de multiplier l'ajout : de cette ligne a chaque iteration(x1, y1 = x1 +dx, y1 + dy).  #
#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#-#

# ------------- Exercice 8.24 ------------- #
# Modifiez le programme de telle façon que la balle change de couleur à chaque « virage ».

from tkinter import *
# définition des gestionnaires
# d'événements :
def move():
    "déplacement de la balle"
    global x1, y1, dx, dy, flag, coul
    x1, y1 = x1 +dx, y1 + dy
    if x1 >210:
        x1, dx, dy ,coul= 210, 0, 15, "blue"
    if y1 >210:
        y1, dx, dy ,coul= 210, -15, 0, "red"
    if x1 <10:
        x1, dx, dy ,coul= 10, 0, -15, "yellow"
    if y1 <10:
        y1, dx, dy ,coul= 10, 15, 0, "green"
    can1.coords(oval1,x1,y1,x1+30,y1+30)
    can1.itemconfigure(oval1,fill=coul)
    if flag >0:
        fen1.after(50,move) # => boucler, après 50 millisecondes
def stop_it():
    "arrêt de l'animation"
    global flag
    flag =0
def start_it():
    "démarrage de l'animation"
    global flag
    if flag ==0: # pour ne lancer qu’une seule boucle
        flag =1
        move()
#========== Programme principal =============
# les variables suivantes seront utilisées de manière globale :
coul="green"
x1, y1 = 10, 10 # coordonnées initiales
dx, dy = 15, 0 # 'pas' du déplacement
flag =0 # commutateur
# Création du widget principal ("parent") :
fen1 = Tk()
fen1.title("Exercice d'animation avec tkinter")
# création des widgets "enfants" :
can1 = Canvas(fen1,bg='dark grey',height=250, width=250)
can1.pack(side=LEFT, padx =5, pady =5)
oval1 = can1.create_oval(x1, y1, x1+30, y1+30, width=2, fill='green')
bou1 = Button(fen1,text='Quitter', width =8, command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1, text='Démarrer', width =8, command=start_it)
bou2.pack()
bou3 = Button(fen1, text='Arrêter', width =8, command=stop_it)
bou3.pack()
# démarrage du réceptionnaire d'événements (boucle principale) :
fen1.mainloop()
fen1.destroy()

# ------------- Exercice 8.24 ------------- #
# Modifiez le programme de telle façon que la balle effectue des mouvements obliques
# comme une bille de billard qui rebondit sur les bandes (« en zig-zag »).

from tkinter import *
# définition des gestionnaires
# d'événements :

def move():
    "déplacement de la balle"
    global x1, y1, dx, dy, flag, coul
    x1, y1 = x1+dx, y1+dy
    if x1>=260 and y1 <=0:
        x1,y1, dx, dy ,coul= 260,0, 10, 10, "blue"
    if y1 >=240 and x1>=500:
        x1,y1, dx, dy ,coul= 500,240, -10, 10, "red"
    if x1 <=260 and y1>=480:
        x1,y1, dx, dy ,coul= 260,480, -10, -10, "yellow"
    if x1<=20 and y1<=240:
        x1,y1, dx, dy ,coul= 20,240, 10, -10, "green"
    can1.coords(oval1,x1,y1,x1-20,y1+20)
    can1.itemconfigure(oval1,fill=coul)
    if flag >0:
        fen1.after(50,move) # => boucler, après 50 millisecondes

def stop_it():
    "arrêt de l'animation"
    global flag
    flag =0
def start_it():
    "démarrage de l'animation"
    global flag
    if flag ==0: # pour ne lancer qu’une seule boucle
        flag =1
        move()

#========== Programme principal =============
# les variables suivantes seront utilisées de manière globale :
coul="green"
x1, y1 = 20, 240 # coordonnées initiales
dx, dy = 10, -10 # 'pas' du déplacement
flag =0 # commutateur
# Création du widget principal ("parent") :
fen1 = Tk()
fen1.title("Exercice d'animation avec tkinter")
# création des widgets "enfants" :
can1 = Canvas(fen1,bg='dark grey',height=500, width=500)
can1.pack(side=LEFT, padx =5, pady =5)
coor1=can1.create_oval(20,240,0,260,fill="green")
coor2=can1.create_oval(260,0,240,20,fill="blue")
coor3=can1.create_oval(500,240,480,260,fill="red")
coor4=can1.create_oval(260,480,240,500,fill="yellow")
oval1 = can1.create_oval(x1, y1, x1-20, y1+20, width=2, fill='green')
bou1 = Button(fen1,text='Quitter', width =8, command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1, text='Démarrer', width =8, command=start_it)
bou2.pack()
bou3 = Button(fen1, text='Arrêter', width =8, command=stop_it)
bou3.pack()
# démarrage du réceptionnaire d'événements (boucle principale) :
fen1.mainloop()
fen1.destroy()

# ------------- Exercice 8.26 ------------- #
# Modifiez le programme de manière à obtenir d’autres mouvements.
# Tâchez par exemple d’obtenir un mouvement circulaire (comme dans les exercices de la page 107).

from tkinter import *
from math import *
# définition des gestionnaires
# d'événements :

def move():
    global angle,x1,y1
    angle=angle+0.1
    x2,y2=x1,y1
    x1,y1=sin(angle),cos(angle)
    x1,y1=int(250+x1*rayonT),int(250+y1*rayonT)
    can1.coords(oval1,x1+rayon,y1-rayon,x1-rayon,y1+rayon)
    if flag >0:
        fen1.after(50,move) # => boucler, après 50 millisecondes
def stop_it():
    "arrêt de l'animation"
    global flag
    flag =0
def start_it():
    "démarrage de l'animation"
    global flag
    if flag ==0: # pour ne lancer qu’une seule boucle
        flag =1
        move()

#========== Programme principal =============
# les variables suivantes seront utilisées de manière globale :
coul="green"
rayon,rayonT=20,230
angle,x1,y1=0.0,250.0+sin(0)*160.0,250+cos(0)*160.0
dx, dy = 10, -10 # 'pas' du déplacement
flag =0 # commutateur
# Création du widget principal ("parent") :
fen1 = Tk()
fen1.title("Exercice d'animation avec tkinter")
# création des widgets "enfants" :
can1 = Canvas(fen1,bg='dark grey',height=500, width=500)
can1.pack(side=LEFT, padx =5, pady =5)
oval1 = can1.create_oval(rayonT+rayon,rayonT*2,rayonT-rayon,rayonT*2+rayon*2,fill="red")
bou1 = Button(fen1,text='Quitter', width =8, command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1, text='Démarrer', width =8, command=start_it)
bou2.pack()
bou3 = Button(fen1, text='Arrêter', width =8, command=stop_it)
bou3.pack()
# démarrage du réceptionnaire d'événements (boucle principale) :
fen1.mainloop()
fen1.destroy()

# ------------- Exercice 8.27 ------------- #
# Modifiez ce programme, ou bien écrivez-en un autre similaire,
# de manière à simuler le mouvement d’une balle qui tombe (sous l’effet de la pesanteur), et rebondit sur le sol.
# Attention : il s’agit cette fois de mouvements accélérés !

from tkinter import *
from math import *
x, y, v, dx, dv ,flag, red= 25, 25, 0, 5, 5, 0, 0
def move():
    global x,y,v,dx,dv,flag,red
    if 0>x or x>475:
        dx=-dx
        x+dx
    x=x+dx
    v=v+dv
    y=y+v
    if (400)<y:
        y=400
        v=-v/1.01
    can.coords(boule,x+25,y,x,y+25)
    if y==400:
        red+=1
    else:
        red=0
    if dx-red==0 or dx+red ==0:
        y,red= 25,0
        flag=0
    if flag>0:
        fen.after(50,move)  
def start():
    global flag
    flag+=1
    if flag==1:
        move()
def stop():
    global flag
    if flag ==1:
        flag =0
fen=Tk()
can=Canvas(fen,width=500,height=500,bg="white")
can.grid(row=9,column=10)
Button(fen,text="Start",command=start).grid(row=10,column=10,sticky=W)
Button(fen,text="Stop",command=stop).grid(row=10,column=10)
Button(fen,text="Quitter",command=fen.quit).grid(row=10,column=10,sticky=E)
boule=can.create_oval(x+25,y,x,y+25,fill="red")
can.create_rectangle(500,425,0,500,width=3,outline="gray",fill="gray")
can.create_line(0,425,500,425,width=3,fill="black")
fen.mainloop()
fen.destroy()

# ------------- Exercice 8.28 ------------- #
# À partir des scripts précédents, vous pouvez à présent écrire un programme de jeu fonctionnant de la manière suivante :
# une balle se déplace au hasard sur un canevas, à vitesse faible.
# Le joueur doit essayer de cliquer sur cette balle à l’aide de la souris.
# S’il y arrive, il gagne un point, mais la balle se déplace désormais un peu plus vite, et ainsi de suite.
# Arrêter le jeu après un certain nombre de clics et afficher le score atteint.

from tkinter import *
from math import *
from random import randrange

# Fonction de déplacement
def move():
    #----Importation des variables----#
    global x,y,vx,vy,liste,d,t,cx,cy,point,dv,flag,coul,tr,tb
    #---------------------------------#
    
    #-----déplacement de la boule-----#
    can.coords(boule,(x+d)+vx,(y-d)+vy,(x-d)+vx,(y+d)+vy)
    #---------------------------------#

    #-----changement de position------#
    x,y=x+vx,y+vy
    #---------------------------------#
    
    if flag==1:
    #--Rebond sur les bord du Canvas--#
        if 0+d>x:
            vx=1*dv
        if x>500-d:
            vx=-1*dv
        if 0+d>y:
            vy=1*dv
        if y>500-d:
            vy=-1*dv
    #---------------------------------#
            
    #-----Changement de direction-----#
        if t%tr!=0:
            t+=1
        else:
            t=1
            vx=liste[randrange(3)]*dv
            vy=liste[randrange(3)]*dv
    #---------------------------------#

    #------Changement de couleur------#
        if  tb==10:
            coul="red"
            can.itemconfig(boule,fill=coul)
        else:
            tb+=1
    #---------------------------------#

    #------Changement de vitesse------#
        if vx ==0 and vy==0:
            vx=liste[randrange(3)]*dv
            vy=liste[randrange(3)]*dv
        else:
            pass
    #---------------------------------#

    #--------position du click--------#
        if x-d<cx<x+d and y-d<cy<y+d and coul=="red":
            dv=dv*1.2
            point+=1
            cx,cy=-1,-1
            tb=0
            coul="blue"
            can.itemconfig(boule,fill=coul)
        fen.after(50,move)
    #---------------------------------#

# Fonction de récupération du click      
def click(event):
#----Importation des variables----#
    global cx,cy,flag,dv
#---------------------------------#
    
#----récuperation des positions---#

#----Récuperation des positions---#
    if flag!=1:
        cx,cy=event.x,event.y
#---------------------------------#

#------Démarage de la boule-------#
        dv=1
        flag=1
        
#----Apelle de la fonction move---#
        move()
#---------------------------------#
        
#----Récuperation des positions---#
    else:
        cx,cy=event.x,event.y
#---------------------------------#
        
# Fonction d'arret de la boule
def stop():
#----Importation des variables----#
    global x,y,vx,vy,liste,d,t,cx,cy,point,dv,flag
#---------------------------------#

#--Réinitialisation des variables-#
    if flag==1:
        d,t,dv,vx,vy,liste=25,199,0,1,1,[1,-1,0]
#---------------------------------#

#--------Arret de la boule--------#
        flag=0
#---------------------------------#

#----Déclarations des variables---#
x,y,d,t,dv,vx,vy,liste,tr,tb=250,250,25,1,1,1,1,[1,-1,0],20,1    
cx,cy=-1,-1
point,flag,coul=0,0,"red"
#---------------------------------#

#-------Interface graphique-------#
fen=Tk()
can=Canvas(fen,width=500,height=500,bg="white")
can.grid(row=10,column=10)
can.bind("<Button-1>",click)
Button(fen,text="Quitter",command=fen.quit).grid(row=9,column=10,sticky=W)
Button(fen,text="Stop",command=stop).grid(row=9,column=10)
#---------------------------------#

#-------Création de la boule------#
boule=can.create_oval(x+d,y-d,x-d,y+d,fill=coul)
#---------------------------------#

#----Démarage de l'observateur----#
fen.mainloop()
#---------------------------------#

#----Déstruction de la fenetre----#
fen.destroy()
#---------------------------------#

# ------------- Exercice 8.29 ------------- #
# Variante du jeu précédent : chaque fois que le joueur parvient à « l’attraper », la balle
# devient plus petite (elle peut également changer de couleur).

from tkinter import *
from math import *
from random import randrange

# Fonction de déplacement
def move():
    #----Importation des variables----#
    global x,y,vx,vy,liste,d,t,cx,cy,point,dv,flag,coul,tr,tb
    #---------------------------------#
    
    #-----déplacement de la boule-----#
    can.coords(boule,(x+d)+vx,(y-d)+vy,(x-d)+vx,(y+d)+vy)
    #---------------------------------#

    #-----changement de position------#
    x,y=x+vx,y+vy
    #---------------------------------#
    
    if flag==1:
    #--Rebond sur les bord du Canvas--#
        if 0+d>x:
            vx=1*dv
        if x>500-d:
            vx=-1*dv
        if 0+d>y:
            vy=1*dv
        if y>500-d:
            vy=-1*dv
    #---------------------------------#
            
    #-----Changement de direction-----#
        if t%tr!=0:
            t+=1
        else:
            t=1
            vx=liste[randrange(3)]*dv
            vy=liste[randrange(3)]*dv
    #---------------------------------#

    #-Changement de direction si boule statique-#
        if vx ==0 and vy==0:
            vx=liste[randrange(3)]*dv
            vy=liste[randrange(3)]*dv
        else:
            pass

    #------Changement de couleur------#
        if  tb==10:
            coul="red"
            can.itemconfig(boule,fill=coul)
        else:
            tb+=1
    #---------------------------------#


    #---------------------------------#

    #--------position du click--------#
        if x-d<cx<x+d and y-d<cy<y+d and coul=="red":
            dv=dv*1.2
    #-----changement de position------#
            d=d-1
    #---------------------------------#
            point+=1
            cx,cy=-1,-1
            tb=0
            coul="blue"
            can.itemconfig(boule,fill=coul)
        fen.after(50,move)
    #---------------------------------#
        if d==0:
            flag=0
            d=25
        cx,cy=-1,-1
# Fonction de récupération du click      
def click(event):
#----Importation des variables----#
    global cx,cy,flag,dv
#---------------------------------#
    
#----récuperation des positions---#

#----Récuperation des positions---#
    if flag!=1:
        cx,cy=event.x,event.y
#---------------------------------#

#------Démarage de la boule-------#
        dv=1
        flag=1
        
#----Apelle de la fonction move---#
        move()
#---------------------------------#
        
#----Récuperation des positions---#
    else:
        cx,cy=event.x,event.y
#---------------------------------#
        
# Fonction d'arret de la boule
def stop():
#----Importation des variables----#
    global x,y,vx,vy,liste,d,t,cx,cy,point,dv,flag
#---------------------------------#

#--Réinitialisation des variables-#
    if flag==1:
        d,t,dv,vx,vy,liste=25,199,0,1,1,[1,-1,0]
#---------------------------------#

#--------Arret de la boule--------#
        flag=0
#---------------------------------#

#----Déclarations des variables---#
x,y,d,t,dv,vx,vy,liste,tr,tb=250,250,25,1,1,1,1,[1,-1,0],20,1    
cx,cy=-1,-1
point,flag,coul=0,0,"red"
#---------------------------------#

#-------Interface graphique-------#
fen=Tk()
can=Canvas(fen,width=500,height=500,bg="white")
can.grid(row=10,column=10)
can.bind("<Button-1>",click)
Button(fen,text="Quitter",command=fen.quit).grid(row=9,column=10,sticky=W)
Button(fen,text="Stop",command=stop).grid(row=9,column=10)
#---------------------------------#

#-------Création de la boule------#
boule=can.create_oval(x+d,y-d,x-d,y+d,fill=coul)
#---------------------------------#

#----Démarage de l'observateur----#
fen.mainloop()
#---------------------------------#

#----Déstruction de la fenetre----#
fen.destroy()
#---------------------------------#
"""
# ------------- Exercice 8.29 ------------- #
# Écrivez un programme dans lequel évoluent plusieurs balles de couleurs différentes,
# qui rebondissent les unes sur les autres ainsi que sur les parois.

from tkinter import *
from math import *
from random import randrange

"""def move():
    global listeB,listeD,v,d,dist,flag,listeV,t
    listeBt=[]
    if t==0:
        t=25
        m,n=0,0
        listeVt=[]
        for vit in listeV:
            m,n=0,0
            while m==0 and n==0:
                m,n=listeD[randrange(3)],listeD[randrange(3)]
            listeVt.append((m,n))
        listeV=listeVt
        del listeVt
        
    for boule in listeB:
        a=boule[0]-1
        vx,vy=listeV[a][0],listeV[a][1]
        can.coords(boule[0],(boule[1]+d)+(vx*dist),(boule[2]-d)+(vy*dist),(boule[1]-d)+(vx*dist),(boule[2]+d)+(vy*dist))
        listeBt.append((boule[0],(boule[1]+(vx*dist)),(boule[2]+(vy*dist))))
    t-=1
    listeB=listeBt
    del listeBt
    fen.after(50,move)

def add_boule():
    global d,listeB,n,listeD
    n=n+1
    x,y=randrange(d,500-d),randrange(d,500-d)
    can.create_oval(x+d,y-d,x-d,y+d)
    listeV.append((listeD[randrange(3)],listeD[randrange(3)]))
    listeB.append((n,x,y))"""
def move():
    global listeB,listeD,v,d,dist,flag,listeV
    listeBt=[]       
    for boule in listeB:
        a=boule[0]-1
        vx,vy=listeV[a][0],listeV[a][1]
        can.coords(boule[0],(boule[1]+d)+(vx*dist),(boule[2]-d)+(vy*dist),(boule[1]-d)+(vx*dist),(boule[2]+d)+(vy*dist))
        listeBt.append((boule[0],(boule[1]+(vx*dist)),(boule[2]+(vy*dist))))
        a+=1
    listeB=listeBt
    del listeBt
    fen.after(50,move)

def add_boule():
    global d,listeB,m,n,listeD,t,coul
    t=t+1
    x,y=randrange(d,500-d),randrange(d,500-d)
    can.create_oval(x+d,y-d,x-d,y+d,fill=coul[randrange(10)])
    while True:
        m,n=listeD[randrange(3)],listeD[randrange(3)]
        if m==0 and n==0:
            m,n=listeD[randrange(3)],listeD[randrange(3)]
        else:
            listeV.append((m,n))
            break
    listeB.append((t,x,y))
def start():
    p=7
def stop():
    p=7

coul=["blue","red","cyan","gray","black","green","pink","yellow","orange","purple"]
m,n=randrange(3),randrange(3)
listeV=[(m,n)]
listeD,v,listeB,d,dist=[-1,1,0],1,[(1,50,50)],25,1
flag,t=1,1
fen=Tk()
can=Canvas(fen,width=500,height=500,bg="white")
can.grid(row=10,column=10)

Button(fen,text="quitter",bg="red",command=fen.quit).grid(row=9,column=10,sticky=E)
Button(fen,text="Start",command=move).grid(row=9,column=10,sticky=W)
Button(fen,text="Stop",command=stop).grid(row=9,column=10,sticky=W,padx=50)
Button(fen,text="Ajouter balle",command=add_boule).grid(row=9,column=10,sticky=W,padx=100)
can.create_oval(listeB[0][1]+d,listeB[0][1]-d,listeB[0][1]-d,listeB[0][1]+d,fill="red")

fen.mainloop()

