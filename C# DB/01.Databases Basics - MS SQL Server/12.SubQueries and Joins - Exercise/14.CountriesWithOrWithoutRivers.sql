--first solution
SELECT TOP 5 c.CountryName, 
	   r.RiverName
FROM Countries AS c
	LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
	LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
	WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName

--second solution
SELECT TOP 5 c.CountryName, r.RiverName 
FROM CountriesRivers AS cr
JOIN Rivers AS r ON cr.RiverId = r.Id
RIGHT JOIN Countries AS c ON c.CountryCode = cr.CountryCode
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName ASC
SELECT TOP 5 c.CountryName, r.RiverName 
FROM CountriesRivers AS cr
JOIN Rivers AS r ON cr.RiverId = r.Id
RIGHT JOIN Countries AS c ON c.CountryCode = cr.CountryCode
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName ASC