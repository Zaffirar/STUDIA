MERGE [SalesLT].[OrdersToProcess] as otp USING [SalesLT].[SalesOrderHeader] as soh
ON  otp.SalesOrderId = soh.SalesOrderID
WHEN MATCHED AND soh.DueDate<CURRENT_TIMESTAMP 
	THEN UPDATE SET otp.Delayed = 1 
WHEN MATCHED AND soh.Status=5
	THEN DELETE
WHEN NOT MATCHED AND soh.Status < 5
	THEN INSERT(SalesOrderID, Delayed)
	VALUES(soh.SalesOrderID, 0);

SELECT * FROM [SalesLT].[OrdersToProcess]