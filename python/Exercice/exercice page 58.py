#Exercice 6.8
#Programe qui detecte les multiple de 3 et 5 entre 2 bornes et qui les additionnes
#exemple: borne_min,borne_max=0,32, le resultat devrais etre 0+15+30=45

#Demande de saisie par l'utilisateur
borne1,borne2=int(input("Entrez la Borne basse :")),int(input("Entrez la Borne haute :"))
boucle=borne1
liste=[]
while boucle != borne2+1:
    if not boucle %3 and not boucle%5:
        liste.append(boucle)
        boucle+=1
    else:
        boucle+=1
screen=str(liste[0])
calcul=str(liste[0])
boucle2=len(liste)
compt=1
while compt != boucle2:
    screen=screen+"-"+str(liste[compt])
    calcul=calcul+"+"+str(liste[compt])
    compt+=1
print("Voici les multiples de 3 et 5 entre les 2 bornes; ",screen,"\nEt voici le resultat; ",eval(calcul),sep="")

#Exercice 6.9
#Année bisextile
#Rapel une année est bisextile si elle est divisible par 4 et ne l'est pas si elle est divisible par 100 mais l'est si divisible par 400

annee=int(input("Quel année voulez vous verifier?: "))
if not annee%100 and not annee%400:
    print(annee,"Cet année est bisextile")
    annee+=1
elif not annee%4 and annee%100:
    print(annee,"Cet année est bisextile")
    annee+=1
else:
    print(annee,"Cet année n'est pas bisextile")
    annee+=1

#Exercice 6.10
#Demander a l'utilisateur son nom et son sexe
#En fonction du sexe aficher chere monsieur ou chere madame

person=input("Comment vous appelez vous: ")
sexe=input("Etes vous un Homme ou une Femme: ")
if sexe[0]=="M" or sexe[0]=="m" or sexe[0]=="H" or sexe[0]=="h":
    print ("Cher Monsieur ",person,sep="")
else:
    print("chere Madamme ",person,sep="")

#Exercice 6.11
#Demander a l'utilisateur de donner 3 longueur puis etablir s'il est possible de faire un triangle avec, et quel type de triangle
#Rapelle des regle permetant de consttruire un triangle
#Isocele        :
#Equilateral    :
#Rectangle      :
#Quelconque     :
