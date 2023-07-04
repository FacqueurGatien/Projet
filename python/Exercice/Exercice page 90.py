#Programme proposé par l'exercice

# Petit exercice utilisant la bibliothèque graphique tkinter
from tkinter import *
from random import randrange

# --- définition des fonctions gestionnaires d'événements : --
def drawline():
    "Tracé d'une ligne dans le canevas can1"
    global x1, y1, x2, y2, coul
    can1.create_line(x1,y1,x2,y2,width=2,fill=coul)
    # modification des coordonnées pour la ligne suivante :
    y2, y1 = y2+10, y1-10
def changecolor():
    "Changement aléatoire de la couleur du tracé"
    global coul
    pal=['purple','cyan','maroon','green','red','blue','orange','yellow']
    c = randrange(8)         # => génère un nombre aléatoire de 0 à 7
    coul = pal[c]
#------ Programme principal ------
# les variables suivantes seront utilisées de manière globale :
x1, y1, x2, y2 = 10, 190, 190, 10    # coordonnées de la ligne
coul = 'dark green'                  # couleur de la ligne
# Création du widget principal ("maître") :
fen1 = Tk()
# création des widgets "esclaves" :
can1 = Canvas(fen1,bg='dark grey',height=200,width=200) 
can1.pack(side=LEFT)
bou1 = Button(fen1,text='Quitter',command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1,text='Tracer une ligne',command=drawline)
bou2.pack()
bou3 = Button(fen1,text='Autre couleur',command=changecolor)
bou3.pack()
fen1.mainloop() # démarrage du réceptionnaire d’événements
fen1.destroy() # destruction (fermeture) de la fenêtre 

#########################################################################
# Exercice 8.1
# Modifier le programme pour ne plus avoir que des lignes de couleur Cyan, maroon et green

from tkinter import *
from random import randrange

def drawline():
    "Tracé d'une ligne dans le canevas can1"
    global x1, y1, x2, y2, coul
    can1.create_line(x1,y1,x2,y2,width=2,fill=coul)
    y2, y1 = y2+10, y1-10
    
def changecolor():
    "Changement aléatoire de la couleur du tracé"
    global coul
    #Il faut changer la liste des couleures ici.
    pal=['purple','cyan','maroon','green','red','blue','orange','yellow']
    # Ou simplement changer la selection aléatoire du nombre.
    c = randrange(1,4)  
    coul = pal[c]

x1, y1, x2, y2 = 10, 190, 190, 10    
coul = 'dark green'            

fen1 = Tk()

can1 = Canvas(fen1,bg='dark grey',height=200,width=200) 
can1.pack(side=LEFT)
bou1 = Button(fen1,text='Quitter',command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1,text='Tracer une ligne',command=drawline)
bou2.pack()
bou3 = Button(fen1,text='Autre couleur',command=changecolor)
bou3.pack()
fen1.mainloop()
fen1.destroy() 

#########################################################################
# Exercice 8.2
# Modifier le programme pour que toute les lignes soit horizontale et parallelle

from tkinter import *
from random import randrange

def drawline():
    "Tracé d'une ligne dans le canevas can1"
    global x1, y1, x2, y2, coul
    can1.create_line(x1,y1,x2,y2,width=2,fill=coul)
    #Modifier l'incrementation des variable de position
    y2, y1 = y2+10, y1+10
    
def changecolor():
    "Changement aléatoire de la couleur du tracé"
    global coul
    pal=['purple','cyan','maroon','green','red','blue','orange','yellow']
    c = randrange(8)  
    coul = pal[c]
#Modifier les valeur de base de nos variable de position
x1, y1, x2, y2 = 10, 10,190, 10    
coul = 'dark green'            

fen1 = Tk()

can1 = Canvas(fen1,bg='dark grey',height=200,width=200) 
can1.pack(side=LEFT)
bou1 = Button(fen1,text='Quitter',command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1,text='Tracer une ligne',command=drawline)
bou2.pack()
bou3 = Button(fen1,text='Autre couleur',command=changecolor)
bou3.pack()
fen1.mainloop()
fen1.destroy() 

