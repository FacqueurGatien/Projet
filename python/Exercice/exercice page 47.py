#Exercice 5.11
#créer une nouvelle liste a l'aide des 2 autres en alterance: a b a b a b a b a b

#déclaration de la premiere liste
t1=["31","28","31","30","31","30","31","31","30","31","30","31"]
#déclaration de la seonde liste
t2=["janvier","fevrier","mars","avril","mai","juin","juillet","aout","septembre","octobre","novembre","decembre"]
#déclaration de la 3eme liste
t3=[]
#déclaration des variable de condition: a prend la valeur du nombre de composant de la liste
#b sert de compteur pour l'arret de la boucle
a,b=len(t1),0
#tant que b est different de a
while b!=a:
    #le programe ajoute a la liste t3, dabbord une composante de la liste t1 puis un espace puis une coposante de la liste t2
    t3.append(t1[b]+" "+t2[b])
    #b est incrementé de 1 pour passer a la composante suivante des 2 listes
    b+=1
#Affichage de la liste t3
print(t3)
#saut a la ligne x2
print("\n \n")

#Exercice 5.12
#Afficher proprement le termes de la listes 2 de l'exo precedent

a,b=len(t2),0
#tant que b est different de a
while b!=a:
    #Le programme affiche les termes de la liste t2 un a un en suivant la condition de la boucle, sep="" suprime les guillemet a l'affichage et end=" " remplace le st a la ligne par un espace
    print(t2[b],sep="",end=" ")
    #b est incrementé de 1
    b+=1
#saut a la ligne x2
print("\n \n")

#Exercice 5.13
#Chercher l'element le plus grand d'une liste

#déclaration des variables de condition f=recuperation du nombre le plus grand, g=condition d'arret de boucle
f,g=0,0
#Liste contenant les nombre a analyser
nb=[458,54,689,52,54,9,6,212,45,8,66,658,10]
#Tant que la valeure de g est different de la valeur du nombre de terme de la liste nb
while g!=len(nb):
    #si le terme contenue dans la variable f est inferieur au terme en cours de comparaison de la liste nb
    if f<nb[g]:
        #f prend pour nouvelle valeur le terme actuel de la liste nb
        f=nb[g]
        #g est incrementé de 1
        g+=1
    #sinon
    else:
        #g est incrementé de 1 mais les autres actions ne s'effectuent pas
        g+=1
#affichage d'un message + le terme le plus grand retenue par le scrpt+ supression ds guillemet d'affichage
print("l'élément le plus grand de cette liste est :",f,sep="")
#saut a la ligne x2
print("\n \n")

#Exercice 5.14
#trie des nombre paire et impaire

#déclaration de la variable de condition de boucle et de repere de position dans la liste
b=0
#delaration des liste en vu d'y placer les nombres paire et impaire
tp=[]
tip=[]
#tant que la valeure de la variable b est diferent de la valeur du nombre d'élément dans la liste nb la boucle continue
while b!=len(nb):
    #si le terme placé a la position egal a la valeur de la variable b dans la liste nb modulo 2 =0
    if nb[b]%2==0:
        #ajout du terme analysé precedement  dans la liste tp (correspondant a la liste paire)
        tp.append(nb[b])
        #b est incrementé de 1
        b+=1
    #sinon
    else:
        #ajout du terme analysé precedement  dans la liste tip (correspondant a la liste impaire)
        tip.append(nb[b])
        #b est incrementé de 1
        b+=1
#affichage des liste paire et impaire 
print("Liste paire",tp,"\nListe Impaire",tip,sep="")
#saut a la ligne x2
print("\n \n")


#Exercice 5.15
#separer une liste selon la longueur d'un mot

#déclaration d'une liste contenant des nom
liste=["Gatien","Laura","Emmanuel","Frederique","veronique","Marc","Sophie","Marie-line","Paul","Gin"]
#déclaration de 2 liste: listem= liste qui contiendra les nom de moins de 6 lettres, listep qui contiendra les autres
listem=[]
listep=[]
#déclaration d'une variable de condition qui mettra fin a la boucle et qui indiquera la position dans la liste
w=0
#boucle: tant que la valeur de la variable w est diferent de la valeur du nombre de terme dans la liste, la boucle continue
while w!=len(liste):
    #si la valeur du terme de la liste placer a la position de la valeur de w est inferieur ou egal a 6
    if len(liste[w])<=6:
        #il sera ajouter a listem
        listem.append(liste[w])
        #w est incrementé de 1
        w+=1
    #sinon
    else:
        #il sera ajouter a listep
        listep.append(liste[w])
        #w est incrementé de 1
        w+=1
#affichage des 2 listes
print("Nom a moins de 6 caracteres:",listem,"\n","Nom a plus de 6 caracteres:",listep,sep="")
input()
