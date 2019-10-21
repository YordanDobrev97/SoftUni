SELECT CONCAT(p.FirstName, ' ', p.LastName) AS [Full Name],
	   pl.Name AS [Plane Name],
	   CONCAT(f.Origin, ' - ', f.Destination) AS [Trip],
	   lt.Type AS [Luggage Type]
FROM Passengers AS p
LEFT JOIN Tickets AS t ON t.PassengerId = p.Id
LEFT JOIN Flights AS f ON t.FlightId = f.Id
LEFT JOIN Planes AS pl ON f.PlaneId = pl.Id
LEFT JOIN Luggages AS l ON l.Id = t.LuggageId
LEFT JOIN LuggageTypes AS lt ON lt.Id = l.LuggageTypeId
WHERE f.Id IS NOT NULL
ORDER BY [Full Name], pl.Name, f.Origin, f.Destination, lt.Type