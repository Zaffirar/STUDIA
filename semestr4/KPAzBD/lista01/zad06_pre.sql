UPDATE [SalesLT].[SalesOrderHeader] SET status = 3, DueDate = CAST('2009-05-25' AS DATETIME)  WHERE SalesOrderID = 71774;
UPDATE [SalesLT].[SalesOrderHeader] SET status = 3, DueDate = CAST('2039-05-25' AS DATETIME) WHERE SalesOrderID = 71784;
DROP TABLE IF EXISTS [SalesLT].[OrdersToProcess];
CREATE TABLE [SalesLT].[OrdersToProcess](
	SalesOrderID INT,
	Delayed BIT
	);
SELECT * FROM [SalesLT].[SalesOrderHeader]
ORDER BY Status