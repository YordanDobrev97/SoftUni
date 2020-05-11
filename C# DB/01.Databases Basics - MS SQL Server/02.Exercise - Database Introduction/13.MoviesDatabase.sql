CREATE TABLE Directors (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	DirectorName NVARCHAR(30),
	Notes NVARCHAR(50)
)

CREATE TABLE Genres(
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	GenreName NVARCHAR(30),
	Notes NVARCHAR(50)
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	CategoryName NVARCHAR(30),
	Notes NVARCHAR(50)
)

CREATE TABLE Movies (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Title NVARCHAR(30),
	DirectorId INT FOREIGN KEY REFERENCES Directors (Id),
	CopyrightYear INT,
	[Length] INT,
	GenreId INT FOREIGN KEY REFERENCES Genres (Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories (Id),
	Rating INT,
	Notes NVARCHAR(30)
)

INSERT INTO Directors (DirectorName, Notes) VALUES
('name1', 'director description 1'),
('name2', 'director description 2'),
('name3', 'director description 3'),
('name4', 'director description 4'),
('name5', 'director description 5')

INSERT INTO Genres (GenreName, Notes) VALUES
('name1', 'genre description 1'),
('name2', 'genre description 2'),
('name3', 'genre description 3'),
('name4', 'genre description 4'),
('name5', 'genre description 5')

INSERT INTO Categories (CategoryName, Notes) VALUES
('name1', 'Category description 1'),
('name2', 'Category description 2'),
('name3', 'Category description 3'),
('name4', 'Category description 4'),
('name5', 'Category description 5')

INSERT INTO Movies (Title, CategoryId, DirectorId, GenreId, Length, CopyrightYear) VALUES
('first movie', 1, 1, 1, 60, 1990),
('second movie', 2, 2, 2, 90, 1998),
('third movie', 3, 3, 3, 120, 1999),
('fourth movie', 4, 4, 4, 60, 1980),
('fifth movie', 5, 5, 5, 160, 1970)