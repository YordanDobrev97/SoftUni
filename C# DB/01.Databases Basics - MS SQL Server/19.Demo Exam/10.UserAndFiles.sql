SELECT u.Username, AVG(f.Size) AS [Size]
FROM Users AS u
LEFT JOIN Commits AS c ON c.ContributorId = u.Id
LEFT JOIN Files AS f ON f.CommitId = c.Id
WHERE f.Name IS NOT NULL
GROUP BY u.Username
ORDER BY [Size] DESC, u.Username