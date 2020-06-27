SELECT o.JobId, SUM(p.Price) AS [TotalSum] FROM Orders AS o
LEFT JOIN OrderParts AS op ON o.OrderId = op.OrderId
LEFT JOIN Parts AS p ON p.PartId = op.PartId
LEFT JOIN Jobs AS j ON o.JobId = j.JobId
GROUP BY o.JobId, j.Status
HAVING j.Status = 'Finished'
ORDER BY [TotalSum] DESC, o.JobId