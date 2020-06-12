CREATE FUNCTION ufn_CalculateFutureValue (@initialSum DECIMAL (10, 4), @yearlyRate FLOAT, @numberYear INT)
RETURNS DECIMAL (10, 4)
AS
BEGIN
	DECLARE @Value DECIMAL (10, 4);
	SET @Value = @initialSum * (POWER((1 + @yearlyRate), @numberYear));
	RETURN @Value;
END