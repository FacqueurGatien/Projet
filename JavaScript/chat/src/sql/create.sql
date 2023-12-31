DROP TABLE IF EXISTS MESSAGE;
DROP TABLE IF EXISTS CHAT;
DROP TABLE IF EXISTS UTILISATEUR;

CREATE TABLE UTILISATEUR(
   userId INT AUTO_INCREMENT,
   userPseudo VARCHAR(50) NOT NULL,
   userDateNaissance DATE,
   PRIMARY KEY(userId)
);

CREATE TABLE CHAT(
   chatId INT,
   chatCanal VARCHAR(50) NOT NULL,
   PRIMARY KEY(chatId)
);

CREATE TABLE MESSAGE(
   messageId INT AUTO_INCREMENT,
   messageContenue TEXT NOT NULL,
   messageDate DATETIME NOT NULL,
   chatId INT NOT NULL,
   userId INT NOT NULL,
   PRIMARY KEY(messageId),
   CONSTRAINT FK_MESAGE_CHAT FOREIGN KEY(chatId) REFERENCES CHAT(chatId),
   CONSTRAINT FK_MESSAGE_UTILISATEUR FOREIGN KEY(userId) REFERENCES UTILISATEUR(userId)
);

