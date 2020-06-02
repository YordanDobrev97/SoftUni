SELECT [FirstName] 
FROM Employees
WHERE DepartmentID IN (3,10) AND
CAST(DATEPART(year, HireDate) AS INT) 
BETWEEN 1995 AND 2005

--SELECT FirstName FROM Employees
--WHERE DepartmentID IN (3, 10) AND (YEAR(HireDate) BETWEEN 1995 AND 2005)