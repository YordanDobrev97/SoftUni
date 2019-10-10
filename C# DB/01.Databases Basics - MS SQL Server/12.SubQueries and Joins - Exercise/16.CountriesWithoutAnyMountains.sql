SELECT COUNT(c.CountryCode) 
FROM Mountains AS m
JOIN MountainsCountries AS mc ON mc.MountainId = m.Id
RIGHT JOIN Countries AS c ON mc.CountryCode = c.CountryCode
WHERE mc.MountainId IS NULL