CREATE PROC usp_FindByExtension(@extension VARCHAR (20))
AS
BEGIN
	SELECT Id, Name, CONCAT(Size, 'KB') AS [Size] 
	FROM Files
	WHERE Name LIKE '%' + @extension
	ORDER BY Id, Name, [Size] DESC
END