# Exercice 8.12
# Écrivez un programme qui fait apparaître une fenêtre avec un canevas.
# Dans ce canevas on verra deux cercles (de tailles et de couleurs différentes) qui sont censés représenter deux astres.
# Des boutons doivent permettre de les déplacer à volonté tous les deux dans toutes les directions. Sous le canevas,
# le programme doit afficher en permanence :
# a) la distance séparant les deux astres;
# b) la force gravitationnelle qu’ils exercent l’un sur l’autre


from tkinter import *
from math import *

#####################
#Definition de déplacement
def deplace(gd,hb,astre):
    global x1,x2,x3,x4,y1,y2,y3,y4,xa,xb,ya,yb
    #Déplacement de l'astre 1
    if astre==astre1:       
        x1,y1,x2,y2=x1+gd,y1+hb,x2+gd,y2+hb
        xa,ya=xa+gd,ya+hb
        canvas.coords(astre1,x1,y1,x2,y2)
    #Déplacement de l'astre 2
    if astre==astre2:
        x3,y3,x4,y4=x3+gd,y3+hb,x4+gd,y4+hb
        xb,yb=xb+gd,yb+hb
        canvas.coords(astre2,x3,y3,x4,y4)
    gravitation()           #Apel de la fonction gravitation
    
#####################
#Definition des valeurs de deplacement
def haut(a):
    if a ==1:
        deplace(0,-10,astre1)
    if a ==2:
        deplace(0,-10,astre2)
def bas(a):
    if a ==1:
        deplace(0,10,astre1)
    if a ==2:
        deplace(0,10,astre2)
def gauche(a):
    if a ==1:
        deplace(-10,0,astre1)
    if a ==2:
        deplace(-10,0,astre2)
def droite(a):
    if a ==1:
        deplace(10,0,astre1)
    if a ==2:
        deplace(10,0,astre2)
        
###################
# Definition de la conversion des deistanceen N
def gravitation():
    global xa,xb,ya,yb,rD,dTS
    mt, ms=5.972*(10**24), 1.989*(10**30)                       #Masse de la terre(1) et du soleil(2) en Kg
    lo,la=xb-xa,yb-ya                                           #Longueur(1) Largeur(2), : pour le ccalcul de l'hippotenuse
    h=sqrt(la**2+lo**2)                                         #Calcul de l'Hipotenuse
    distance=h*rD                                               #Calcul de la distance avec l'hippotenuse * la distance de reference 
    #Si la distance est = a 0 les valeurs ne sont plus calculables: affichage de l'erreur
    if distance==0:
        Label(fenetre,text="                        INF                        ").grid(row=0,column=10)
        Label(fenetre,text="                        0 Km                        ").grid(row=1,column=10)
    #Sinon calcul de la force de gravitation et affichage des valeur :distance et force
    else:
        force=(6.67*10**-11)*((mt*ms)/((distance)**2))
        Label(fenetre,text="            "+str(round(force,1))+"  Nw            ").grid(row=0,column=10)
        Label(fenetre,text="            "+str(round(distance,1))+"  Km            ").grid(row=1,column=10)

###################
# Déclaration des variable de position des astres
dTS=149.6*10**6                             #Distance terre<-->soleil en km
x1,y1,x2,y2=0,20,20,0                       #Variable de position de la terre
x3,y3,x4,y4=400,500,500,400                 #variable de position du soleil
xa,ya,xb,yb=10,10,450,450                   #variable de position du centre des astre (xa,ya= Terre --- xb,yx= Soleil)
lo,la=xb-xa,yb-ya                           #Longueur(1) Largeur(2), : pour le ccalcul de l'hippotenuse
rD=dTS/sqrt(lo**2+la**2)                    #Calcul proportionelle de la distance de reference (si la distance entre les 2 point = a la distance terre<->soleil, la distance pour 1 unité de distance et de: rD)

###################
fenetre=Tk()

canvas=Canvas(fenetre,width=500,height=500,bg="black")
canvas.grid(row=3,column=10)
astre2=canvas.create_oval(x3,y3,x4,y4,width=2,fill="yellow")
astre1=canvas.create_oval(x1,y1,x2,y2,width=2,fill="blue")
Label(fenetre,text="Terre: masse= 5.972x10^24 Kg").grid(row=0,column=1)
Label(fenetre,text="Soleil: masse= 1.989x10^30 Kg").grid(row=0,column=21)
gravitation()
Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=4,column=10)


