CREATE FUNCTION udf_UserTotalCommits (@username NVARCHAR(MAX))
RETURNS INT
AS
BEGIN
	DECLARE @totalCount INT = (
		SELECT COUNT(u.Id) AS [Count] FROM Users AS u
		JOIN Commits AS c ON c.ContributorId = u.Id
		WHERE u.Username = @username
	)

	RETURN @totalCount
END