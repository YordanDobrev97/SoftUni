CREATE TABLE Accounts (
    Id INT PRIMARY KEY IDENTITY,
	AccountTypeId INT FOREIGN KEY REFERENCES AccountType(Id),
	Balance DECIMAL(15,2) NOT NULL DEFAULT(0),
	ClientId INT FOREIGN KEY REFERENCES Clients(Id)
)

SELECT * FROM Accounts

INSERT INTO Clients (FirstName, LastName) VALUES 
('Gosho', 'Ivanov'),
('Pesho', 'Petrov'),
('Ivan', 'Iliev'),
('Merry', 'Ivanova')

INSERT INTO AccountType ([Name]) VALUES
('Checking'),
('Savings')

INSERT INTO Accounts(ClientId, AccountTypeId, Balance) VALUES
(1,1, 175),
(2,1, 275.56),
(3,1, 138.01),
(4, 1, 40.30),
(4, 2, 375.50)


CREATE FUNCTION CalculateTotalBalance (@ClientID INT)
RETURNS DECIMAL(15,2)
BEGIN
	DECLARE @result AS DECIMAL(15,2) = (
		SELECT SUM(Balance)
		FROM Accounts WHERE ClientId = ClientID
	)
	RETURN @result
END

SELECT * FROM Clients
SELECT * FROM AccountType
SELECT * FROM Accounts
