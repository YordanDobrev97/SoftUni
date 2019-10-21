CREATE FUNCTION udf_CalculateTickets(@origin NVARCHAR(50), @destination NVARCHAR(50), @peopleCount INT)
RETURNS VARCHAR(100)
AS
BEGIN
	DECLARE @output VARCHAR(100)
	DECLARE @idFlight INT = (SELECT TOP(1) f.Id FROM Flights AS f
		WHERE f.Origin = @origin AND f.Destination = @destination)

	IF (@peopleCount <= 0)
	BEGIN	
	    SET @output = 'Invalid people count!'
	END
	ELSE IF (@idFlight IS NULL)
	BEGIN
		SET @output = 'Invalid flight!';
	END
	ELSE 
	BEGIN
		DECLARE @totalPrice DECIMAL(18,2) = (
			SELECT TOP(1) t.Price FROM Flights AS f
			JOIN Tickets AS t ON t.FlightId = f.Id
			WHERE t.Id = @idFlight
		)

		SET @output = CONCAT('Total price ', (@totalPrice * @peopleCount))
	END

	RETURN @output
END