--CREATE DATABASE FamilyDb;
--USE FamilyDb;
go

--CREATE TABLE family(
--Id INT NOT NULL PRIMARY KEY,
--Name VARCHAR(30) NOT NULL,
--Parent_Name INT 
--);
GO

--INSERT INTo family(Id, Name, Parent_Name)
--VALUES
--(1,'Zaki',2),
--(2,'Ilham', Null),
--(3,'Irwan', 2),
--(4,'Arka', 3);
go
SELECT * FROM family;

SELECT Id, Name, (SELECT Name from Family WHERE Id = f1.Parent_Name) as Parent_Name 
FROM family as f1; 
go