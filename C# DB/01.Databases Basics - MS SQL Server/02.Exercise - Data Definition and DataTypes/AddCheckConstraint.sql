ALTER TABLE Users
ADD CONSTRAINT LenPass CHECK (DATALENGTH([Password]) >= 5)

INSERT INTO Users (Username, [Password]) VALUES
('Mariq', '123')