SELECT 
	PARIS.pari_id,
	PARIS.pari_montant,
	PARIS.course_id,
	COURSES.course_nom,
	CHEVAUX.cheval_nom,
	CHEVAUX.cheval_id,
	PARTICIPANTS.participant_numero AS Numero_cheval,
	PRONOSTIQUES.pronostique_position_cheval AS Position_Parie,
	PARTICIPANTS.participant_position_final AS Position_Cheval
FROM PARIS
INNER JOIN COURSES ON COURSES.course_id = PARIS.course_id
INNER JOIN PARTICIPANTS ON PARTICIPANTS.course_id = COURSES.course_id
INNER JOIN CHEVAUX ON PARTICIPANTS.cheval_id = CHEVAUX.cheval_id
INNER JOIN PRONOSTIQUES ON PARIS.pari_id = PRONOSTIQUES.pari_id
INNER JOIN CHEVAUX AS C2 ON C2.cheval_id = PRONOSTIQUES.cheval_id
WHERE CHEVAUX.cheval_id = C2.cheval_id
ORDER BY PARIS.pari_id,COURSES.course_id ASC,PARTICIPANTS.participant_position_final;

SELECT * FROM PRONOSTIQUES;