#########################################################################
# Exercice 8.3
# Agradir le canvas de maniere a lui donner une largeur de 500 unité de haut et 650 de large
# modifier également la taille des ligne pour qu'elles se confondent avec les bord

from tkinter import *
from random import randrange

def drawline():
    "Tracé d'une ligne dans le canevas can1"
    global x1, y1, x2, y2, coul
    can1.create_line(x1,y1,x2,y2,width=2,fill=coul)
    y2, y1 = y2+10, y1-10
    
def changecolor():
    "Changement aléatoire de la couleur du tracé"
    global coul
    pal=['purple','cyan','maroon','green','red','blue','orange','yellow']
    c = randrange(8)  
    coul = pal[c]
#Modifier les valeur de base de nos variable de position
x1, y1, x2, y2 = 0, 500,650, 0    
coul = 'dark green'            

fen1 = Tk()
#Modifier la résolution du Canvas a height=500,width=650:
can1 = Canvas(fen1,bg='dark grey',height=500,width=650) 
can1.pack(side=LEFT)
bou1 = Button(fen1,text='Quitter',command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1,text='Tracer une ligne',command=drawline)
bou2.pack()
bou3 = Button(fen1,text='Autre couleur',command=changecolor)
bou3.pack()
fen1.mainloop()
fen1.destroy() 

#########################################################################
# Exercice 8.4
# Ajouter une fonction drawline2 qui tyracera 2 lignes rouge en croix au centre du canvas
# l'une horizontale l'autre verticale puis ajouter un bouton nommé viseur
# Un click sur ce bouton afichera la croix


from tkinter import *
from random import randrange

def drawline():
    "Tracé d'une ligne dans le canevas can1"
    global x1, y1, x2, y2, coul
    can1.create_line(x1,y1,x2,y2,width=2,fill=coul)
    y2, y1 = y2+10, y1-10

def drawline2():
    "Tracé du viseur"
    #Déclaration dans la fonction des variable a,b corespondant a la résolution du canvas
    global a,b
    #Ajout de la ligne Horizontale
    x1,y1,x2,y2,coul=0,a/2,b,a/2,"red"
    can1.create_line(x1,y1,x2,y2,width=2,fill=coul)
    #Ajout de la ligne verticale
    x1,y1,x2,y2=b/2,0,b/2,a
    can1.create_line(x1,y1,x2,y2,width=2,fill=coul)
    
def changecolor():
    "Changement aléatoire de la couleur du tracé"
    global coul
    pal=['purple','cyan','maroon','green','red','blue','orange','yellow']
    c = randrange(8)  
    coul = pal[c]
#Modifier les valeur de base de nos variable de position
x1, y1, x2, y2 = 10, 190,190, 10    
coul = 'dark green'            

fen1 = Tk()
a,b=200,200 #Variable pour la résolution du Canvas
can1 = Canvas(fen1,bg='dark grey',height=a,width=b) 
can1.pack(side=LEFT)
bou1 = Button(fen1,text='Quitter',command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1,text='Tracer une ligne',command=drawline)
bou2.pack()
bou3 = Button(fen1,text='Autre couleur',command=changecolor)
bou3.pack()
bou4 = Button(fen1,text='Viseur',command=drawline2)
bou4.pack()
#Ajout d'un bouton Viseur

fen1.mainloop()
fen1.destroy() 


#########################################################################
# Exercice 8.5
# Faire des teste avec les fonction create_arc, create_rectangle, create_ocal, etc 

#########################################################################
# Exercice 8.6
# 1)Supprimez la ligne global x1, y1, x2, y2 dans la fonction drawline du
# programme original. Que se passe-t-il ? Pourquoi ?
"La fonction ne dispose plus des variable lui permettant de tirer le trait"
# 2) Si vous placez plutôt « x1, y1, x2, y2 » entre les parenthèses, dans la
# ligne de définition de la fonction drawline, de manière à transmettre ces
# variables à la fonction en tant que paramètres, le programme fonctionne-t-il
# encore ? N’oubliez pas de modifier aussi la ligne du programme qui fait
# appel à cette fonction !
"Le programme tracera une ligne a ces coordoné, et ne fera plus rien"
# 3) Si vous définissez x1, y1, x2, y2 = 10, 390, 390, 10 à la place de
# global x1, y1, ..., que se passe-t-il ?
# Pourquoi ?
# Quelle conclusion pouvez-vous tirer de tout cela ?


