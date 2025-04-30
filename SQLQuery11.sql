SELECT TOP 3 s.SupplierName, COUNT(sd.PartID) AS TotalDeliveries
FROM SuppliersDelivery sd
JOIN Supplier s ON sd.SupplierID = s.SupplierID
GROUP BY s.SupplierName
ORDER BY TotalDeliveries DESC;
