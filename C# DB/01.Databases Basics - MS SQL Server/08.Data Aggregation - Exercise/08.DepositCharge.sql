SELECT DepositGroup,
	   MagicWandCreator, 
		MIN(DepositCharge) 
AS [MinDepositCharge] 
FROM WizzardDeposits AS r
GROUP BY r.DepositGroup, r.MagicWandCreator
ORDER BY r.MagicWandCreator, r.DepositGroup