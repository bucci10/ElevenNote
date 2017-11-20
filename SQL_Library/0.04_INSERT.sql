USE SQL_LIBRARY;

INSERT dbo.Products (ProductID, ProductName, Price, ProductDescription)  
	VALUES (1, 'Clamp', 12.48, 'Workbench clamp')  

GO

INSERT dbo.Products (ProductName, ProductID, Price, ProductDescription)  
	VALUES ('Screwdriver', 50, 3.17, 'Flat head')  
GO  

INSERT dbo.Products  
	VALUES (75, 'Tire Bar', NULL, 'Tool for changing tires.')  
GO  

INSERT Products (ProductID, ProductName, Price)  
	VALUES (3000, '3mm Bracket', .52)  
GO  

INSERT Products
	VALUES (80, 'Tire Bar', NULL, 'Tool for changing tires.')

GO