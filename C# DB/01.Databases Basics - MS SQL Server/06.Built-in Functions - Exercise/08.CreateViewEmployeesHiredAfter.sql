CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT [FirstName], [LastName] FROM Employees
WHERE CAST(DATEPART(Year,HireDate) AS INT) > 2000

GO
SELECT * FROM V_EmployeesHiredAfter2000

SELECT * FROM Employees