Button(fenetre,text="Haut",command=lambda a=1:haut(a)).grid(row=1,column=1)
Button(fenetre,text="Bas",command=lambda a=1:bas(a)).grid(row=2,column=1)
Button(fenetre,text="Gauche",command=lambda a=1:gauche(a)).grid(row=2,column=0)
Button(fenetre,text="Droite",command=lambda a=1:droite(a)).grid(row=2,column=2)

Button(fenetre,text="Haut",command=lambda a=2:haut(a)).grid(row=1,column=21)
Button(fenetre,text="Bas",command=lambda a=2:bas(a)).grid(row=2,column=21)
Button(fenetre,text="Gauche",command=lambda a=2:gauche(a)).grid(row=2,column=20)
Button(fenetre,text="Droite",command=lambda a=2:droite(a)).grid(row=2,column=22)

fenetre.mainloop()
fenetre.destroy()

#####################################################################################################################################################################
#Exercice 8.13
#En vous inspirant du programme qui détecte les clics de souris dans un canevas, modifiez le programme ci-dessus pour y réduire le nombre de boutons :
#pour déplacer un astre, il suffira de le choisir avec un bouton, et ensuite de cliquer sur le canevas pour que cet astre se positionne à l’endroit où l’on a cliqué. 

from tkinter import *
from math import *

def gravitation():
    global posT,posS
    mt, ms=5.972*(10**24), 1.989*(10**30)      #Masse de la terre(1) et du soleil(2) en Kg
    lo,la=abs(posS[0]-posT[0]),abs(posS[1]-posT[1])             #Longueur(1) Largeur(2), : pour le ccalcul de l'hippotenuse
    
    h=sqrt(la**2+lo**2)                                         #Calcul de l'Hipotenuse
    distance=h*rD                                               #Calcul de la distance avec l'hippotenuse * la distance de reference 
    #Si la distance est = a 0 les valeurs ne sont plus calculables: affichage de l'erreur
    if distance==0:
        Label(fenetre,text="                        INF                        ").grid(row=0,column=10)
        Label(fenetre,text="                        0 Km                        ").grid(row=0,column=10)
    #Sinon calcul de la force de gravitation et affichage des valeur :distance et force
    else:
        force=(6.67*10**-11)*((mt*ms)/((distance)**2))
        Label(fenetre,text="            "+str(round(force,1))+"  Nw            ").grid(row=0,column=10)
        Label(fenetre,text="            "+str(round(distance,1))+"  Km            ").grid(row=5,column=10)
        
def pointeur(event):
    global a,posT,posS
    if a==1:
        canvas.coords(astre1,event.x+10,event.y-10,event.x-10,event.y+10)
        posT=(event.x,event.y)
    elif a==2:
        canvas.coords(astre2,event.x+50,event.y-50,event.x-50,event.y+50)
        posS=(event.x,event.y)
    else:
        pass
    gravitation()

def ad(x):
    global a
    a=x
    
###################
# Déclaration des variable de position des astres
dTS=149.6*10**6
posT,posS=(10,10),(450,450)
lo,la=abs(posS[0]-posT[0]),abs(posS[1]-posT[1])
x1,y1,x2,y2=0,20,20,0                       #Variable de position de la terre
x3,y3,x4,y4=400,500,500,400                 #variable de position du soleil
rD=dTS/sqrt(lo**2+la**2)
a=0

###################
fenetre=Tk()
canvas=Canvas(fenetre,width=500,height=500,bg="black")
canvas.grid(row=10,column=10)
canvas.bind("<Button-1>",pointeur)
astre2=canvas.create_oval(x3,y3,x4,y4,width=2,fill="yellow")
astre1=canvas.create_oval(x1,y1,x2,y2,width=2,fill="blue")
Label(fenetre,text="Masse= 5.972x10^24 Kg").grid(row=0,column=0)
Label(fenetre,text="Masse= 1.989x10^30 Kg").grid(row=0,column=20)
Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=20,column=10)
Button(fenetre,text="Terre",command=lambda x=1:ad(x)).grid(row=5,column=0)
Button(fenetre,text="Soleil",command=lambda x=2:ad(x)).grid(row=5,column=20)

fenetre.mainloop()
fenetre.destroy()

#####################################################################################################################################################################
#Exercice 8.14
#Extension du programme ci-dessus. Faire apparaître un troisième astre,
#et afficher en permanence la force résultante agissant sur chacun des trois
#(en effet : chacun subit en permanence l’attraction gravitationnelle exercée par les deux autres !).



from math import *
from tkinter import *

