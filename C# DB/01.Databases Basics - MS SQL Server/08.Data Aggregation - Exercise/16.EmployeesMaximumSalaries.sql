SELECT DepartmentID, 
MAX(Salary) AS [Max Salary] 
FROM Employees AS e
GROUP BY e.DepartmentID
HAVING MAX(e.Salary) NOT BETWEEN 30000 AND 70000