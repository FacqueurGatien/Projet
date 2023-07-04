CREATE TRIGGER insert_mises_trigger
ON PRONOSTIQUES
AFTER INSERT AS
BEGIN    
	Declare selected CURSOR FOR    
	SELECT		
		cheval_id, 
		pari_id 
	FROM inserted;   

	OPEN selected;    
	    
	Declare @cheval_id INT;    
	Declare @pari_id INT;    
	FETCH NEXT FROM selected INTO  @cheval_id, @pari_id;    

	WHILE (@@FETCH_STATUS = 0)    
	BEGIN        
		DECLARE @cheval int;       		
			SELECT @cheval = COUNT(*)  FROM PARIS
			JOIN PRONOSTIQUES ON PARIS.pari_id = PRONOSTIQUES.pari_id
			JOIN CHEVAUX ON CHEVAUX.cheval_id = PRONOSTIQUES.cheval_id
			JOIN PARTICIPANTS ON CHEVAUX.cheval_id = PARTICIPANTS.cheval_id AND PARTICIPANTS.course_id = PARIS.course_id
		WHERE PARIS.pari_id = @pari_id AND CHEVAUX.cheval_id = @cheval_id
		IF (@cheval < 1)        
		BEGIN            
			RAISERROR('Probleme insertion impossible', 10,1);            
			ROLLBACK TRAN;        
		END
	FETCH NEXT FROM selected INTO @cheval_id, @pari_id;    
	END
	CLOSE selected;    
	DEALLOCATE selected;
END;

/*
CREATE TRIGGER VERIFIER_CHEVAL
ON PRONOSTIQUES
AFTER INSERT AS
BEGIN
DECLARE @cheval INT;
SELECT @cheval = COUNT(*)  FROM PARIS
JOIN PRONOSTIQUES ON PARIS.pari_id = PRONOSTIQUES.pari_id
JOIN CHEVAUX ON CHEVAUX.cheval_id = PRONOSTIQUES.cheval_id
JOIN PARTICIPANTS ON CHEVAUX.cheval_id = PARTICIPANTS.cheval_id AND PARTICIPANTS.course_id = PARIS.course_id
WHERE PARIS.pari_id = (SELECT inserted.pari_id FROM inserted) AND CHEVAUX.cheval_id = (SELECT cheval_id FROM inserted)
IF  @cheval < 1
	rollback tran;
	raiserror('Le cheval pronostiqué n''est pas participant',0,1);
END;
*/