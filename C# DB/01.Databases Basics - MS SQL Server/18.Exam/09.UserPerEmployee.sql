SELECT CONCAT(e.FirstName, ' ', e.LastName) AS [Full Name], 
		COUNT(u.Id) AS [UsersCount]
FROM Employees AS e
LEFT JOIN Reports As r ON r.EmployeeId = e.Id
LEFT JOIN Users AS u ON r.UserId = u.Id
GROUP BY e.Id, CONCAT(e.FirstName, ' ', e.LastName)
ORDER BY [UsersCount] DESC, [Full Name]