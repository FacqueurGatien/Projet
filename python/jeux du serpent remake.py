from tkinter import *
from math import *
from random import randrange

#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
####################################################################################################################################################################################################################################### 
#Fonction de récupération de la pression des touches directionnelle
def gauche(event):
    global dx,dy,flag,taille
    espace=taille*2                                                     #Définit l'avancé du serpent d'une case de meme longueur qu'un de ces morceau
    if flag==0:                                                         #Si Flag == 0, Flage devient 1 pour lancer le jeux.
        flag=1
        dx,dy=-espace,0                                                 #Les valeures de déplacement horizontale et verticale change selon la touche pressé
        bouger_serpent()                                                #la fonction bouger serpent est appelé
    if dx==-espace or dx==espace or flag==-1:                                       #Si la touche directonnele pressé est dans le meme alignement que le serpent rien ne change
        pass
    else:                                                               #Si flag est deja =1 et que la touche pré
        dx,dy=-espace,0                                                 #Les valeures de déplacement horizontale et verticale change selon la touche pressé
        flag=0                                                          #Arret de la fonction bouger_serpent pour éviter une accelération de la fonction
        bouger_serpent()                                                #Réappel de la fonction bouger_serpent
        flag=1                                                          #Réafectation de flag pour que le programe ne s'arrete pas
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
def droite(event):
    global dx,dy,flag,taille
    espace=taille*2
    if flag==0:
        flag=1
        dx,dy=espace,0
        bouger_serpent()
    if dx==-espace or dx==espace or flag==-1:
        pass
    else:
        dx,dy=espace,0
        flag=0
        bouger_serpent()
        flag=1
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
def haut(event):
    global dx,dy,flag,taille
    espace=taille*2
    if flag==0:
        flag=1
        dx,dy=0,-espace
        bouger_serpent()
    if dy==-espace or dy==espace or flag==-1:
        pass
    else:
        dx,dy=0,-espace
        flag=0
        bouger_serpent()
        flag=1
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
def bas(event):
    global dx,dy,flag,taille,num
    espace=taille*2
    if flag==0:
        flag=1
        dx,dy=0,espace
        bouger_serpent()
    if dy==-espace or dy==espace or flag==-1:
        pass
    else:
        dx,dy=0,espace
        flag=0
        bouger_serpent()
        flag=1
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
#######################################################################################################################################################################################################################################    
#Fonction ajoutant un carré a la queue du serpent______________________________________________________________________________________________________________________________________________________________________________________
def add_serpent():
	global liste_serpent,liste_add,vitesse,taille,num
	num+=1                                                          #Incrementation de la variable num pour ajouter le numero(nom) de controle du nouveau carrée
	if num%8==0 and vitesse>20:                                     #Si num est un chiffre paire et que la vitesse d'animation n'est pas inferieur a 20ms
		vitesse-=5                                              #On baisse la valeure de vitesse de 5 ms
	liste_serpent.append((num,liste_add[1],liste_add[2]))           #On ajoute a la liste (liste_serpent) les valeur du nouveau carré (num,position x, position y)
	canvas.create_rectangle(liste_add[1]+taille,liste_add[2]-taille,liste_add[1]-taille,liste_add[2]+taille,width=2,fill="green")       #création du nouveau carrée
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
#######################################################################################################################################################################################################################################  
#Fonction de déplacement du serpent et de gestion des colisions________________________________________________________________________________________________________________________________________________________________________
def bouger_serpent():
    global liste_serpent,taille,dx,dy,flag,vitesse,liste_add
    liste_temp=[]                                                       #Déclaration d'une liste temporaire
    xt,yt=liste_serpent[0][1],liste_serpent[0][2]                       #Récupération des valeurs x et y de la tête du serpent
    xt,yt=xt+dx,yt+dy                                                   #Ajout des valeur de déplacement du serpent
    canvas.coords(2,xt+taille,yt-taille,xt-taille,yt+taille)            #Déplacement de la tête du serpent
    liste_temp.append((2,xt,yt))                                        #Ajout de la nouvelle position de la tête du serpent dans la liste temporaire
    for n in liste_serpent:                                             #Pour chaque element de la liste_serpent
        xt,yt=n[1],n[2]                                                 #on récupere les valeur x et y 
        canvas.coords(n[0]+1,xt+taille,yt-taille,xt-taille,yt+taille)   #On déplace la partie n+1 du serpent vers la position précedente
        liste_temp.append((n[0]+1,xt,yt))                               #On ajoute la nouvelle position dans la liste_temp
    liste_add=liste_temp[-1]                                            #En sortant de la boucle On remplace la liste_add avec les valeurs de la liste_temp
    del	liste_temp[-1]                                                  #Supression de la derniere valeur de la liste_temp
    liste_serpent=liste_temp                                            #Remplacement des valeurs de la liste_serpent par les valeurs de la liste_temp
    x,y=liste_serpent[0][1],liste_serpent[0][2]                         #Récupération des valeurs x et y de la tête du serpent 
    if (x-taille)<0:                                                    #si le coin "superieur droit" de la tête du serpent entre en colision avec le bord du Canvas 
        flag=0
        saisi_pseudo()                                                  #La fonction end est appelé (fin du jeu)
    if (x+taille)>500:                                                  #Si le coin "superieur gauche" de la tête du serpent entre en colision avec le bord du Canvas 
        flag=0
        saisi_pseudo()                                                  #La fonction end est appelé (fin du jeu)
    if (y-taille)<0:                                                    #Si le coin "inferieur gauche" de la tête du serpent entre en colision avec le bord du Canvas 
        flag=0
        saisi_pseudo()                                                   #La fonction end est appelé (fin du jeu)
    if (y+taille)>500:                                                  #Si le coin "inferieur droit" de la tête du serpent entre en colision avec le bord du Canvas 
        flag=0
        saisi_pseudo()                                                  #La fonction end est appelé (fin du jeu))                                                   #La fonction end est appelé (fin du jeu)
    if len(canvas.find_overlapping(x+taille,y-taille,x+taille,y-taille))>1 and len(canvas.find_overlapping(x-taille,y-taille,x-taille,y-taille))>1 and\
       len(canvas.find_overlapping(x+taille,y+taille,x+taille,y+taille))>1 and len(canvas.find_overlapping(x-taille,y+taille,x-taille,y+taille))>1:
                                                                        #Si tout les coin de la tête du serpent entre en colision en meme temp, le programme considere que le serpent
                                                                        #c'est mordu la queue et le jeu d'arrete
        flag=0
        saisi_pseudo()
    xf,yf=fruit[0],fruit[1]                                             #Récupération des valeurs x et y du fruit
    if len(canvas.find_overlapping(xf+taille2,yf-taille2,xf-taille2,yf+taille2))>1:
                                                                        #Si le fruit entre en colision avec quoi que ce soit, le programme considere que le serpent a mangé le fruit et al fonction colision ets appelé
        colision()
    if flag>0:                                                          #Si flag est superieur a 0 la fonction se rapelle elle même avec un temp definit par la variable vitesse
        fenetre.after(vitesse,bouger_serpent)
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
#######################################################################################################################################################################################################################################          
#Fonction colision permetant de gerer les point et le replacement du fruit sur le Canvas_______________________________________________________________________________________________________________________________________________
def colision():
    global liste_serpent,point,fruit,taille2,flag,taille_canvas
                                                                        #Récupération de la position actuel du fruit
    xp,yp=fruit[0],fruit[1]
    if len(canvas.find_overlapping(xp+taille2,yp-taille2,xp-taille2,yp+taille2))>1: #Si le fruit est en colision
        while True:                                                     #Tant que la boucle n'est aps interompu
            coef=int((taille_canvas-20))/int(taille)                    #Création d'une variable qui servira a la génération d'un nombre aléatoire (le nombre est definit selon la taille du Canvas et la taille de la tête du serpent)
            xp,yp=randrange(10,coef-9)*taille,randrange(3,coef-2)*taille#Génération de 2 nombre aléatoire pour les nouvelles valeur x et y du fruit
            canvas.coords(1,xp+taille2,yp-taille2,xp-taille2,yp+taille2)#déplacement du fruit sur ces nouvelle valeures
            if len(canvas.find_overlapping(xp+taille2,yp-taille2,xp-taille2,yp+taille2))>1:
                                                                        #Si les nouvelle valeur du fruit sont toujours en colision alors la boucle ne s'interomp pas et de nouvelles valeurs seront généré
                pass
                                                                        #Sinon la boucle s'interomp
            else:
                break
        point+=1                                                        #Incrementation du Score d'un point
        add_serpent()                                                   #Appel de la fonction add_serpent
        fruit=(xp,yp)                                                   #La variable Fruit prend fonction de ses nouvelle valeur Valide
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
#######################################################################################################################################################################################################################################          
#Fonction de game over_________________________________________________________________________________________________________________________________________________________________________________________________________________
def end(game_tag):
    global liste_serpent,point,fruit,taille,flag,taille2,record,liste_add,num,canvas,liste_record,a
    a.destroy()
    liste_serpent,liste_add=[(2,250,250)],[]                            #Rafraichissement des valeur initiale au début d'une partie des liste_serpent et liste_add
    num,vitesse=2,100                                                   #Rafraichissement de la variable de controle des parties du serpent num et de la variable de vitesse de l'aniamtion vitesse
    if point>record:                                                    #Si le nombre de point est superieur au record enregistré
        record=point                                                    #La variable record prend la valeur de la variable point
        liste_record=game_tag
    texte=("Record:"+str(liste_record)+" "+str(record)+"pts_____point actuel:"+str(game_tag)+" "+str(point)+"pts")                        #Affichage du nombre de point et du record
    a=Label(fenetre,text=texte,bg="black",fg="green",font=("Times","12","bold"))
    a.grid(row=0,column=1,sticky=N)
    point=0                                                             #Remise a zero du score
    flag=0                                                              #Arret du jeu
    canvas.delete("all")                                                #Effacement du Canvas
    canvas=Canvas(fenetre,width=500,height=500,bg="gray")               #Création du Nouveau Canvas
    canvas.grid(row=1,column=1)
                                                                        #Recréation de la tête du serpent et du fruit
    canvas.create_rectangle(fruit[0]+taille2,fruit[1]-taille2,fruit[0]-taille2,fruit[1]+taille2,width=2,fill="red")
    canvas.create_rectangle(250+taille,250-taille,250-taille,250+taille,width=2,outline="black",fill="green")
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
#######################################################################################################################################################################################################################################
#Fonction de récupération du pseudo du joueur
def recup(event):
    global game_tag,can,saisie
    game_tag=saisie.get()                                               #Récupération de la valeur entré dans le champ de saisie avec la touche "Entré"
    end(game_tag)                                                       #Appel de la fonction end avec la variable game_tag
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
#######################################################################################################################################################################################################################################
#Fonction d'affichage du champ de saisie
def saisi_pseudo():
    global saisie,flag
    flag=-1
    saisie=StringVar()                                                  #Déclaration de la variable a récuperer dans le champ de saisie
    saisie.set("-Pseudo-")                                              #Le contenue par defaut du champ de saisie
                                                                        #Création des Label Game over et d'invitation a entrer un pseudo
    Label(fenetre,text="ENTREZ VOTRE PSEUDO",bg="gray",fg="green",font=('Times', '12', 'bold') ).grid(row=1,column=1,sticky=N,padx=140,pady=220)
    Label(fenetre,text="GAME OVER",bg="gray",fg="red",font=('Times', '16', 'bold') ).grid(row=1,column=1,sticky=N,padx=140,pady=190)
    entree=Entry(textvariable=saisie,width=20,justify=CENTER,fg="gray") #Création d'un champ de saisie
    entree.grid(row=1,column=1,padx=180,pady=180)                       #Affichage du champ de saisie
    entree.bind("<Return>",recup)                                       #Affectation de la touche Entré au champ de saisie qui appelera la fonction recup
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
#######################################################################################################################################################################################################################################    
#Déclaration des variable necessaire au jeu____________________________________________________________________________________________________________________________________________________________________________________________
x_teteS,y_teteS,taille,fruit,taille2=250,250,5,(100,100),2
liste_serpent,liste_add=[(2,x_teteS,y_teteS)],[]
dx,dy,flag=taille,taille,0
vitesse,num,point,record,liste_record=100,2,0,0,"EMPTY"
taille_canvas,saisie=500,""

