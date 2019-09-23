CREATE TABLE People (
   Id BIGINT PRIMARY KEY IDENTITY,
   [Name] NVARCHAR(MAX) NOT NULL,
   Picture VARBINARY(MAX),
   Height DECIMAL(3, 2),
   [Weight] DECIMAL,
   Gender CHAR(1) NOT NULL,
   Birthdate DATE NOT NULL,
   Biography NVARCHAR(MAX) NOT NULL
)

INSERT INTO People([Name], Picture, Height, [Weight], Gender, Birthdate, Biography) VALUES
('Petyo', NULL, 1.50, 65, 'm', '31-AUG-06', 'I am C# Developer'),
('Pesho', NULL, 1.60, 68, 'm', '12-July-1892', 'I am JS Developer'),
('Ivan', NULL, 1.80, 70, 'm', '28-April-1995', 'I am Python Developer'),
('Yordan', NULL, 1.60, 66, 'm', '19-Feb-1999', 'I am C# Developer'),
('Petq', NULL, 1.80, 65, 'f', '19-Sep-1992', 'I am C# Developer')