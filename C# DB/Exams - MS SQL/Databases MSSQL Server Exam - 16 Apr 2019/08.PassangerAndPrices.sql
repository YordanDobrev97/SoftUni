SELECT TOP (10) 
	FirstName, LastName, t.Price 
FROM Passengers AS p
JOIN Tickets AS t ON t.PassengerId = p.Id
ORDER BY t.Price DESC, p.FirstName, p.LastName