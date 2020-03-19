SELECT c.FirstName, c.LastName, SUM(sod.UnitPriceDiscount*sod.OrderQty) AS discount FROM  [SalesLT].[Customer] c 
JOIN [SalesLT].[SalesOrderHeader] soh ON c.CustomerID=soh.CustomerID
JOIN [SalesLT].[SalesOrderDetail] sod ON soh.SalesOrderID=sod.SalesOrderID
GROUP BY c.FirstName, c.LastName
