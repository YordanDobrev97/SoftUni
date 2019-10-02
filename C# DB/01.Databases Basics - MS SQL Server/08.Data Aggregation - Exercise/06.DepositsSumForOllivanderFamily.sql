SELECT DepositGroup, 
SUM(DepositAmount) 
AS [Sum] 
FROM WizzardDeposits 
AS d
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY d.DepositGroup
