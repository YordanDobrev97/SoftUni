SELECT e.EmployeeID,
	   e.FirstName,
	   em.EmployeeID AS [ManagerID],
	   em.FirstName AS [ManagerName]
FROM Employees AS e
JOIN Employees As em ON em.EmployeeID = e.ManagerID
WHERE em.EmployeeID IN (3, 7)
ORDER BY e.EmployeeID