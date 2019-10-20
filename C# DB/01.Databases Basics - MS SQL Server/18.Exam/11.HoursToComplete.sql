CREATE FUNCTION udf_HoursToComplete (@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT
AS
BEGIN
	DECLARE @differentTwoDate INT = (
		(DATEDIFF(hh, @StartDate , @EndDate)/24)*24
	)

	RETURN @differentTwoDate
END