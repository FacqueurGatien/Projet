from math import *
from turtle import *

#Exercice 7.2
#Definir une fonction ligneCar(n,ca) qui renvoie une chaine de n caractere ca.
def ligneCar(n,ca):
    return n*ca
#ch=ligneCar(int(input("Combien de replication?: ")),input("quel terme repliquer?: "))

#Exercice 7.3
#Definir une fonction surfCercle(R), en renseignant le rayon (R) la fonction renvoie la surface du cercle.
#Rapelle de la formule de calcule de la surface d'un cercle: pi*R^2
def surfCercle(R):
    return R*R*pi
#surf=surfCercle(int(input("Quelle est le rayon du cercle?: ")))

#Exercice 7.4
#Definir une fonction volBoite(x1,x2,x3), en renseignant les 3 mesure d'un parallelepipede la fonction renvoie le volume.
#Rapelle de la formule de calcule du volume d'un parallelepipede: 
def volBoite(x1,x2,x3):
    return x1*x2*x3
#vol=volBoite(int(input("Entrez la hauteur du parallelepipede: ")),int(input("Entrez la longueur du parallelepipede: ")),int(input("Entrez la profondeur du parallelepipede: ")))

#Exercice 7.5
#Definir une fonction maximum(n1,n2,n3), en renseignant 3 nombre la fonction renvoie le plusgrand des 3
def maximum(n1,n2,n3):
    if n1>n2 and n1>n3:
        max=n1
    elif n2>n1 and n2>n3:
        max=n2
    else:
        max=n3
    return max
#maxi=maximum(int(input("Entrez un 1er nombre")),int(input("Entrez un 2eme nombre")),int(input("Entrez un 3eme nombre")))

#Exercice 7.6
#Avec le module turtle, faite le dessin suivant
#Un carre et un triangle equilaterale de meme mesure l'un a cote de l'autre (qui ne se touche pas)
#Puis repeter la figure plusieur fois avec a chaque iteration une taille plus grande (5,10,15,20,25...)
def carre(taille,couleur):
    i=0
    begin_fill()
    while i<4:
        color(couleur)
        forward(taille)
        left(90)
        i+=1
    end_fill()
def triangle(taille,couleur):
    i=0
    begin_fill()
    while i<3:
        color(couleur)
        forward(taille)
        left(120)
        i+=1
    end_fill()
def figure(taille,couleur1,couleur2,repete):
    a,i=-400,0
    while i!=repete:
        up()
        goto(a,0)
        down()
        carre(taille,couleur1)
        up()
        a+=taille+10
        goto(a,0)
        down()
        triangle(taille,couleur2)
        a+=taille+10
        taille+=taille/4
        i+=1

#figure(int(input("Quel est la taille des figures?: ")),input("Quel couleur pour le carré?: "),input("Quel couleur pour le triangle?: "),int(input("Combien d'iteration?: ")))

#Exercice 7.7
#Avec le module turtle, faite le dessin suivant
#Crée une etoile a 5 branches, et a chaque coté faire une etoile plus petite, qui aura a coté d'elle une etoile encore plus petite etc
def etoile5(taille,couleur):
    i=0
    color(couleur)
    begin_fill()
    while i!=5:
        forward(taille)
        left(144)
        i=i+1
    end_fill()
def etoileMiror(taille,couleur,replication):
    a,b,i,coef=0,0,0,taille/(replication+1)
    etoile5(taille,couleur)
    while i<replication:
        up()
        b+=taille+10
        taille-=coef
        a+=taille+10
        goto(b,0)
        down()
        etoile5(taille,couleur)
        up()
        goto(-a,0)
        down()
        etoile5(taille,couleur)
        i+=1
#etoileMiror(int(input("Quel taille fait l'etoile?: ")),input("De quel couleur est elle?: "),int(input("Combien de replication?: ")))

#Exercice 7.8
#
def doubletriangle(taille,couleur):
    i=0
    color(couleur)
    triangle(taille,couleur)
    up()
    forward(taille)
    left(90)
    forward(taille-taille/2.5)
    left(90)
    down()
    triangle(taille,couleur)
    up()
    forward(taille)
    left(90)
    forward(taille-taille/2.5)
    left(90)
    down()
