UPDATE Tickets 
SET Price += Price * 0.13
WHERE FlightId = (SELECT Id FROM Flights WHERE Destination = 'Carlsbad')