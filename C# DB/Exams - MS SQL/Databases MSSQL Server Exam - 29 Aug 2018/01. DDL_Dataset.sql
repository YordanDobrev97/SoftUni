CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL
)

CREATE TABLE Items (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	Price DECIMAL(15,2) NOT NULL,
	CategoryId INT FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	SecondName NVARCHAR(50) NOT NULL,
	Phone NVARCHAR(12) NOT NULL,
	Salary DECIMAL(15,2) NOT NULL
)

CREATE TABLE Orders (
	Id INT PRIMARY KEY IDENTITY,
	[DateTime] DateTime NOT NULL,
	EmployeeId INT FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
)

CREATE TABLE OrderItems (
	OrderId INT NOT NULL FOREIGN KEY (OrderId) REFERENCES Orders(Id),
	ItemId INT NOT NULL FOREIGN KEY (ItemId) REFERENCES Items(Id),
	Quantity INT NOT NULL CONSTRAINT MIN_Quantity CHECK(Quantity >= 1)
)

CREATE TABLE Shifts (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
	CheckIn DateTime NOT NULL,
	CheckOut DateTime NOT NULL,
	CONSTRAINT AFTER_CheckIn CHECK (CheckIn < CheckOut)
)


