SELECT p.Category, SUM(od.Quantity) AS TotalSold
FROM OrderDetail od
JOIN Part p ON od.PartID = p.PartID
GROUP BY p.Category
ORDER BY TotalSold DESC;
