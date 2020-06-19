CREATE FUNCTION udf_UserTotalCommits(@username VARCHAR(MAX))
RETURNS INT
AS
BEGIN
	DECLARE @commitsUser INT = 
	(
		SELECT COUNT(c.ContributorId) 
		FROM Users AS u
		JOIN Commits AS c ON c.ContributorId = u.Id
		WHERE u.Username = @username
	)
	
	RETURN @commitsUser;
END