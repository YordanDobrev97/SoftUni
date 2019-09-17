CREATE FUNCTION f_CalculateTotalBalance (@ClientID INT)
RETURNS DECIMAL (15,2)
BEGIN
	DECLARE @result AS DECIMAL(15,2) = (
		SELECT SUM(Balance)
		FROM Accounts WHERE ClientId = @ClientID
	)
	RETURN @result
END

SELECT dbo.f_CalculateTotalBalance(4) AS Balance

CREATE PROC p_AddAccount @ClientID INT, @AccountTypeID INT AS 
INSERT INTO Accounts (ClientId, AccountTypeId)
VALUES (@ClientID, @AccountTypeID)

p_AddAccount 2, 2

SELECT * FROM Accounts

UPDATE Accounts
SET Balance = 1200
WHERE Id = 6

SELECT * FROM Accounts
SELECT * FROM AccountType
SELECT * FROM Clients

INSERT INTO Accounts (Balance, ClientId, AccountTypeId)
VALUES (5000, 2,1)

DELETE FROM Accounts
WHERE AccountTypeId IS NULL

INSERT INTO Accounts (Balance)
VALUES (3000)