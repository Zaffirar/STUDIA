SELECT m.Name, COUNT(p.ProductID) as Number_of FROM [SalesLT].[ProductModel] m 
JOIN [SalesLT].[Product] p ON p.ProductModelID=m.ProductModelID 
GROUP BY m.Name
HAVING COUNT(p.ProductID)>1