def octofigure(taille,couleur1,couleur2,couleur3,couleur4,iteration):
    up()
    goto(-1000,-1000)
    down()
    c=0
    color("black")
    begin_fill()
    while c<4:
        forward(2000)
        left(90)
        c+=1
    up()
    goto(0,0)
    down()
    end_fill()
    """
    etoile5(t,"blue")
    up()
    forward(t+5)
    down()
    triangle(t,"pink")
    up()
    forward(t+5)
    down()
    doubletriangle(t,"black")
    up()
    forward(t+5)
    left(60)
    t+=1"""
    i,a=0,3
    while i!=iteration*6:
        down()
        carre(taille,couleur1)
        up()
        forward(taille+a)
        down()
        etoile5(taille,couleur2)
        up()
        forward(taille+a)
        down()
        triangle(taille,couleur3)
        up()
        forward(taille+a)
        down()
        doubletriangle(taille,couleur4)
        up()
        forward(taille+a)
        left(60)
        i+=1
        taille+=1
        a+=2
#octofigure(int(input("Quel taille de depart?: ")),input("Quel couleur pour le carre?: "),input("Quel couleur pour l'etoile?: "),input("Quel couleur pour le triangle?: "),input("Quel couleur pour le doubletriangle?: "),int(input("Combien d'iteration?: ")),)

#Exercice 7.9
#Definir une fonction qui compte le nombre de caractere (ca) dans une chaine de caractere (ch)
def compteCar(ca,ch):
    i,compte=0,0
    while i!=len(ch):
        if ch[i]==ca:
            compte+=1
            i+=1
        else:
            i+=1
    return compte,ca
#compte=compteCar(input("Quelle lettre voullez vous compter?: "),input("Quelle est votre phrase?: "))
#print("Il y a",compte[0],"fois la lettre",compte[1],"dans cette phrase")

#Exercice 7.10
#Definir une fonction qui renvoie l'index de l'element le plus grand de la liste
liste=["ok"]
def nombreValide(a):
    while True:
        try:
            float(a)
            break
        except ValueError:
            a="non"
            break
    return a
def creerListe ():
    liste=[]
    while True:
        a=input("Entrez une valeur")
        if a=="":
            break
        else:
            a=nombreValide(a)
        if a=="non":
            print("Ce n'est pas un nombre valide")
        else:
            liste.append(float(a))
    return liste
def indexMax ():
    i=1
    liste=creerListe()
    a=liste[0]
    a=a,liste.index(a)
    while i!=len(liste):
        if a[0]<liste[i]:
            a=liste[i]
            a=a,liste.index(a)
            i+=1
        else:
            i+=1
    print("L'éléments le plus grand de cette liste est:",a[0],", et il est situé a l'index:",a[1],"de la liste")
    return liste
#indexMax()

#Exercice 7.11
#Definir une fonction qui renvoie le nom du n ieme moi de l'année.
def nombreMinMax(x,y,z):
    while True:
        try:
            print("!!!Entrez un nombre entre:",x,"et",y,"!!!: ",end="")
            z=int(input())
            break
        except ValueError:
                print("BZZZZZZZZZ")
    return z
def nomMois(n):
    mois=["Janvier","Fevrier","Mars","Avril","Mai","Juin","Juillet","Aout","Septembre","Octobre","Novembre","Decembre"]
    x,y,z=1,12,0
    while True:
        try:
            n=int(n)
            break
        except ValueError:
            n=nombreMinMax(x,y,z)
    while True:
        if n<x or n>y:
            print("BZZZZZZZZZ")
            n=nombreMinMax(x,y,z)
        else:
            break
    print("Le",n,"e mois de l'année est:",mois[n-1])
    return mois[n-1]
#mois=nomMois(input("Vous souhaitez savoir l'appelation du quantiemme mois de l'année?:"))

#Exercice 7.12
#Definir une fonction qui inverse une chaine de caractere
def inverse(ch):
    i,hc=len(ch)-1,""
    while i!=-1:
        hc+=ch[i]
        i-=1
    print("Chaine de caractere\t\t:",ch,"\nChaine de caractere inversé\t:",hc)
    return hc
#hc=inverse(input("Entrez une chaine de caractere"))

#Exercice 7.13
#Definir une fonction compte mot qui renvoie le nombre de mot dans une phrase (on considere comme mot une chaine de caractere inclu entre des espace)
def stopFinMot(ph,i):
    valide="'aàâbcçdeéèêëfghiîïjklmnoôöpqrstuùûüvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    while True:
        if i+1==len(ph):
            break
        elif (ph[i] in valide)==True:
            i+=1
        else:
            break
    return i

def compteMot(ph):
    i,valide,nbmot=0,"'aàâbcçdeéèêëfghiîïjklmnoôöpqrstuùûüvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ",0
    if len(ph)==0:
        i=-1
    while i+1!=len(ph):
        if (ph[i] in valide)==True:
            i=stopFinMot(ph,i)
            nbmot+=1
        else:
            i+=1
    print("Il y a",nbmot,"mot(s) dans cette phrase")
    return nbmot
#nbmot=compteMot(input("Entrez une phrase"))
