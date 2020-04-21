use AdventureWorks2017;
SELECT p.[Name] FROM [Production].[Product] p WHERE p.[SellStartDate] > '2007-01-01'
AND p.[ProductNumber] LIKE 'FW%'