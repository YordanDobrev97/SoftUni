SELECT  TOP (10)
		t.FirstName,
	    t.LastName,
	    COUNT(st.StudentId) AS [StudentsCount] 
FROM Teachers AS t
JOIN StudentsTeachers AS st ON t.Id = st.TeacherId
GROUP BY st.TeacherId, t.FirstName, t.LastName
ORDER BY [StudentsCount] DESC, t.FirstName, t.LastName