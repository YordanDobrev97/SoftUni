SELECT TOP 5 e.EmployeeID, 
			 e.FirstName, 
			IIF(CAST(DATEPART(YEAR, p.StartDate) AS INT) >= 2005,
			NULL,
			p.[Name]) AS [ProjectName]
FROM Employees AS e
JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24

