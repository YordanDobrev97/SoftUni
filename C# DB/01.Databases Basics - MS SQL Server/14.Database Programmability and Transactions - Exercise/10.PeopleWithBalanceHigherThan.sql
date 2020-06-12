CREATE PROC usp_GetHoldersWithBalanceHigherThan (@number DECIMAL(18, 4))
AS
BEGIN
	SELECT ah.FirstName AS [First Name],
		   ah.LastName AS [Last Name]
	FROM Accounts AS a
	JOIN AccountHolders AS ah ON a.AccountHolderId = ah.Id
	GROUP BY ah.FirstName, ah.LastName
	HAVING SUM(a.Balance) >= @number
	ORDER BY ah.FirstName, ah.LastName
END
GO
--example
EXEC usp_GetHoldersWithBalanceHigherThan 50000