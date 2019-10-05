SELECT wizzard.DepositGroup, wizzard.MagicWandCreator, 
MIN(wizzard.DepositCharge) AS MinDepositCharge
FROM WizzardDeposits AS wizzard
GROUP BY wizzard.MagicWandCreator, wizzard.DepositGroup
ORDER BY wizzard.MagicWandCreator, wizzard.DepositGroup
