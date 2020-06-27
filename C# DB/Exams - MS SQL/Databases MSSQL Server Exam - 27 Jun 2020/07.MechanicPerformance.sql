SELECT md.Mechanic, md.Days FROM 
(SELECT 
    m.MechanicId AS [Id],
    CONCAT(m.FirstName, ' ', m.LastName) AS [Mechanic],
	AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)) AS [Days]
	FROM Jobs AS j
	JOIN Mechanics AS m ON j.MechanicId = m.MechanicId
	GROUP BY m.FirstName, m.LastName, m.MechanicId) AS md
ORDER BY md.Id