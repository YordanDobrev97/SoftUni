SELECT IIF(CONCAT(e.FirstName, ' ', e.LastName) = '', 'None',  CONCAT(e.FirstName, ' ', e.LastName)) AS [Employee],
	   IIF(d.Name IS NULL, 'None', d.Name) AS [Department],
	   c.Name AS [Category],
	   r.Description, 
	   FORMAT(r.OpenDate, 'dd.MM.yyyy') AS [OpenDate],
	   s.Label AS [Status],
	   u.Name AS [User]
FROM Reports AS r
LEFT OUTER JOIN Employees AS e ON r.EmployeeId = e.Id
LEFT OUTER JOIN Departments AS d ON e.DepartmentId = d.Id
LEFT OUTER JOIN Categories AS c ON r.CategoryId = c.Id
LEFT OUTER JOIN Users AS u ON r.UserId = u.Id
LEFT OUTER JOIN Status AS s ON s.Id = r.StatusId
ORDER BY e.FirstName DESC, e.LastName, d.Name, c.Name, r.Description, r.OpenDate, s.Id, u.Id