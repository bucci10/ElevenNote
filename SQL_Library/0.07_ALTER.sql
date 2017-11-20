USE SQL_LIBRARY

ALTER TABLE Products 
	ADD Manufacturer text

GO

ALTER TABLE	Products
	DROP COLUMN Manufacturer 
GO

ALTER TABLE Products 
	ADD UPC text
GO

ALTER TABLE Products 
	DROP UPC 
GO