SELECT 
TOP(50) [Name], FORMAT([Start], 'yyyy-MM-dd') AS [YearStart] 
FROM Games
WHERE CAST(DATEPART(YEAR,[Start]) AS INT) BETWEEN 2011 AND 2012
ORDER BY YearStart, [Name]