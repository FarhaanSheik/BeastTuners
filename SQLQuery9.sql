SELECT c.FirstName, c.LastName, AVG(o.TotalAmount) AS AvgOrder
FROM Customer c
JOIN OrderResult o ON c.CustomerID = o.CustomerID
GROUP BY c.FirstName, c.LastName;