def gravitation():
    global posT,posS,posL,g,mt,ms,ml,rd
    tsx,tsy=(posS[0]-posT[0]),(posS[1]-posT[1])
    tlx,tly=(posL[0]-posT[0]),(posL[1]-posT[1])
    lsx,lsy=(posS[0]-posL[0]),(posS[1]-posL[1])
    hts,htl,hls=sqrt(tsx**2+tsy**2),sqrt(tlx**2+tly**2),sqrt(lsx**2+lsy**2)
    dts,dtl,dls=rd*hts,rd*htl,rd*hls
    #terre:  F(Lune/Soleil --->Terre) OK
    if dts==0:
        Label(fenetre,text="                        INF                        ").grid(row=4,column=0)
        Label(fenetre,text="            La distance entre A et C est de: "+str(round(dtl))+"Km                     ").grid(row=3,column=0)
        Label(fenetre,text="            La distance entre A et B est de: 0 Km                                      ").grid(row=2,column=0)
    elif dtl==0:
        Label(fenetre,text="                        INF                        ").grid(row=4,column=0)
        Label(fenetre,text="            La distance entre A et B est de: "+str(round(dts))+"Km                     ").grid(row=2,column=0)
        Label(fenetre,text="            La distance entre A et C est de: 0 Km                                      ").grid(row=3,column=0)
    else:
        fst=g*((mt*ms)/(dts*10**3)**2)
        flt=g*((mt*ml)/(dtl*10**3)**2)
        ft=fst+flt
        Label(fenetre,text="                        "+str(ft)+"  Nw                        ").grid(row=4,column=0)
        Label(fenetre,text="            La distance entre A et B est de: "+str(round(dts))+"Km                     ").grid(row=2,column=0)
        Label(fenetre,text="            La distance entre A et C est de: "+str(round(dtl))+"Km                     ").grid(row=3,column=0)

        
    #soleil: F(Terre/Lune --->Soleil) OK
    if dts==0:
        Label(fenetre,text="                        INF                        ").grid(row=4,column=10)
        Label(fenetre,text="            La distance entre B et C est de: "+str(round(dls))+"Km                     ").grid(row=3,column=10)
        Label(fenetre,text="            La distance entre B et A est de: 0 Km                                      ").grid(row=2,column=10)
    elif dls==0:
        Label(fenetre,text="                        INF                        ").grid(row=4,column=10)
        Label(fenetre,text="            La distance entre B et A est de: "+str(round(dts))+"Km                     ").grid(row=2,column=10)
        Label(fenetre,text="            La distance entre B et C est de: 0 Km                                      ").grid(row=3,column=10)
    else:
        fts=g*((ms*mt)/(dts*10**3)**2)
        fls=g*((ms*ml)/(dls*10**3)**2)
        fs=fts+fls
        Label(fenetre,text="                        "+str(fs)+"  Nw                        ").grid(row=4,column=10)
        Label(fenetre,text="            La distance entre B et A est de: "+str(round(dts))+"Km                     ").grid(row=2,column=10)
        Label(fenetre,text="            La distance entre B et C est de: "+str(round(dls))+"Km                     ").grid(row=3,column=10)

        
    #lune:   F(Soleil/Terre --->Lune) OK
    if dtl==0:
        Label(fenetre,text="                        INF                        ").grid(row=4,column=20)
        Label(fenetre,text="            La distance entre C et B est de: "+str(round(dls))+"Km                     ").grid(row=3,column=20)
        Label(fenetre,text="            La distance entre C et A est de: 0 Km                                      ").grid(row=2,column=20)
    elif dls==0:
        Label(fenetre,text="                        INF                        ").grid(row=4,column=20)
        Label(fenetre,text="            La distance entre C et A est de: "+str(round(dtl))+"Km                     ").grid(row=2,column=20)
        Label(fenetre,text="            La distance entre C et B est de: 0 Km                                      ").grid(row=3,column=20)
    else:
        ftl=g*((ml*mt)/(dtl*10**3)**2)
        fsl=g*((ml*ms)/(dls*10**3)**2)
        fl=ftl+fsl
        Label(fenetre,text="            "+str(fl)+"  Nw            ").grid(row=4,column=20)
        Label(fenetre,text="La distance entre C et A est de: "+str(round(dtl))+"Km                     ").grid(row=2,column=20)
        Label(fenetre,text="La distance entre C et B est de: "+str(round(dls))+"Km                     ").grid(row=3,column=20)

