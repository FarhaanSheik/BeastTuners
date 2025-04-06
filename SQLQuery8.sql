SELECT O.OrderID, P.PartName, OD.Quantity 
FROM OrderResult O
JOIN OrderDetail OD ON O.OrderID = OD.OrderID 
JOIN Part P ON OD.PartID = P.PartID;
