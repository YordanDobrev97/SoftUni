SELECT t.FlightId AS [Id], SUM(t.Price) AS [Price]
FROM Flights AS f
JOIN Tickets AS t ON t.FlightId = f.Id
GROUP BY t.FlightId
ORDER BY [Price] DESC, t.FlightId