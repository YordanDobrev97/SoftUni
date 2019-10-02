SELECT DepositGroup, 
SUM(DepositAmount) 
AS TotalSum 
FROM WizzardDeposits 
AS d
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY d.DepositGroup
HAVING SUM(DepositAmount) <= 150000
ORDER BY TotalSum DESC