def pointeur(event):
    global a,posT,posS,posL
    if a==1:
        canvas.coords(astre1,event.x+5,event.y-5,event.x-5,event.y+5)
        posT=(event.x,event.y)
    if a==2:
        canvas.coords(astre2,event.x+50,event.y-50,event.x-50,event.y+50)
        posS=(event.x,event.y)
    if a==3:
        canvas.coords(astre3,event.x+3,event.y-3,event.x-3,event.y+3)
        posL=(event.x,event.y)
    gravitation()
def ad(x):
    global a
    a=x

mt, ms, ml=5.972*10**24, 1.989*10**30, 7.347*10**22
dts,dtl,dsl=1.5*(10**8),3*(10**7) ,(1.5*(10**8))-(3*(10**7))
g=6.67*(10**-11)
posT,posS,posL=(5,5),(505,505),(105,105)
loX,loY=abs(posS[0]-posT[0]),abs(posS[1]-posT[1])
rd=dts/sqrt(loX**2+loY**2)
xt1,yt1,xt2,yt2=0,10,10,0
xs1,ys1,xs2,ys2=555,455,455,555
xl1,yl1,xl2,yl2=108,102,102,108
a=0

fenetre=Tk()
canvas=Canvas(fenetre,width=600,height=600,bg="black")
canvas.grid(row=10,column=10)
canvas.bind("<Button-1>",pointeur)
astre2=canvas.create_oval(xs1,ys1,xs2,ys2,width=2,outline="yellow",fill="yellow")
astre1=canvas.create_oval(xt1,yt1,xt2,yt2,width=2,outline="blue",fill="blue")
astre3=canvas.create_oval(xl1,yl1,xl2,yl2,width=2,outline="gray",fill="gray")
Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=20,column=10)
Button(fenetre,text="A",command=lambda x=1:ad(x)).grid(row=5,column=0)
Button(fenetre,text="B",command=lambda x=2:ad(x)).grid(row=5,column=10)
Button(fenetre,text="C",command=lambda x=3:ad(x)).grid(row=5,column=20)
gravitation()
fenetre.mainloop()
fenetre.destroy()

################################################################################
# Exercice 8.15
# Même exercice avec des charges électriques (loi de Coulomb). Donner cette fois une possibilité de choisir le signe des charges.

from math import *
from tkinter import *

#######################
# Définition de récup de la valeur de distance via la fenetre Entry
#######################
def distance(event):
    global d
    d=dc.get()
    if d=="":
        d="1"
    else:
        pass
    d=eval(d)
    fonctionCharge()

#######################
# Définition de récupération des valeur q1 et q2 via les bouton positif et negatif
#######################
def negq1():
    global q1,q2
    q1=cq1.get()
    if q1=="":
        q1="0"
    else:
        pass
    q1=eval(q1)*-1
    chargeQ(q1,q2)
def posq1():
    global q1,q2
    q1=cq1.get()
    q1=eval(q1)
    chargeQ(q1,q2)
def negq2():
    global q1,q2
    q2=cq2.get()
    if q2=="":
        q2="0"
    else:
        pass
    q2=eval(q2)*-1
    chargeQ(q1,q2)
def posq2():
    global q1,q2
    q2=cq2.get()
    if q2=="":
        q2="0"
    else:
        pass
    q2=eval(q2)
    chargeQ(q1,q2)

##############################
# Définition qui provoque la dérivation vers la fonction attQ ou repQ selon les valeur positive ou negative de q1 et q2
##############################
def chargeQ(q1,q2):
    if (q1*q2)<0:
        attQ()
    else:
        repQ()

##############################
# Définition qui affiche 2 sphere avec 2 fleche sur le Canvas, illustrant la répulsivité des objet q1 et q2 selon leurs valeurs
##############################
def repQ():
    global q1,q2
    if q1>=0:
        coulQ1="red"
    else:
        coulQ1="blue"
    if q2>=0:
        coulQ2="red"
    else:
        coulQ2="blue"
    canvas.create_rectangle(0,0,500,300,width=1,outline="black",fill="black")
    canvas.create_oval(200,100,100,200,width=2,outline=coulQ1,fill=coulQ1)
    canvas.create_oval(400,100,300,200,width=2,outline=coulQ2,fill=coulQ2)
    canvas.create_rectangle(100,148,80,152,width=2,outline=coulQ1,fill=coulQ1)
    canvas.create_rectangle(400,148,420,152,width=2,outline=coulQ2,fill=coulQ2)
    ptsQ1=((80,150),(80,155),(75,150),(80,145))
    ptsQ2=((420,150),(420,155),(425,150),(420,145))
    canvas.create_polygon(ptsQ1,width=2,outline=coulQ1,fill=coulQ1)
    canvas.create_polygon(ptsQ2,width=2,outline=coulQ2,fill=coulQ2)
    canvas.create_text(150,150,text=str(q1),fill="white")
    canvas.create_text(350,150,text=str(q2),fill="white")
    fonctionCharge()