from tkinter import *
from random import randrange

def drawline():
    "Tracé d'une ligne dans le canevas can1"
    global x1, y1, x2, y2, coul
    can1.create_line(x1,y1,x2,y2,width=2,fill=coul)
    y2, y1 = y2+10, y1-10
    
def changecolor():
    "Changement aléatoire de la couleur du tracé"
    global coul
    pal=['purple','cyan','maroon','green','red','blue','orange','yellow']
    c = randrange(8)  
    coul = pal[c]
x1, y1, x2, y2 = 10, 190,190, 10    
coul = 'dark green'            

fen1 = Tk()
can1 = Canvas(fen1,bg='dark grey',height=200,width=200) 
can1.pack(side=LEFT)
bou1 = Button(fen1,text='Quitter',command=fen1.quit)
bou1.pack(side=BOTTOM)
bou2 = Button(fen1,text='Tracer une ligne',command=drawline)
bou2.pack()
bou3 = Button(fen1,text='Autre couleur',command=changecolor)
bou3.pack()
fen1.mainloop()
fen1.destroy() 

#########################################################################
# Exercice 8.7
# Faite un script qui affichera les anneaux des jeux olympique
from tkinter import *

def drawoval ():
    i=0
    while i<5:
        global x1,y1,x2,y2,couleur
        canvas.create_oval(x1,y1,x2,y2,width=2,outline=couleur[i])
        if i%2:
            x1,y1,x2,y2=x1+15,y1-25,x2+15,y2-25
            i+=1
        else:
            x1,y1,x2,y2=x1+15,y1+25,x2+15,y2+25
            i+=1
    x1,y1,x2,y2=20,60,60,20

x1,y1,x2,y2=20,60,60,20
couleur=["blue","yellow","black","green","red"]
fenetre=Tk()
canvas=Canvas(fenetre,bg="dark grey", height=200,width=600)
canvas.pack(side=LEFT)
bouton1=Button(fenetre,text="Quitter",command=fenetre.quit)
bouton1.pack(side=BOTTOM)
bouton2=Button(fenetre,text="Anneaux jeux olympique",command=drawoval)
bouton2.pack()
fenetre.mainloop()
fenetre.destroy()


#########################################################################
# Exercice 8.8
# Meme exercice mais faire un boutton pour chaque anneaux
from tkinter import *
def color(a):
    if a==20:
        color="blue"
    if a==35:
        color="yellow"
    if a==50:
        color="black"
    if a==65:
        color="green"
    if a==80:
        color="red"
    return color
def drawoval1(a):
    global x3,y3,x4,y4,couleur
    coul=color(a)
    if a%2:
        b,c=45,85
    else:
        b,c=20,60
    canvas.create_oval(x3*a,y3*b,x4*a+40,y4*c,width=2,outline=coul)


x3,y3,x4,y4=1,1,1,1
fenetre=Tk()
canvas=Canvas(fenetre,bg="dark grey", height=200,width=600)
canvas.pack(side=LEFT)
bouton1=Button(fenetre,text="Quitter",command=fenetre.quit)
bouton1.pack(side=BOTTOM)
bouton2=Button(fenetre,text="Anneaux jeux olympique",command=drawoval)
bouton2.pack()
bouton3=Button(fenetre,text="Anneau 1",command=lambda a=20:drawoval1(a))
bouton3.pack()
bouton4=Button(fenetre,text="Anneau 2",command=lambda a=35:drawoval1(a))
bouton4.pack()
bouton5=Button(fenetre,text="Anneau 3",command=lambda a=50:drawoval1(a))
bouton5.pack()
bouton6=Button(fenetre,text="Anneau 4",command=lambda a=65:drawoval1(a))
bouton6.pack()
bouton7=Button(fenetre,text="Anneau 5",command=lambda a=80:drawoval1(a))
bouton7.pack()
fenetre.mainloop()
fenetre.destroy()

