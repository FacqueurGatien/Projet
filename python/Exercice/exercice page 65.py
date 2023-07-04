from turtle import *
from random import randrange
def triangletest(repete,couleur):
    a,b,c=-500,0,0
    colorl=["blue","red","pink","black","yellow","orange","grey","green"]
    while b != repete:
        up()
        #color(colorl[randrange(0,8)])
        color(couleur)
        goto(a+c,0)
        down()
        forward(100)
        left(120)
        forward(100)
        left(120)
        forward(100)
        left(120)
        c+=100
        b+=1
        couleur=colorl[randrange(0,8)]
