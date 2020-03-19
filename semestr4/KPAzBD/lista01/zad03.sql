SELECT a.City, COUNT(ca.CustomerID) as #Clients, COUNT(DISTINCT c.SalesPerson) as #SalesPerson FROM [SalesLT].[Address] a 
LEFT JOIN [SalesLT].[CustomerAddress] ca ON a.AddressID=ca.AddressID 
LEFT JOIN [SalesLT].[Customer] c ON ca.CustomerID=c.CustomerID
GROUP BY a.City
