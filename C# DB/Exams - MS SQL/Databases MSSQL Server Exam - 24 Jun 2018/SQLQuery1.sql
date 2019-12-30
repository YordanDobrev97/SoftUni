CREATE DATABASE TripService
USE TripService

CREATE TABLE Cities (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL,
	CountryCode CHAR(2) NOT NULL
)

CREATE TABLE Hotels (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	CityId INT FOREIGN KEY REFERENCES Cities(Id) NOT NULL,
	EmployeeCount INT NOT NULL,
	BaseRate DECIMAL(15,2)
)

CREATE TABLE Rooms (
	Id INT PRIMARY KEY IDENTITY,
	Price DECIMAL(15,2) NOT NULL,
	[Type] NVARCHAR(20) NOT NULL,
	Beds INT NOT NULL,
	HotelId INT FOREIGN KEY REFERENCES Hotels(Id) NOT NULL
)

CREATE TABLE Trips (
	Id INT PRIMARY KEY IDENTITY,
	RoomId INT FOREIGN KEY REFERENCES Rooms (Id) NOT NULL,
	BookDate DATE NOT NULL,
	ArrivalDate DATE NOT NULL,
	ReturnDate DATE NOT NULL,
	CancelDate DATE,

	CHECK (BookDate < ArrivalDate),
	CHECK (ArrivalDate < ReturnDate)
)

CREATE TABLE Accounts (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	MiddleName NVARCHAR(20),
	LastName NVARCHAR(50) NOT NULL,
	CityId INT FOREIGN KEY REFERENCES Cities (Id) NOT NULL,
	BirthDate DATE NOT NULL,
	Email NVARCHAR(100) UNIQUE NOT NULL,
)

CREATE TABLE AccountsTrips (
	AccountId INT FOREIGN KEY REFERENCES Accounts (Id) NOT NULL,
	TripId INT FOREIGN KEY REFERENCES Trips (Id) NOT NULL,
	Luggage INT NOT NULL,

	CHECK (Luggage >= 0)
)

--Insert 
INSERT INTO Accounts (FirstName, MiddleName, LastName, CityId, BirthDate, Email) VALUES
('John', 'Smith', 'Smith', 34, '1975-07-21', 'j_smith@gmail.com'),
('Gosho', NULL, 'Petrov', 1, '1978-05-16', 'g_petrov@gmail.com'),
('Ivan', 'Petrovich', 'Pavlov', 59, '1849-09-26', 'i_pavlov@softuni.bg'),
('Friedrich', 'Wilhelm', 'Nietzsche', 2, '1844-10-15', 'f_nietzsche@softuni.bg')

INSERT INTO Trips (RoomId, BookDate, ArrivalDate, ReturnDate, CancelDate) VALUES
(101, '2015-04-12', '2015-04-14', '2015-04-20', '2015-02-02'),
(102, '2015-07-07', '2015-07-15', '2015-07-22', '2015-04-29'),
(103, '2013-07-17', '2013-07-23', '2013-07-24', NULL),
(104, '2012-03-17', '2012-03-31', '2012-04-01', '2012-01-10'),
(109, '2017-08-07', '2017-08-28', '2017-08-29', NULL)

--Update 3
UPDATE Rooms
SET Price += Price* 0.14
WHERE HotelId IN (5,7,9)

--Delete 4
SELECT * FROM AccountsTrips
DELETE FROM AccountsTrips
WHERE AccountId = 47

--Bulgarian Cities 5
SELECT c.Id, c.Name FROM Cities AS c
WHERE c.CountryCode = 'BG'
ORDER BY c.Name

--06. People Born After 1991
SELECT CONCAT(a.FirstName, ' ', COALESCE(a.MiddleName, ''), ' ', a.LastName) AS [Full Name],
	  CAST(DATEPART(YEAR, a.BirthDate) AS INT) AS [BirthYear]
FROM Accounts AS a
WHERE CAST(DATEPART(YEAR, a.BirthDate) AS INT) > '1991'
ORDER BY CAST(DATEPART(YEAR, a.BirthDate) AS INT) DESC, a.FirstName ASC

--07. EEE-Mails

SELECT a.FirstName, 
	   a.LastName, 
	   FORMAT(a.BirthDate, 'MM-dd-yyyy') AS [BirthDate], 
	   c.Name AS [Hometown], 
	   a.Email 
	   FROM Accounts AS a
JOIN Cities AS c ON a.CityId = c.Id
WHERE a.Email LIKE 'e%'
ORDER BY c.Name DESC

--08. City Statistics
SELECT c.Name AS [City], COUNT(h.EmployeeCount) AS [Hotels]
FROM Hotels AS h
RIGHT JOIN Cities AS c ON c.Id = h.CityId
GROUP BY c.[Name]
ORDER BY COUNT(h.EmployeeCount) DESC, c.[Name] ASC

--09. Expensive First Class Rooms
SELECT r.Id,
	   r.Price,
	   h.[Name] AS [Hotel],
	   c.[Name] AS [City],
	   r.Type
FROM Hotels AS h
JOIN Cities AS c ON h.CityId = c.Id
JOIN Rooms AS r ON r.Id = c.Id
WHERE r.[Type] = 'First Class'
ORDER BY r.Price DESC, r.Id ASC

SELECT * FROM Rooms
--10

SELECT * FROM Accounts AS a


