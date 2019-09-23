CREATE DATABASE Movies

CREATE TABLE Directors (
	Id INT PRIMARY KEY IDENTITY,
	DirectorName NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(50)
)

CREATE TABLE Genres (
	Id INT PRIMARY KEY IDENTITY,
	GenreName NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(50)
)

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(50)
)

CREATE TABLE Movies (
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(20) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors (Id),
	CopyrightYear INT NOT NULL,
	[Length] INT,
	GenreId INT FOREIGN KEY REFERENCES Genres (Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories (Id),
	Rating INT,
	Notes NVARCHAR(50)
)


INSERT INTO Directors (DirectorName) VALUES
('Test'),
('Test1'),
('Test2'),
('Test3'),
('Test4')

INSERT INTO Genres (GenreName) VALUES
('Test'),
('Test1'),
('Test2'),
('Test3'),
('Test4')

INSERT INTO Categories (CategoryName) VALUES
('Test again1'),
('Test again2'),
('Test again3'),
('Test again4'),
('Test again5')

INSERT INTO Movies (Title, DirectorId, CopyrightYear, GenreId, CategoryId) VALUES
('Test example', 1, 2002, 1, 1),
('Test example', 2, 2002, 2, 2),
('Test example', 3, 2002, 3, 3),
('Test example', 4, 2002, 4, 4),
('Test example', 5, 2002, 5, 5)

SELECT * FROM Genres
SELECT * FROM Categories
SELECT * FROM Directors