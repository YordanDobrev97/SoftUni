CREATE TABLE People (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX),
	Height DECIMAL(3, 2),
	[Weight] DECIMAL (3, 2),
	Gender CHAR(1) NOT NULL,
	Birthdate DATETIME NOT NULL,
	Biography NVARCHAR(MAX),

	CHECK (Gender = 'm' OR Gender = 'f'),
	CHECK (DATALENGTH(Picture) <= 2097152)
)

INSERT INTO People ([Name], Gender, Birthdate) VALUES
('Pesho', 'm', '10-May-2020'),
('Penka', 'f', '12-Jan-1990'),
('Gosho', 'm', '12-Feb-2004'),
('Ivo', 'm', '19-Feb-1999'),
('Pencho', 'm', '24-Jan-2000')