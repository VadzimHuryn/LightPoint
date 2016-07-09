
SELECT t1.FirstName +' '+ t1.LastName AS FIO,  t1.BusinessEntityID AS PERSON_ID, t2.BusinessEntityID AS Sales_Person_ID, t3.BusinessEntityID AS STHID FROM Person.Person t1
LEFT JOIN Sales.SalesPerson t2 on t1.BusinessEntityID = t2.BusinessEntityID
JOIN Sales.SalesTerritoryHistory t3 on t1.BusinessEntityID = t3.BusinessEntityID
WHERE t2.Bonus > 1000 AND t2.Bonus < 3600



