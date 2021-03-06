//Select all records from the Customers where the PostalCode column is NOT empty.
SELECT *FROM Customers WHERE POSTALCODE IS not NULL;

//Update the City column of all records in the Customers table.
UPDATE CUSTOMERS SET CITY='Oslo';
//Set the value of the City columns to 'Oslo', but only the ones where the Country column has the value "Norway".
update customers set City='oslo' where Country='Norway';
//Update the City value and the Country value.
update Customers set City = 'Oslo',Country = 'Norway' WHERE CustomerID = 32;

//Delete all the records from the Customers table where the Country value is 'Norway'.
DELETE FROM Customers WHERE Country = 'Norway';
//Delete all the records from the Customers table.
DELETE FROM CUSTOMERS;

//Use the MIN function to select the record with the smallest value of the Price column.
SELECT MIN(PRICE) FROM Products;

//Use an SQL function to select the record with the highest value of the Price column.
SELECT MAX(UnitPrice) FROM PRODUCTS;

//Use the correct function to return the number of records that have the Price value set to 18.
SELECT COUNT(*) FROM Products WHERE UnitPrice = 18;

//Use an SQL function to calculate the average price of all products.
SELECT AVG(UNITPRICE) FROM Products;
//Use an SQL function to calculate the sum of all the Price column values in the Products table.
SELECT SUM(UNITPRICE) FROM PRODUCTS;

//Select all records where the value of the City column starts with the letter "a".
SELECT * FROM CUSTOMERS WHERE CITY LIKE 'a%';
//Select all records where the value of the City column ends with the letter "a".
SELECT * FROM CUSTOMERS WHERE CITY LIKE '%a';
//Select all records where the value of the City column contains the letter "a".
SELECT *FROM CUSTOMERS WHERE city like '%a%';
//Select all records where the value of the City column starts with letter "a" and ends with the letter "b".
Select * from customers where city like 'a%b'
//Select all records where the value of the City column does NOT start with the letter "a".
Select *from Customers where city not like 'a%';

//Select all records where the second letter of the City is an "a".
Select * from customers where city like '_a%';
//Select all records where the first letter of the City is an "a" or a "c" or an "s".
select * from customers where city like '_[acs]%';
//Select all records where the first letter of the City starts with anything from an "a" to an "f".
Select * from customers where city like '[a-f]%';
//Select all records where the first letter of the City is NOT an "a" or a "c" or an "f".
select * from customers where city not like '[acf]%';

//Use the IN operator to select all the records where Country is either "Norway" or "France".
select * from customers where country in ('Norway' ,'France');
//Use the IN operator to select all the records where Country is NOT "Norway" and NOT "France".
select * from customers where Country not in ('Norway','France');

//Use the BETWEEN operator to select all the records where the value of the Price column is between 10 and 20.
SELECT *from Products where UnitPrice between 10 and 20; 
//Use the BETWEEN operator to select all the records where the value of the Price column is NOT between 10 and 20.
select * from products where UnitPrice not between 10 and 20
//Use the BETWEEN operator to select all the records where the value of the ProductName column is alphabetically between 'Geitost' and 'Pavlova'
Select * from products where ProductName between 'Geitost' and 'pavlova';

//When displaying the Customers table, make an ALIAS of the PostalCode column, the column should be called Pno instead.
select CustomerName,Address,PostalCode as Pno from customers;
//When displaying the Customers table, refer to the table as Consumers instead of Customers.
select * from Customers as Consumers;

//Insert the missing parts in the JOIN clause to join the two tables Orders and Customers, using the CustomerID field in both tables as the relationship between the two tables.
select * from orders o left join customers c on o.CustomerID=c.CustomerID;
//Choose the correct JOIN clause to select all records from the two tables where there is a match in both tables.
select * from orders o inner join customers c on o.CustomerID=c.CustomerID; 
//Choose the correct JOIN clause to select all the records from the Customers table plus all the matches in the Orders table.
select * from orders right join customers on orders.CustomerID=customers.CustomerID;

//List the number of customers in each country.
select count(customerID) customerCount,country from customers group by Country ;
//List the number of customers in each country, ordered by the country with the most customers first.
select count(customerID),country from customers group by Country order by count(customerID) desc;

//Write the correct SQL statement to create a new database called testDB.
create database testDB;
//Write the correct SQL statement to delete a database named testDB.
drop database testDB;
//Write the correct SQL statement to create a new table called Persons.
create table persons(personID int,LastName varchar(255),FirstName varchar(255),Address varchar(255),City varchar(255));
//Write the correct SQL statement to delete a table called Persons.
drop table Persons;
//Use the TRUNCATE statement to delete all data inside a table.
Truncate table Persons;
//Add a column of type DATE called Birthday.
Alter table Persons Add Birthday date;
//Delete the column Birthday from the Persons table.
Alter table Persons drop column Birthday;

select p.productName,sum(od.UnitPrice* od.quantity) kazanılantoplammiktar from [Order Details] od 
inner join products p on od.ProductID=p.ProductID
inner join orders o on od.orderID=o.OrderID group by p.productName