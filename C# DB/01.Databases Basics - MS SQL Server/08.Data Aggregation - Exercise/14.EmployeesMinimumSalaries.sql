SELECT e.DepartmentID, 
MIN(Salary) AS [TotalSalary] 
FROM Employees AS e
WHERE e.DepartmentID IN (2,5,7) AND HireDate > '01/01/2000'
GROUP BY e.DepartmentID
ORDER BY e.DepartmentID