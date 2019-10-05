SELECT * 
INTO DepartmentSalary 
FROM Employees AS s
WHERE s.Salary > 30000

DELETE 
FROM DepartmentSalary
WHERE ManagerID = 42

UPDATE DepartmentSalary
SET Salary += 5000
WHERE DepartmentID = 1


SELECT DepartmentID, AVG(Salary) AS [Average Salary] 
FROM DepartmentSalary AS dse
GROUP BY dse.DepartmentID
