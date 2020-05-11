CREATE TABLE Employees (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	FirstName NVARCHAR (30) NOT NULL,
	LastName NVARCHAR (30) NOT NULL,
	Title NVARCHAR (30),
	Notes NVARCHAR (50)
)

CREATE TABLE Customers (
	AccountNumber INT PRIMARY KEY NOT NULL IDENTITY,
	FirstName NVARCHAR (30) NOT NULL,
	LastName NVARCHAR (30) NOT NULL,
	PhoneNumber NVARCHAR (15) NOT NULL,
	EmergencyName NVARCHAR (30),
	EmergencyNumber NVARCHAR (30),
	Notes NVARCHAR (50)
)

CREATE TABLE RoomStatus (
	RoomStatus NVARCHAR (30) PRIMARY KEY NOT NULL,
	Notes NVARCHAR (50)
)

CREATE TABLE RoomTypes (
	RoomType NVARCHAR (30) PRIMARY KEY NOT NULL,
	Notes NVARCHAR (50)
)

CREATE TABLE BedTypes (
	BedType NVARCHAR (30) PRIMARY KEY NOT NULL,
	Notes NVARCHAR (50)
)

CREATE TABLE Rooms (
	RoomNumber INT PRIMARY KEY IDENTITY,
	RoomType NVARCHAR (30) FOREIGN KEY REFERENCES RoomTypes (RoomType),
	BedType NVARCHAR (30) FOREIGN KEY REFERENCES BedTypes (BedType),
	Rate DECIMAL (3, 2) NOT NULL,
	RoomStatus NVARCHAR (30) FOREIGN KEY REFERENCES RoomStatus (RoomStatus),
	Notes NVARCHAR (50)
)

CREATE TABLE Payments (
  Id INT PRIMARY KEY IDENTITY,
  EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
  PaymentDate DATE NOT NULL,
  AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
  FirstDateOccupied DATE NOT NULL,
  LastDateOccupied DATE NOT NULL,
  TotalDays INT NOT NULL,
  AmountCharged DECIMAL(15, 2) NOT NULL,
  TaxRate DECIMAL(4, 2) NOT NULL,
  TaxAmount DECIMAL(15, 2) NOT NULL,
  PaymentTotal DECIMAL(15, 2) NOT NULL,
  Notes NVARCHAR(50)
)

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees (Id),
	DateOccupied DATE  NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers (AccountNumber),
	RoomNumber INT FOREIGN KEY REFERENCES Rooms (RoomNumber),
	RateApplied DECIMAL (4, 2),
	PhoneCharge DECIMAL (5, 2),
	Notes NVARCHAR (50)
)

INSERT INTO Employees (FirstName, LastName, Title) VALUES
('Pesho', 'Petrov', 'something'),
('Kiro', 'Ivanov', 'other something'),
('Mimi', 'Petrova', '...')

INSERT INTO Customers (FirstName, LastName, PhoneNumber) VALUES
('Pesho', 'Petrov', 2023),
('Kiro', 'Ivanov', 231),
('Mimi', 'Petrova', 3219)

INSERT INTO RoomStatus (RoomStatus) VALUES
(1),
(2),
(3)

INSERT INTO RoomTypes (RoomType) VALUES
('small'),
('studio'),
('penthouse')

INSERT INTO BedTypes (BedType) VALUES
('small'),
('large'),
('2 bed')

INSERT INTO Rooms (BedType, RoomStatus, RoomType, Rate) VALUES
('small', 1, 'penthouse', 2.20),
('large', 2, 'studio', 3.40),
('large', 3, 'studio', 5.90)

INSERT INTO Payments(EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, 
LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes) VALUES
(1, '2018-06-30', 1, '2018-03-10', '2018-03-11', 3, 315, 95.5, 127, 668, 'Too expensive'),
(2, '2019-06-30', 2, '2019-03-10', '2019-03-12', 4, 215, 90.5, 107, 550, 'Better price'),
(3, '2017-06-30', 3, '2019-03-10', '2019-03-10', 5, 115, 70.5, 87, 338, 'Perfect price')

INSERT INTO Occupancies (DateOccupied, EmployeeId, RoomNumber) VALUES
('2012-08-28', 1, 1),
('2020-01-31', 2, 2),
('2001-02-24', 3, 3)