CREATE PROC usp_GetEmployeesFromTown (@Town NVARCHAR(50))
AS
BEGIN
	SELECT e.FirstName,
		   e.LastName
	FROM Employees As e
	JOIN Addresses AS a ON e.AddressID = a.AddressID
	JOIN Towns AS d ON a.TownID = d.TownID
	WHERE d.[Name] = @Town
END

EXEC usp_GetEmployeesFromTown 'Sofia'