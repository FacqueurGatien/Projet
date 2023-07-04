from math import *
#Exercice 7.14
#Faire une fonction volBoite(x1,x2,x3)  de maniere a ce qu'elle puisse etre appeler avec
#3, 2 ou 1 ou meme 0 argument
#Utiliser comme valeur par deffaut 10

def volBoite(x1=10,x2=10,x3=10):
    vol=x1*x2*x3
    return vol

def valeurValide(x,nom):
    while True:
        if x=="":
            x=10
            break
        else:
            try:
                float(x)
                break
            except ValueError:
                print("Ce n'est pas une valeur valide")
                print ("Entrez la valeur de la",nom,end="")
                x=input("x=: ")
    return x

#vol=volBoite(x1=valeurValide(input("Entrez une Longueur: "),"Longueur"),x2=valeurValide(input("Entrez une Hauteur: "),"Hateur"),x3=valeurValide(input("Entrez une Profondeur: "),"Profondeur"))

#Exercice 7.15
#Faire une fonction volBoite(x1,x2,x3) de maniere a ce qu'elle puisse etre appeler avec 1 2 ou 3 argument
#si elle est appeller avec 2 argument elle est considerer comme un prisme et si elle est utilisé avec 1 argument elle est considerer comme cubique
def valeurValide3(x):
    while True:
        if x=="":
            break
        else:
            try:
                int(x)
                break
            except ValueError:
                x=input("Ce n'est pas une valeur valide: ")
    return x
def volBoite2(x1="",x2="",x3=""):
    liste,a=[],-1
    if x1 !="":
        liste.append(float(x1))
    if x2 !="":
        liste.append(float(x2))
    if x3 !="":
        liste.append(float(x3))
    if len(liste)==0:
        print(a)
    elif len(liste)==1:
        print("La valeur cubique est de: ",liste[0]**3)
    elif len(liste)==2:
        print("La valeur prismique est de: ",liste[0]**2*liste[1])
    else:
        print("La valeur du paraléllépipède est de: ",liste[0]*liste[1]*liste[2])
    return 
#vol=volBoite2(x1=valeurValide3(input("Entrez une valeur: ")),x2=valeurValide3(input("Entrez une autre valeur: ")),x3=valeurValide3(input("Entrez une derniere valeur: ")))

#Exercice 7.16
#Definir une fonction changeCar(ch,ca1,ca2,debut,fin) qui remplace tous les
#caractere ca1 par des caractere ca2 dans la chaine de caractere ch a partir de l'indice debut jusqu'a l'indice fin
#si debut et fin ne sont pas précisé la chaine de caractere est traité entierement
def valeurValide2(x):
    while True:
        try:
            int(x)
            break
        except ValueError:
            x=input("Ce n'est pas une valeur valide: ")
    return int(x)
def validCh(ch):
    while True:
        if len(ch)<=0:
            ch=input("Entrez au moins 1 caractere")
        else:
            break
    return ch
def validCa(ca):
    while True:    
        if len(ca)==0 or len(ca)>1 or ca=="":
            ca=input("Entrer un et un seul caracter: ")
        else:
            break
    return ca
def changeCar(ch="rien",ca1="a",ca2="a",debut="",fin=""):
    if debut=="" or int(debut)<=0 or int(debut)>=int(fin):
        debut=0
    else:
        debut= int(debut)-1
    if fin=="" or int(fin)>=len(ch) or int(fin)<=int(debut):
        fin=len(ch)-1
    else:
        fin=int(fin)
    newch=""
    while debut!=fin:
        if ch[debut]!=ca1:
            newch+=ch[debut]
            debut+=1
        else:
            newch+=ca2
            debut+=1
    print(ch,ca1,ca2,debut,fin)
    if len(ch)==1 and ch[0]==ca1:
        newch+=ca2
    return newch
#a=changeCar(ch=validCh(input("Entrez une chaine de caractere: ")),ca1=validCa(input("Entrez le caractere a remplacer: ")),ca2=validCa(input("Entrez le caractere par le quelle le remplacer")),debut=valeurValide2(input("A partir d'ou: ")),fin=valeurValide2(input("Jusqu'a: ")))

#Exercice 7.17
#Definir une fonction elexMax(liste,debut,fin) qui renvoie l'element ayant la plus grande valeur dansla liste transmise
#Les 2 arguments début et fin indiqueront les indices entre lesquels doit s'exercer
#la recherche, et chacun d'eus pourras etre omis


