--SELECT P.FirstName, P.MiddleName, P.LastName, E.EmailAddress
--FROM Person.Person P 
--JOIN Person.EmailAddress E 
--  ON E.BusinessEntityID = P.BusinessEntityID

--delete dbo.Contact
--where middleName is null


--SELECT P.FirstName, P.MiddleName, P.LastName, E.EmailAddress
--FROM Person.Person P 
--JOIN Person.EmailAddress E 
--  ON E.BusinessEntityID = P.BusinessEntityID
--LEFT JOIN dbo.Contact C
--	   ON C.EmailAddress = E.EmailAddress
--WHERE C.EmailAddress IS NULL


--UPDATE dbo.Contact
--SET MiddleName = 'Ray'
--WHERE MiddleName IS NULL


--Insert Into dbo.Contact
-- (FirstName, MiddleName, LastName, EmailAddress)
--Values
-- ('Andy', 'Ray', 'Leonard', 'andy.leonard@gmail.com')


select *
from dbo.Contact
where lastname = 'Leonard'
--WHERE MiddleName IS NULL


select *
from dbo.StageUpdates

