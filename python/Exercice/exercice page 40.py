#Exercice 5.1
#convertisseur de radian en degres
#Rapelle (1°=60minutes=3600secondes 1pi rad=180° 1°rad =0.017)
#de degres a radian = x*3.14/180, de radian a degres =x*180/3.14
pir=180
pi=3.14
deg=1
rad=1
rad=float(input("Combient de Radian voulez vous convertir? :"))
deg=rad*pir/pi
deg,rad=str(deg),str(rad)
print(rad+"rad","corespond a",deg+"°")

#saut a la ligne
print("")
print("")

#Exercice 5.2
#convertisseur de degres en radian
#Rapelle (1°=60minutes=3600secondes 1pi rad=180° 1°rad =0.017)
#de degres a radian = x*3.14/180, de radian a degres =
pir=180
pi=3.14
deg=1
rad=1
deg=float(input("Combient de degres voulez vous convertir? :"))
rad=deg*pi/pir
deg,rad=str(deg),str(rad)
print(deg+"°","corespond a",rad+"rad")

#saut a la ligne
print("")
print("")

#Exercice 5.3
#convertisseur degré celcius en fahrenheit
#rapelle de la formule de conversion de celcius a fahrenheit : Tf=Tcx1.8+32

#déclaration des variables celcius et fahrenheit
Tf=1
Tc=1
#demande de saisie par l'utilisateur d'entrer un nombre de degres
Tc=int(input("combien de degres? :"))
#conversion de Celcius a Fahrenheit
Tf=Tc*1.8+32
#conversion des valeurs int en str
Tf,Tc=str(Tf),str(Tc)
#Affichage des degres avant et apres conversion
print(Tc+"°","celcius corespond a",Tf+"°","Fahrenheit")

#saut a la ligne
print("")
print("")

#exercice 5.4
#calcule d'interet sur 20 ans
#déclaration des variable tune(argent déposé), taux(taux d'interet), ans(nombre d'année epargné),boucle(fin de la boucle)
tune=1
taux=1
ans=1
boucle=0
#demande de saisie des informations par l'utilisateur
tune,taux,ans=float(input("Combien d'argent avez vous placer? :")),float(input("A quel taux d'interet? :")),int(input("sur combien d'années? :"))
#boucle s'arretant quand boucle< a ans
while boucle<ans:
    #fonction permetant d'incrementer l'interet généré par le taux d'interet sur la somme, a la somme entrée par l'utilisateur
    tune=tune*(1+taux/100)
    #affichage de la somme mise a jour
    print("la",boucle+1,"années votre capital sera de :",int(tune))
    #incrementation de la variable boucle
    boucle=boucle+1

#saut a la ligne
print("")
print("")

#exercice 5.5
#grain de riz
a=1
#case d'echequier
b=1
#affichage du nombre de grain de riz sur la premier case
print("case:",b,"=",a,"grains de riz")
b=b+1
#LA boucle s'arrete quand b<65
while b<65:
    #affiche le nombre de grain de riz (2 fois la variable a)
    print("case:",b,"=",a*2,"grains de riz")
    #affiche le nombre de grain de riz (2 fois la variable a) (en notation scientifique)
    print("soit",float(a*2),"grains de riz")
    #Incrementation des variable(a*2 de sorte que le nombre de grain soit doublé a l'iteration suivante et b pour stopper la boucle)
    a,b=a*2,b+1



