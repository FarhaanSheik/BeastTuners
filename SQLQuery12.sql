SELECT s.SupplierName, MAX(sd.DeliveryTime) AS LastDelivery
FROM SuppliersDelivery sd
JOIN Supplier s ON sd.SupplierID = s.SupplierID
GROUP BY s.SupplierName;