##############################
# Définition qui affiche 2 sphere avec 2 fleche sur le Canvas, illustrant l'attractivité des objet q1 et q2 selon leurs valeurs
##############################
def attQ():
    global q1,q2
    if q1>=0:
        coulQ1="red"
    else:
        coulQ1="blue"
    if q2>=0:
        coulQ2="red"
    else:
        coulQ2="blue"
    canvas.create_rectangle(0,0,500,300,width=1,outline="black",fill="black")
    canvas.create_oval(200,100,100,200,width=2,outline=coulQ1,fill=coulQ1)
    canvas.create_oval(400,100,300,200,width=2,outline=coulQ2,fill=coulQ2)
    canvas.create_rectangle(220,148,200,152,width=2,outline=coulQ1,fill=coulQ1)
    canvas.create_rectangle(300,148,280,152,width=2,outline=coulQ2,fill=coulQ2)
    ptsQ1=((220,150),(220,155),(225,150),(220,145))
    ptsQ2=((280,150),(280,155),(275,150),(280,145))
    canvas.create_polygon(ptsQ1,width=2,outline=coulQ1,fill=coulQ1)
    canvas.create_polygon(ptsQ2,width=2,outline=coulQ2,fill=coulQ2)
    canvas.create_text(150,150,text=str(q1),fill="white")
    canvas.create_text(350,150,text=str(q2),fill="white")
    fonctionCharge()

####################################
# Définition qui affiche dans le Canvas, la valeur de la charge éléctrique des 2 objet q1 et q2 
####################################
def fonctionCharge():
    global q1,q2,d
    canvas.create_rectangle(0,0,500,70,outline="black",fill="black")
    k=9*10**9
    f=k*((abs(q1)*abs(q2))/d**2)
    canvas.create_text(250,25,text=str(f),fill="white")
 
#####################################
# Définition qui évalue ce qui se trouve dans le bloc Entry, si il n'y a aucune valeur, alphanumérique, la fonction définit q1=0
#####################################
def neutreQ1(event):
    global q1,q2
    q1=cq1.get()
    if q1=="":
        q1="0"
    else:
        q1=eval(q1)
        chargeQ(q1,q2)

#####################################
# Définition qui évalue ce qui se trouve dans le bloc Entry, si il n'y a aucune valeur, alphanumérique, la fonction définit qq=0
#####################################
def neutreQ2(event):
    global q1,q2
    q2=cq2.get()
    if q2=="":
        q2="0"
    else:
        q2=eval(q2)
        chargeQ(q1,q2)
        
#####################################
# Déclaration des variables q1,q2 et d (objet1, objet2, distance)
#####################################
q1,q2,d=1.60*10**-19,-1.60*10**-19,10**-12

#####################################
# -Appel de la fonction Tk
# -création du Canvasou apparaittrons les sphere fleché
# -création de bouton, Label et espace de saisie de texte
# -Apel de la fonction attQ et mise en route de l'observateur d'evenement
#####################################
fenetre=Tk()
canvas=Canvas(fenetre,width=500,height=300,bg="black")
canvas.grid(row=9,column=10)
Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=20,column=10)
Label(fenetre,text="Charge electrique Q1").grid(row=10,column=8)
Label(fenetre,text="Distance entre les 2 charges").grid(row=10,column=10)
Label(fenetre,text="Charge electrique Q2").grid(row=10,column=12)
Button(fenetre,text="Q1=neg",command=negq1).grid(row=11,column=7)
Button(fenetre,text="Q1=pos",command=posq1).grid(row=11,column=9)
Button(fenetre,text="Q2=neg",command=negq2).grid(row=11,column=11)
Button(fenetre,text="Q2=pos",command=posq2).grid(row=11,column=13)
Button(fenetre,text="Eval",command=fonctionCharge).grid(row=12,column=10)
cq1=Entry(fenetre)
cq2=Entry(fenetre)
dc=Entry(fenetre)
cq1.bind("<Return>",neutreQ1)
cq2.bind("<Return>",neutreQ2)
dc.bind("<Return>",distance)
cq1.grid(row=11,column=8)
cq2.grid(row=11,column=12)
dc.grid(row=11,column=10)
attQ()

