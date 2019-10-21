CREATE PROC usp_GetTownsStartingWith (@StartNameTown NVARCHAR(50))
AS
BEGIN
	SELECT t.[Name]
	FROM Towns AS t
	WHERE t.[Name] LIKE (@StartNameTown) + '%'
END

EXEC usp_GetTownsStartingWith b