CREATE TABLE Categories (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	CategoryName NVARCHAR(30),
	DailyRate DECIMAL,
	WeeklyRate DECIMAL,
	MonthlyRate DECIMAL,
	WeekendRate DECIMAL
)

CREATE TABLE Cars (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	PlateNumber INT,
	Manufacturer NVARCHAR(30),
	Model NVARCHAR(30),
	CarYear INT,
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories (Id),
	Doors TINYINT,
	Picture VARBINARY (MAX),
	Condition NVARCHAR,
	Available BIT
)

CREATE TABLE Employees (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	FirstName NVARCHAR (30),
	LastName NVARCHAR (30),
	Title NVARCHAR (30),
	Notes NVARCHAR (30)
)

CREATE TABLE Customers (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	DriverLicenceNumber INT,
	FullName NVARCHAR (50),
	[Address] NVARCHAR (30),
	City NVARCHAR (30),
	ZIPCode INT,
	Notes NVARCHAR (50)
)

CREATE TABLE RentalOrders (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees (Id),
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers (Id),
	CarId INT NOT NULL FOREIGN KEY REFERENCES Cars (Id),
	TankLevel INT,
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	StartDate DATE,
	EndDate DATE,
	TotalDays INT,
	RateApplied BIT,
	TaxRate DECIMAL,
	OrderStatus BIT,
	Notes NVARCHAR (50)
)

INSERT INTO Categories (CategoryName) VALUES
('first'),
('second'),
('third')

INSERT INTO Cars (PlateNumber, Model, CategoryId, Available) VALUES
(32323232, 'Lada', 1, 1),
(32213232, 'Audi', 2, 1),
(32332214, 'Moskvich', 3, 0)

INSERT INTO Employees (FirstName, LastName, Title) VALUES
('Pesho', 'Petrov', 'Starting...'),
('Pesho', 'Georgiev', 'more...'),
('Ani', 'Petrova', '...')

INSERT INTO Customers (Address, DriverLicenceNumber, FullName, ZIPCode) VALUES
('Sofia', 1232133, 'Pesho Petrov', NULL),
('Plovdiv', 92121, 'Pesho Georgiev', 2056),
('Varna', 351412, 'Ani Petrova', NULL)

INSERT INTO RentalOrders (EmployeeId, CarId, CustomerId, TotalDays, TankLevel) VALUES
(1, 1, 1, 123, 3),
(2, 2, 2, 20, 3),
(3, 3, 3, 100, 10)