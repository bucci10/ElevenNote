USE master;  
GO  
 
IF EXISTS(SELECT * from sys.databases WHERE name='SQL_LIBRARY')  
BEGIN  
    DROP DATABASE SQL_LIBRARY;  
END  