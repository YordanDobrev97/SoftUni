CREATE PROC usp_GetEmployeesSalaryAboveNumber (@MaxSalary DECIMAL(18,4))
AS
BEGIN
	SELECT c.FirstName,
		   c.LastName
	FROM Employees AS c
	WHERE c.Salary >= @MaxSalary
END

EXEC usp_GetEmployeesSalaryAboveNumber 48100