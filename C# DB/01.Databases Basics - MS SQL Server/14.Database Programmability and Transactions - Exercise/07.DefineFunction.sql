CREATE FUNCTION ufn_IsWordComprised(@setOfLetters NVARCHAR(MAX), @word NVARCHAR(MAX)) 
RETURNS BIT
AS 
BEGIN
	DECLARE @index INT = 1;

	DECLARE @result BIT = 1;
	WHILE @index <= LEN(@word)
	BEGIN
		DECLARE @symbol NVARCHAR = SUBSTRING(@word, @index, 1);
		DECLARE @foundIndex INT = CHARINDEX(@symbol, @setOfLetters)

		IF (@foundIndex = 0)
		BEGIN
		    SET @result = 0;
		END
		SET @index = @index + 1;
	END
	RETURN @result;
END