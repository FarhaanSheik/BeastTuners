SELECT * FROM Customer
WHERE CustomerID NOT IN (SELECT CustomerID FROM OrderResult);