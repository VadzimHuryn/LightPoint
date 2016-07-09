SELECT t3.FirstName+' ' + t3.LastName AS Name, t1.CardType, t1.CardNumber FROM Sales.CreditCard t1
INNER JOIN Sales.PersonCreditCard t2 on t1.CreditCardID = t2.CreditCardID
RIGHT JOIN Person.Person t3 on t3.BusinessEntityID = t2.BusinessEntityID
WHERE CardType is NULL or CardType='Vista'
