SELECT FirstName, LastName, DATEDIFF(DAY, HireDate, GETDATE()) AS DaysWorked
FROM Employee;