USE TelerikAcademy
--01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.--
----Use a nested SELECT statement.----
SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary = 
	(SELECT MIN(em.Salary) 
	FROM Employees em)

--02.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10%-- 
--higher than the minimal salary for the company.--	
SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary <=
	(SELECT MIN(Salary) * 1.1
	FROM Employees em)

--03.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.--
----Use a nested SELECT statement.----
SELECT e.FirstName + e.LastName AS [FullName], e.Salary, d.Name
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID 
	AND e.Salary = 
	(SELECT MIN(em.Salary) 
	FROM Employees em 
	WHERE e.DepartmentID = em.DepartmentID)

--04.Write a SQL query to find the average salary in the department #1.--
SELECT AVG(Salary) AS [Average salary in the department #1] FROM Employees WHERE DepartmentID = 1

--05.Write a SQL query to find the average salary in the "Sales" department.--
SELECT AVG(e.Salary) AS [Average Salary]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

--06.Write a SQL query to find the number of employees in the "Sales" department.--
SELECT COUNT(*) AS [Emploees in Sales Department]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

--07.Write a SQL query to find the number of all employees that have manager.--
SELECT COUNT(ManagerID) AS [Emploees with manager]
FROM Employees

--08.Write a SQL query to find the number of all employees that have no manager.--
SELECT COUNT(*) - COUNT(ManagerID) AS [Emploees without manager]
FROM Employees

--09.Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name AS [Department NAme], AVG(e.Salary) AS [Average Salary]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name

--10.Write a SQL query to find the count of all employees in each department and for each town--
SELECT d.Name AS [Department Name], t.Name AS [Town Name], COUNT(a.TownID) AS [Number of Emploees in Deparment from town]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
	GROUP BY d.Name, t.Name
	ORDER BY d.Name

--11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.--
SELECT m.FirstName AS [Manager FirstName], m.LastName AS [Manager LastName], COUNT(e.EmployeeID) AS [Emploees Number]
	FROM Employees e
	JOIN Employees m
		ON e.ManagerID  = m.EmployeeID
		GROUP BY m.FirstName, m.LastName
		HAVING COUNT(e.EmployeeID) = 5

--12.Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".--
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS [Emploeey Fullname],
		CONCAT(ISNULL(m.FirstName, ''), ISNULL(m.LastName, 'No Manager')) AS [Manager Fullname]
	FROM Employees e
	LEFT OUTER JOIN Employees m
		ON e.ManagerID = m.EmployeeID

--13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.--
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

--14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
----Search in Google to find how to format dates in SQL Server.
SELECT FORMAT(GETDATE(), 'dd.MM.yyyy hh:mm:ss:fff') AS [Current Date]

--15.Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.--
CREATE TABLE Users
(Id int IDENTITY,
Username nvarchar(100) NOT NULL UNIQUE,
[Password] nvarchar(512),
Fullname nvarchar(100),
LastLiginTime DATETIME,
CONSTRAINT PK_Users PRIMARY KEY(Id))

--DROP TABLE Users

--16.Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
----Test if the view works correctly

CREATE VIEW [UsersLoginToday] AS
SELECT * FROM Users 
WHERE LastLiginTime >= DATEADD(day,DATEDIFF(day,1,GETDATE()),0)
	AND LastLiginTime < DATEADD(day,DATEDIFF(day,0,GETDATE()),0)

--SELECT DATEADD(day,DATEDIFF(day,1,GETDATE()),0) AS  [Yesterday]

--17.Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
----Define primary key and identity column.

CREATE TABLE Groups(
	Id int IDENTITY PRIMARY KEY,
	Name nvarchar(100) NOT NULL UNIQUE)

--18.Write a SQL statement to add a column GroupID to the table Users.--
----Fill some data in this new column and as well in the `Groups table.----
----Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.----

ALTER TABLE Users
ADD GroupId int

ALTER TABLE Users
	ADD CONSTRAINT FK_Users_Groups
	FOREIGN KEY (GroupId)
	REFERENCES Groups(Id)

--19.Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups VALUES 
('Groupe 1'),
('Groupe 2'),
('Groupe 3'),
('Groupe 4'),
('Groupe 5'),
('Groupe 6'),
('Groupe 7'),
('Groupe 8')

INSERT INTO Users(Username, [Password], Fullname, LastLiginTime, GroupId) VALUES
    ('Username1', 'password1', '', GETDATE(), 2),
    ('Username2', 'password2', '', GETDATE(), 2),
    ('Username3', 'password3', '', GETDATE(), 2),
    ('Username4', 'password4', '', GETDATE(), 3),
    ('Username5', 'password5', '', GETDATE(), 3),
    ('Username6', 'password6', '', GETDATE(), 4),
    ('Username7', 'password7', '', GETDATE(), 1),
    ('Username8', 'password8', '', GETDATE(), 1),
    ('Username9', 'password9', '', GETDATE(), 3)

--20. Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Users SET Username = (Username + CAST((SUBSTRING(Username, 3, 1) + 'asd') AS nvarchar(10)))
		WHERE GroupId % 2 = 0

--21.Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Users WHERE GroupId = 1

DELETE FROM Groups WHERE Id = 14

--22.Write SQL statements to insert in the Users table the names of all employees from the Employees table.--
----Combine the first and last names as a full name.----
----For username use the first letter of the first name + the last name (in lowercase).----
----Use the same for the password, and NULL for last login time.----

INSERT INTO Users(Fullname, Username, [Password])
	SELECT e.FirstName + ' ' + e.LastName,  LOWER(SUBSTRING(e.FirstName, 1, 1) + e.LastName), LOWER(SUBSTRING(e.FirstName, 1, 1) + e.LastName)
	FROM Employees e
	WHERE LEN(LOWER(SUBSTRING(e.FirstName, 0, 1) + e.LastName)) > 5
	ORDER BY LOWER(SUBSTRING(e.FirstName, 0, 1) + e.LastName)

--23.Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.--

INSERT INTO Users VALUES
    ('UsernameX', 'passwordX', '', '2009-03-16', 2)

UPDATE Users
SET Password = NULL
WHERE LastLiginTime <= '2010-03-10'

--24.Write a SQL statement that deletes all users without passwords (NULL password).--

DELETE
FROM Users
WHERE [Password] IS NULL

--25.Write a SQL query to display the average employee salary by department and job title.--

SELECT d.Name AS [Department Name],e.JobTitle AS [Job Title], AVG(e.Salary)
	FROM Employees e
		JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
		GROUP BY d.Name, e.JobTitle
		ORDER BY d.Name, e.JobTitle, AVG(e.Salary)

--26.Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.--

SELECT d.Name AS [Department Name],
		e.JobTitle AS [Job Title],
		 MIN(e.Salary) AS [Minimal employee salary by department and job title],
		 MAX(e.FirstName) AS [Employee Name]
	FROM Employees e
		JOIN Departments d
		ON d.DepartmentID = e.DepartmentID
		GROUP BY d.Name, e.JobTitle

--27.Write a SQL query to display the town where maximal number of employees work.--

SELECT TOP 1 t.Name AS [The town with maximal number of emploees],
		COUNT(t.Name) AS [Number of employeees]
	FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID
	GROUP BY t.Name
	ORDER BY COUNT(t.Name) DESC

--28.Write a SQL query to display the number of managers from each town.--

SELECT t.Name AS [Town Name],
		COUNT(*) AS [Number of managers]
	FROM Employees m
	JOIN Addresses a
	ON m.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID
	WHERE m.EmployeeID IN (SELECT e.ManagerID FROM Employees e)
	GROUP BY t.Name
	ORDER BY COUNT(t.Name) DESC

--30.Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.--
----At the end rollback the transaction.--

BEGIN TRAN

	ALTER TABLE Departments NOCHECK CONSTRAINT FK_Departments_Employees

	GO

    DELETE FROM Employees
        WHERE DepartmentID IN (SELECT d.DepartmentID FROM Departments d WHERE d.Name = 'Sales')

	GO

	ALTER TABLE Departments CHECK CONSTRAINT FK_Departments_Employees

ROLLBACK TRAN

--31.Start a database transaction and drop the table EmployeesProjects.--
----Now how you could restore back the lost table data?--
BEGIN TRANSACTION

    DROP TABLE EmployeesProjects

ROLLBACK TRANSACTION

--32.Find how to use temporary tables in SQL Server.--
----Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.--

BEGIN TRANSACTION

    SELECT * 
        INTO #Temp
        FROM EmployeesProjects

    DROP TABLE EmployeesProjects

    SELECT * 
        INTO EmployeesProjects
        FROM #Temp

    DROP TABLE #Temp

ROLLBACK TRANSACTION