fenetre.mainloop()
fenetre.destroy()

#############################################################################
# Exercice 8.16
# Écrivez un petit programme qui fait apparaître une fenêtre avec deux champs :
# l’un indique une température en degrés Celsius, et l’autre la même température exprimée en degrés Fahrenheit.
# Chaque fois que l’on change une quelconque des deux températures, l’autre est corrigée en conséquence.
# Pour convertir les degrés Fahrenheit en Celsius et vice-versa, on utilise la formule T F=T C×1
#############################################################################
from math import *
from tkinter import *

####################################################
# Conversion de Celcius vers Fahraneith
def conversion_CvF(event):
    global cel,far,celV,farV,farE,celE,celE
    cel=celE.get()
    try:
        type(eval(cel))is int or type(eval(cel))is float
        cel=round(eval(cel),1)
        far=round((cel*(9/5))+32,1)
        farV=far
    
        #celV=StringVar(fenetre,value=cel)
        #celE=Entry(fenetre,textvariable=celV)
        #celE.grid(row=10,column=15)
        #celE.bind("<Return>",conversion_CvF)
        
        farV=StringVar(fenetre,value=far)
        farE=Entry(fenetre,textvariable=farV)
        farE.grid(row=10,column=5)
        farE.bind("<Return>",conversion_FvC)
        print(cel,far)
    except (NameError,ValueError,TypeError,SyntaxError,ZeroDivisionError):  
        farV=StringVar(fenetre,value="ERROR")
        farE=Entry(fenetre,textvariable=farV)
        farE.grid(row=10,column=5)
        farE.bind("<Return>",conversion_FvC)
        
####################################################
# Conversion de Fahraneith vers Celcius
def conversion_FvC(event):
    global cel,far,celV,farV,farE,celE,celE
    far=farE.get()
    try:
        type(eval(far))is int or type(eval(far))is float
        far=round(eval(far),1)
        cel=round((far-32)*(5/9),1)
        celV=cel
        
        celV=StringVar(fenetre,value=cel)
        celE=Entry(fenetre,textvariable=celV)
        celE.grid(row=10,column=15)
        celE.bind("<Return>",conversion_CvF)
        
        #farV=StringVar(fenetre,value=far)
        #farE=Entry(fenetre,textvariable=farV)
        #farE.grid(row=10,column=5)
        #farE.bind("<Return>",conversion_FvC)
        print(cel,far)
    except (NameError,ValueError,TypeError,SyntaxError,ZeroDivisionError):        
        celV=StringVar(fenetre,value="ERROR")
        celE=Entry(fenetre,textvariable=celV)
        celE.grid(row=10,column=15)
        celE.bind("<Return>",conversion_CvF)
        
        #farV=StringVar(fenetre,value=far)
        #farE=Entry(fenetre,textvariable=farV)
        #farE.grid(row=10,column=5)
        #farE.bind("<Return>",conversion_FvC)

######################################################
# Declaration des variable cel(celcius), far(fahraneith)
cel=0
far=32

######################################################
# Apel de la fonction Tk
# Création du bouton Quitter
fenetre=Tk()
Button(fenetre,text="Quitter",command=fenetre.quit).grid(row=20,column=10)

######################################################
# Création de la fenetre (Entry) en rapport avec la valeure Celcius
celV=StringVar(fenetre,value=cel)                   # Variable qui affiche la valeur dans le cadre Entry
celE=Entry(fenetre,textvariable=celV)               # Création de la fenetre Entry avec la variable definit juste avant
celE.grid(row=10,column=15)
celE.bind("<Return>",conversion_CvF)
Label(fenetre,text="Celcius").grid(row=9,column=15)
Label(fenetre,text="°").grid(row=10,column=16)

######################################################
# Création de la fenetre (Entry) en rapport avec la valeure Fahraneith
farV=StringVar(fenetre,value=(cel*(9/5))+32)        # Variable qui affiche la valeur dans le cadre Entry
farE=Entry(fenetre,textvariable=farV)               # Création de la fenetre Entry avec la variable definit juste avant
farE.grid(row=10,column=5)
farE.bind("<Return>",conversion_FvC)
Label(fenetre,text="Fahrenheit").grid(row=9,column=5)
Label(fenetre,text="°").grid(row=10,column=6)

fenetre.mainloop()
fenetre.destroy()
