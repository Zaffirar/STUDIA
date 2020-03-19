SELECT DISTINCT a.City FROM [SalesLT].[Address] a, [SalesLT].[SalesOrderHeader] h
WHERE a.AddressID=h.ShipToAddressID
AND h.ShipDate<CURRENT_TIMESTAMP
ORDER BY City