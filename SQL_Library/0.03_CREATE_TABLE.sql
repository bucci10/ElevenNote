USE SQL_LIBRARY

CREATE TABLE Products 
	(ProductID int primary key NOT NULL,
	ProductName nvarchar(25) NOT NULL, 
	Price money NULL,
	ProductDescription text NULL)

GO
