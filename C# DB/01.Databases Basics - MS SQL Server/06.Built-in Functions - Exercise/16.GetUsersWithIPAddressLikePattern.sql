SELECT [UserName], [IpAddress] FROM Users
WHERE IpAddress LIKE '___.1_%._%.___'
ORDER BY [UserName]