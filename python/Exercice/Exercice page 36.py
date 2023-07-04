#exercice 4.5
#programme calculant l'aire d'un Parallélépipède
#Rapelle de la regle de calcule pour calculer l'Aire (L=long, h=hauteur,p=pronf): 2Ll+2Lp+2lp
l,h,p,t=1,1,1,1                          #déclaration des 3 variable d'un parallélépipède+aire

#demande de saisie par l'utilisateur
l,h,p=int(input("Longueur ?: ")),int(input("hauteur ?: ")), int(input("Pronfondeur ?: "))
#fonction de calcule de l'aire + son affichage
t=2*h*l+2*h*p+2*l*p
#saut a la ligne
print("")
#affichage du resultat
print("L'aire du Parallélépipède est de :",t)
#saut a la lignex2
print("")
print("")

#exercice 4.6
#convertisseur de seconde
#anné            mois            semaine     jours         heure    minute   secondes
#31622400    2635200       604800      86400        3600      60         1
#---------->/12--------->/30.5--------------------->/24----->/60----->/60
#Déclaration des variable Anné,Mois,Jours,Heures,Minutes
an,mo,jo,he,mi=31622400,2635200,86400,3600,60
#Demande de saisie par l'utilisateur du nombre de seconde+conversion en nombre entier
sc=int(input("combien de secondes?: "))

#conversion de la saisie sc a l'aide des variables (an,mo,jo,he,mi)
#ex mi,sc=sc//mi,sc%mi (ave sc=90):
#donc mi=sc//mi == 1 (90/60= 1.5 arrondi a 1 on ne prend que le nombre Réele) mi vaut a présent 1 (mi=1)
#sc=sc%mi == 30 (90/60 (en division euclydienne) =1 restant 30 on ne prend que le restant) sc vaut a présent 30 (sc=30)
an,sc=sc//an,sc%an
mo,sc=sc//mo,sc%mo
jo,sc=sc//jo,sc%jo
he,sc=sc//he,sc%he
mi,sc=sc//mi,sc%mi
#saut a la ligne
print("")
#Affichage des résultante des conversion (en reprenant notre exemple on a vu que mi=1 et sc=30)
#donc print affichera 0 Ans 0 Mois 0 Jours 0 Heures 1 Minutes 30 Secondes dans le cas ou la saisie est 90
print(an,"Ans",mo,"Mois",jo,"Jours",he,"Heures",mi,"Minutes",sc,"Secondes")
#saut a la lignex2
print("")
print("")


#exercice 4.7
#table de 7 avec multiple de 3

#declaration variable de multiplicateur
table=1
#déclaration de la variable permettant de finir la boucle
fin=1
#demande de saisie par l'utilisateur pour la seletion de la table de multiplication
mult=int(input("Quel table de multiplication? :"))
#boucle qui s'arretera quand la variable fin attindra 21
while fin<21:
    #condition : si table* mult %3 == a 0 alors c'est un multiple de 3
    if (table*mult)%3==0:
        #la fonction affichera donc un resultat suivi d'un asterix
        print(table,"x",mult,"=",table*mult,"*")
    #sinon
    else:
        #le resultat ne sera pas suivi d'un asterix
        print(table,"x",mult,"=",table*mult)
    #les variable fin et table sont incrementé de 1 avant de refaire une boucle
    fin=fin+1
    table=table+1
    
#exercice 4.8
#table de multiplication n'affichant que les multiple de 7

#declaration variable de multiplicateur
table2=1
#déclaration de la variable permettant de finir la boucle
fin2=1
#demande de saisie par l'utilisateur pour la seletion de la table de multiplication
mult2=int(input("Quel table de multiplication? :"))
#boucle qui s'arretera quand la variable fin attindra 21
while fin2<21:
    #condition : si table2* mult2 %7 == a 0 alors c'est un multiple de 7
    if (table2*mult2)%7==0:
        #la fonction affichera donc un resultat 
        print(table2,"x",mult2,"=",table2*mult2,)
    #les variable fin et table sont incrementé de 1 avant de refaire une boucle
    fin2=fin2+1
    table2=table2+1
#saut a la lignex2
print("")
print("")

#exercice 4.9
#Affichage et incrémentation de texte ("*" dans notre cas)
#Declaration de la variable affichant "*"
x="*"
#déclaration du multiplicateur de la variable "*" et qui mettra fin a la boucle
y=1
#boucle qui s'arretera quand y sera = a 21
while y<21:
    #affichage des asterix
    print(x*y)
    #incrementation de y de 1
    y=y+1

print("fin des exercices")
