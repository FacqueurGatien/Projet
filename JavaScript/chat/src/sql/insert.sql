SET FOREIGN_KEY_CHECKS = 0;				
TRUNCATE TABLE UTILISATEUR;				
TRUNCATE TABLE MESSAGE;		
TRUNCATE TABLE CHAT;				
SET FOREIGN_KEY_CHECKS = 1;			


INSERT INTO	UTILISATEUR	(userPseudo)
VALUES	
("Sora"),("Kita"),("Gin"),("Ryuji");

INSERT INTO	CHAT(chatId,chatCanal)
VALUES	
(1,"Public"),(2,"Prive"),(3,"Amis"),(4,"VIP");

INSERT INTO	MESSAGE(messageContenue,messageDate,chatId,userId)
VALUES	
("Salut ca va?","2022-11-09 11:00:00",1,1),
("Salut, ca va et toi?","2022-11-09 11:00:30",1,2),
("yep Nickel, j'ai bien mangé lol","2022-11-09 11:00:50",1,1),
("Quoi de neuf?","2022-11-09 11:01:05",1,1),
("Une SWITCH!!!!!","2022-11-09 11:01:12",1,2),
("Haa cool !","2022-11-09 11:01:32",1,1),
("Waaaa la chance !","2022-11-09 11:01:35",1,3),
("Trop bien !","2022-11-09 11:01:42",1,4),
("Tu as quoi comme jeu dessus deja?","2022-11-09 11:02:00",1,1),
("Pokemon Legend Arceus :p","2022-11-09 11:02:30",1,2),
("Il est pas bien noté askip","2022-11-09 11:02:50",1,3),
("Osef des avis de noob","2022-11-09 11:03:05",1,4),
("Du moment qu'il te plait a toi","2022-11-09 11:03:12",1,1),
("QUOI !","2022-11-09 11:03:32",1,3),
("TG sale noob","2022-11-09 11:03:35",1,4),
("OUAIII BATTEZ VOUS grrr","2022-11-09 11:03:42",1,2),
("Ha quand meme !","2022-11-09 11:04:00",1,1),
("1v1 gare du nord","2022-11-09 11:04:12",1,3),
("ISSOU !","2022-11-09 11:04:32",1,4),
("Et du coup il est bien?","2022-11-09 11:04:40",1,1),
("oui !!","2022-11-09 11:04:52",1,2),
("C'est le principal !","2022-11-09 11:05:02",1,1),
("EXACTEMENT","2022-11-09 11:05:12",1,3);

INSERT INTO	MESSAGE(messageContenue,messageDate,chatId,userId)
VALUES	
("Salut ca va?","2022-11-09 11:00:00",2,1),
("Il est bizzare Ryuji non?","2022-11-09 11:00:30",2,2),
("Oui mais c'est pour ca que je l'aime bien, tkt il est pas mechant","2022-11-09 11:00:50",2,2),
("Si tu le dis","2022-11-09 11:01:05",2,1),
("Quoi tu me crois pas ?","2022-11-09 11:01:12",2,2),
("Si si tkt","2022-11-09 11:01:32",2,1),
("ok :)","2022-11-09 11:01:35",2,3);