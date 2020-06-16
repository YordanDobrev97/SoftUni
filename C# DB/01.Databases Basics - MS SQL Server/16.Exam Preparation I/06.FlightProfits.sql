SELECT f.Id AS [FlightId], SUM(t.Price) AS [Price]
FROM Flights AS f
JOIN Tickets AS t ON t.FlightId = f.Id
GROUP BY f.Id
ORDER BY Price DESC, f.Id