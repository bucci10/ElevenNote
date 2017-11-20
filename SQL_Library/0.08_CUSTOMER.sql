USE SQL_LIBRARY;

CREATE TABLE Customers
(CustomerID int primary key NOT NULL, 
LastName nvarchar(25) NOT NULL,
FirstName nvarchar(25) NOT NULL,
LastPurchase DateTime NOT NULL)

INSERT dbo.Customers (CustomerID, LastName, FirstName, LastPurchase)  
	VALUES (1, 'Tinney', 'Zach', GETUTCDATE()),
		   (2, 'Wainscott', 'Chris', GETUTCDATE()),
		   (3, 'Aikins', 'Jenn', GETUTCDATE()),
		   (4, 'OConnor', 'Paul', GETUTCDATE()),
		   (5, 'Rahimzadeh', 'Auri', GETUTCDATE())
GO