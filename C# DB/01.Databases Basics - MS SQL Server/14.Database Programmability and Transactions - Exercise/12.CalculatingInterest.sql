CREATE PROC usp_CalculateFutureValueForAccount (@accountId INT, @rate FLOAT)
AS
BEGIN
	SELECT a.Id,
		   ah.FirstName,
		   ah.LastName,
		   a.Balance AS [Current Balance],
		   dbo.ufn_CalculateFutureValue(a.Balance, @rate, 5) AS [Balance in 5 years]
	FROM AccountHolders AS ah
	JOIN Accounts AS a ON a.AccountHolderId = ah.Id
	WHERE a.Id = @accountId
END