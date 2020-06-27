SELECT mj.Available FROM
	(SELECT 
		j.MechanicId,
		CONCAT(m.FirstName, ' ', m.LastName) AS [Available]
		FROM Mechanics AS m
		LEFT JOIN Jobs AS j ON m.MechanicId = j.MechanicId
		WHERE j.Status = 'Finished'
		GROUP BY m.FirstName, m.LastName, j.MechanicId
	) AS [mj]
ORDER BY mj.MechanicId