#Création d'une fenetre tkinter________________________________________________________________________________________________________________________________________________________________________________________________________
fenetre=Tk()
fenetre.configure(bg="black")
canvas=Canvas(fenetre,width=taille_canvas,height=taille_canvas,bg="gray")#Création d'un Canvas
canvas.grid(row=1,column=1)
#Création de la tête du serpent et d'un fruit
canvas.create_rectangle(fruit[0]+taille2,fruit[1]-taille2,fruit[0]-taille2,fruit[1]+taille2,width=2,fill="red")
canvas.create_rectangle(x_teteS+taille,y_teteS-taille,x_teteS-taille,y_teteS+taille,width=2,fill="green")
texte=("Record:"+str(liste_record)+" "+str(record)+"pts      point actuel:"+str(liste_record)+" "+str(point)+"pts")
a=Label(fenetre,text=texte,bg="black",fg="green",font=("Times","12","bold"))
a.grid(row=0,column=1,sticky=N)
#Création d'un bouton "Quitter"
Button(fenetre,text="Quitter",bg="red",command=fenetre.quit).grid(row=0,column=1,sticky=E)
#Création de l'interaction de la fenetre tkinter avec les touche directionnelle
fenetre.bind("<Left>",gauche)
fenetre.bind("<Right>",droite)
fenetre.bind("<Up>",haut)
fenetre.bind("<Down>",bas)

fenetre.mainloop()                                                      #Lancement de l'observateur d'évenement
fenetre.destroy()                                                       #Déstruction de la fenetre tkinter
#______________________________________________________________________________________________________________________________________________________________________________________________________________________________________
####################################################################################################################################################################################################################################### 

