SELECT p.PartName, SUM(ia.Quantity) AS TotalAdjusted
FROM InventoryAdjustment ia
JOIN Part p ON ia.PartID = p.PartID
GROUP BY p.PartName;
