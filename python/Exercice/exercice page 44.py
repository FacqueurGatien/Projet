#Exrecice 5.6 et 5.7
#determiner si e fait partie d'une chaine de caractere

#quelle lettre est a détécté
let=0
#demande a l'utilisateur de saisir une phrase
a=input("saisir une phrase :")
#demande de saisie par l'utilisateur d'une lettre a detecter
let=input("quelle lettre voulez vous compter? :")
#declare l'etat False pour la boucle while
b=False
#delaration des variable de condition et de listing
c=0#liste des "e"
d=0#compteur de la liste a
comp=0#compteur incrementé pour arreter la boucle
#si le caractere "e" est dans la phrase contenue dans la variable a
if let in a:
    #affichage "la lettre "e" a eté detecte
    print("la lettre",let,"a été détécté")
    #l'etat de la variable b change d'etat et devient True la boucle deviendra active
    b=True
#sinon
else:
    #affichage "la lettre "e" n'a pas eté detecte" 
    print("la lettre",let,"n'a pas été détécté")
#la variable d calcule alors combien de caractere sont present dans la variable a -1 (-1 pour compenser le fait que le programme prend en compte le 0)
d=len(a)-1
#boucle prise en compte seulement si b=True
while b==True:
    #si la position correspondant a la variable comp contient la lettre correspondant a la variable let
    #ex: comp=5 a="azertyuiop" et let="y", la fonction va chercher a comparet le 5eme emplacement de la chaine de caracter "azertyuiop" qui est "y" et la comparer a let "y"
    #a[0]=a a[1]=z a[2]=e etc
    if a[comp]==let:
        #incrementation de la variable comp
        comp=comp+1
        #incrementation de la variable c
        c=c+1
        #si la variable comp est egal au nombre de caracter dans la variable a
        if comp==len(a):
            #alors la variable b change 'd'etat en = False pour arreter la boucle
            b=False
    #sinon
    else:
        #incrementation de la variable comp mais pas de la variable c juste ensuite
        comp=comp+1
        #si la variable comp est egal au nombre de caracter dans la variable a
        if comp==len(a):
            #alors la variable b change 'd'etat en = False pour arreter la boucle
            b=False
#si la variable c n'est pas egale a 0
if c !=0:
    #alors le programme affichera le message ex: Il y a 5 v dans cette phrase
    print("Il y a",c,let,"dans cette phrase")


#exercice 5.8
#ecrir un script qui réecrit une chaine de caractere et la modifie

a1=0
a2=""
a3=""
a1=input("ecrivez un mot :")
compteur=len(a1)
decompte=0
decompte2=len(a1)-1
while decompte!=compteur:
    a2=a2+a1[decompte]+"*"
    a3=a3+a1[decompte2]
    decompte+=1
    decompte2-=1
print(a2)
print(a3)
if a3==a1:
    print(a1,"se lit pareil dans les 2sens")

