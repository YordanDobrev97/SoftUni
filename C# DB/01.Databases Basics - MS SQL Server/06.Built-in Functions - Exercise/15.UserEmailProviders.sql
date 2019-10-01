SELECT [UserName], 
SUBSTRING([Email], CHARINDEX('@', [Email], 1) + 1, 
LEN(Email) - CHARINDEX('@', [Email], 2) + 1) AS [Email]
FROM Users
ORDER BY Email, Username