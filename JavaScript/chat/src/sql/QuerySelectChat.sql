SELECT messageId, userPseudo , messageContenue
FROM MESSAGE
NATURAL JOIN UTILISATEUR 
NATURAL JOIN CHAT 
WHERE chatCanal="Public"
GROUP BY messageId 
ORDER BY messageDate DESC
LIMIT 15;

SELECT Count(messageId) AS m
FROM CHAT as C1
NATURAL JOIN MESSAGE AS M1
WHERE chatCanal="Public";

SELECT userId FROM UTILISATEUR WHERE userPseudo="Sora";

SELECT chatId FROM CHAT WHERE chatCanal='Prive';