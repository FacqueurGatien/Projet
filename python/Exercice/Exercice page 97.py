# Exercice8.11 Modifiez le script ci-dessus de manière à faire apparaître un
# petit cercle rouge à l’endroit où l’utilisateur a effectué son clic
# (vous devrez d’abord remplacer le widget Frame par un widget Canvas).


from tkinter import *
def pointeur(event):
    cadre.create_rectangle(0,0,600,600,width=1,fill="light yellow")
    chaine.configure(text = "Clic détecté en X =" + str(event.x) +\
    ", Y =" + str(event.y))
    cadre.create_oval(event.x+20,event.y-20,event.x-20,event.y+20,width=1,outline="red")

fen = Tk()
cadre=Canvas(fen, width =600, height =600, bg="light yellow")
cadre.bind("<Button-1>", pointeur)
cadre.pack()
b1=Button(fen,text="Quitter",command=fen.quit)
b1.pack(side=RIGHT,padx=3,pady=3)
chaine = Label(fen)
chaine.pack()
fen.mainloop()
fen.destroy()
