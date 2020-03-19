SELECT p.Name as ProductName, pc.Name as CategoryName FROM [SalesLT].[Product] p
JOIN [SalesLT].[ProductCategory] pc ON p.ProductCategoryID = pc.ProductCategoryID
WHERE pc.ProductCategoryID 
	IN(SELECT DISTINCT ParentProductCategoryID FROM [SalesLT].[ProductCategory])
