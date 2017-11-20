USE SQL_LIBRARY;

UPDATE dbo.Products  
	SET ProductName = 'Flat Head Screwdriver'  
	WHERE ProductID = 50  
GO  

UPDATE dbo.Products
	SET Price	= 32.43
	WHERE ProductID= 2