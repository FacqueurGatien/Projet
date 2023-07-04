#Exercice 6.1
#convertisseur de metre a miles
#1miles = 1609 metres
vmi=float(input("Quel vitesse voulez vous convertir? (miles/heure) :"))
vkm=vmi*1609/1000
vm=vmi*1609/3600
print(vmi,"mi/h =",vm,"m/s soit",vkm,"km/h")

#Exercice 6.2
#calculer l'aire d'un triangle quelquonque
#formule de calcule d'aire d'un triangle: A=sqrt(d*(d-a)*(d-b)*(d-c))
from math import *
ca=float(input("renseigner le le premier coté du triangle: "))
cb=float(input("renseigner le le second coté du triangle: "))
cc=float(input("renseigner le le troisiemme coté du triangle: "))
dp=(ca+cb+cc)/2
airabc=sqrt(dp*(dp-ca)*(dp-cb)*(dp-cc))
print("L'aire du triangle est de :",airabc)

#Exercice 6.3
#Calculer la periode d'une pendule
#Rapel de la formule de calcule de la periode d'une pendule : T= 2*pi*sqrt(l/g)
from math import *
g=int(input("Quel est la pesenteur exercé?(Psesenteur terrestre = 9.81): "))
l=int(input("Quel est la longueur du pendule?: "))
T=2*pi*sqrt(l/g)
print("La periode du pendul est de ",T,"T",sep="")

#Exercice 6.4
#Encoder des valeur dans une liste et terminer sans rien ecrire
liste,x=["Boucle"],0
while len(liste[x])!=0:
    liste.append(input("Veuillez entrer une valeur"))
    x+=1
liste.remove("Boucle"),liste.remove("")
print(liste)
