USE SQL_LIBRARY;

SELECT ProductID, ProductName, Price, ProductDescription  
    FROM dbo.Products  
GO  

SELECT * FROM Products  
GO  

SELECT ProductName, Price  
    FROM dbo.Products  
GO  

SELECT ProductID, ProductName, Price, ProductDescription  
    FROM dbo.Products  
    WHERE ProductID < 60  
GO  

SELECT ProductName, Price * 1.07 AS CustomerPays  
    FROM dbo.Products  
GO  