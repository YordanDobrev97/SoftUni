SELECT CONCAT(s.FirstName, ' ', s.LastName) AS [Full Name] 
FROM Students AS s
LEFT JOIN StudentsExams AS se ON se.StudentId = s.Id
LEFT JOIN Exams AS e ON se.ExamId = e.Id
WHERE se.ExamId IS NULL
ORDER BY [Full Name]