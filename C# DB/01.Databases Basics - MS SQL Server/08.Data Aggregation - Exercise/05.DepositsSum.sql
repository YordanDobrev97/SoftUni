SELECT DepositGroup, 
SUM(DepositAmount) 
AS [Sum] 
FROM WizzardDeposits 
AS d
GROUP BY d.DepositGroup
