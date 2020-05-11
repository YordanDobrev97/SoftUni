CREATE TABLE Users (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY,
	LastLoginTime DATETIME,
	IsDeleted BIT,

	CHECK (DATALENGTH(ProfilePicture) <= 900000)
)

INSERT INTO Users (Username, Password, IsDeleted) VALUES
('Pesho', 'password1', 0),
('Pencho', '123', 1),
('Penka', '321', 0),
('Kiro', 'perfect', 0),
('Anna', '123456', 0)