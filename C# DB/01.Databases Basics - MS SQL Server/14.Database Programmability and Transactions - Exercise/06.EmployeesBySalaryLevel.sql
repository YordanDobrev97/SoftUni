CREATE PROC usp_EmployeesBySalaryLevel (@levelSalary VARCHAR (20))
AS
BEGIN
	SELECT FirstName,
		   LastName
	FROM Employees
	WHERE dbo.ufn_GetSalaryLevel (Salary) = @levelSalary
END