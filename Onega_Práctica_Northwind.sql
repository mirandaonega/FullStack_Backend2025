--Ejercicios de bases de datos
--1) Mostrar los clientes ordenados alfabéticamente por el nombre de la compañía.
SELECT *
FROM [Customers] c
ORDER BY c.CompanyName 

--2) Mostrar todos los clientes que su nombre empieza con "S".
SELECT *
FROM [Customers] c
WHERE c.ContactName LIKE 's%'
ORDER BY c.CompanyName

--3) Encontrar todos los productos cuyo precio unitario sea mayor a 50.
SELECT *
FROM [Products] p
WHERE p.UnitPrice > 50

--4) Obtener cuántos productos "Discontinued" hay.
SELECT COUNT(*)
FROM [Products] p
WHERE p.Discontinued = 1

--5) Obtener el producto de mayor valor unitario.
SELECT TOP 1 *
FROM [Products] p
ORDER BY p.UnitPrice desc

--6) 5) y obtener el nombre del producto (subquery).
SELECT TOP 1 p.ProductName, p.UnitPrice
FROM [Products] p
ORDER BY p.UnitPrice desc

SELECT TOP 1 p.ProductName, p.UnitPrice
FROM [Products] p
WHERE p.UnitPrice in (SELECT MAX(p2.UnitPrice) FROM [Products] p2)

--7) Obtener una lista de todos los productos con sus respectivos nombres de categoría. INNER JOIN
SELECT p.ProductName, c.CategoryName
FROM [Products] p
INNER JOIN [Categories] c ON p.CategoryID = c.CategoryID

--8) Obtener todos los clientes junto con los detalles de los pedidos que han realizado. Si un cliente no ha
-- realizado ningún pedido, aún debe aparecer en el resultado con los detalles del pedido como NULL. LEFT JOIN
SELECT C.ContactName, D.Quantity, D.UnitPrice, D.Discount
FROM Customers C
LEFT JOIN Orders O
ON C.CustomerID = O.CustomerID
LEFT JOIN [Order Details] D
ON O.OrderID = D.OrderID

--9) Encontrar el número total de órdenes realizadas por cada cliente.
SELECT C.ContactName, COUNT(O.OrderID) AS TotalOrders
FROM Customers C
LEFT JOIN Orders O
ON C.CustomerID = O.CustomerID
GROUP BY C.ContactName

--10) Encontrar los proveedores que han suministrado más de 3 productos. Primero, agrupamos los productos por
-- proveedor y contamos el número de productos suministrado por cada uno. Luego usamos HAVING para filtrar solo
-- aquellos proveedores que han suministrado más de 3 productos.
SELECT S.ContactName, COUNT(P.ProductID) AS TotalProducts
FROM Suppliers S
LEFT JOIN Products P
ON S.SupplierID = P.SupplierID
GROUP BY S.ContactName
HAVING COUNT(P.ProductID) > 3

--11) Realizar un procedimiento almacenado que devuelva los clientes según el país.
CREATE PROCEDURE CustomersByCountry
    @Country NVARCHAR(50)
AS
BEGIN
    SELECT CustomerID,
           CompanyName,
           ContactName,
           ContactTitle,
           [Address],
           City,
           Region,
           PostalCode,
           Country,
           Phone,
           Fax
    FROM Customers
    WHERE Country = @Country;
END;
GO

EXEC CustomersByCountry @Country = 'Argentina';