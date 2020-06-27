CREATE FUNCTION udf_GetCost (@JobId INT)
RETURNS DECIMAL (22, 2)
AS
BEGIN
	DECLARE @result DECIMAL (22, 2) = 
		(
			SELECT SUM(p.Price) FROM Parts AS p
			LEFT JOIN OrderParts AS op ON op.PartId = p.PartId
			JOIN Orders AS o ON op.OrderId = o.OrderId
			WHERE o.JobId = @jobId
			GROUP BY o.JobId
		)

	IF (@result IS NULL)
		RETURN 0

	RETURN @result;
END