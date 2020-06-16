CREATE FUNCTION udf_CalculateTickets(@origin VARCHAR (50), @destination VARCHAR (50), @peopleCount INT)
RETURNS VARCHAR (100)
AS
BEGIN
	IF (@peopleCount <= 0)
	BEGIN
		RETURN 'Invalid people count!';
	END

	DECLARE @idFlight INT = (
		SELECT f.Id
			FROM Flights AS f
		WHERE f.Origin = @origin AND f.Destination = @destination
	);

	IF (@idFlight IS NULL)
	BEGIN
		RETURN 'Invalid flight!';
	END

	DECLARE @pricePerTicket DECIMAL (18, 2) = (
			SELECT Price FROM Tickets
			WHERE FlightId = @idFlight
	);

	DECLARE @totalPrice DECIMAL (18, 2) = @pricePerTicket * @peopleCount;
	RETURN CONCAT ('Total price ', @totalPrice)
END
