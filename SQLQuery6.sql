SELECT P.PartName, S.SupplierName 
FROM Part P 
JOIN PartSupplier PS ON P.PartID = PS.PartID 
JOIN Supplier S ON PS.SupplierID = S.SupplierID;