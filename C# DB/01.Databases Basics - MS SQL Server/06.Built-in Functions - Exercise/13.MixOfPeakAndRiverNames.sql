SELECT p.PeakName, 
	   r.RiverName, 
CONCAT(
LOWER(
LEFT(p.PeakName, 
LEN(p.PeakName) - 1)), 
LOWER(r.RiverName)) 
AS [Mix]
FROM Peaks 
AS p, Rivers AS r
WHERE RIGHT(p.PeakName, 1) = LEFT(r.RiverName, 1)
ORDER BY Mix