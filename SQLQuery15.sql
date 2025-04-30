SELECT p.PartName, SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM OrderDetail od
JOIN Part p ON od.PartID = p.PartID
GROUP BY p.PartName
ORDER BY TotalSales DESC;
