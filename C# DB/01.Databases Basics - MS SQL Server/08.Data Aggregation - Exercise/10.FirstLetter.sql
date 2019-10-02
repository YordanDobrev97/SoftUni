SELECT 
DISTINCT 
SUBSTRING([FirstName], 1, 1) 
AS [FirstLetter] 
FROM WizzardDeposits 
AS r
WHERE r.DepositGroup = 'Troll Chest'