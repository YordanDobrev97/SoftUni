SELECT MIN(r.AvgSalary)
FROM 
(SELECT AVG(ds.Salary) AS [AvgSalary] 
	FROM Employees AS ds
	GROUP BY ds.DepartmentID) AS r