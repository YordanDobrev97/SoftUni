SELECT p.PassportId, p.Address FROM Passengers AS p
LEFT JOIN Luggages AS lug ON lug.PassengerId = p.Id
WHERE lug.Id IS NULL
ORDER BY p.PassportId, p.Address