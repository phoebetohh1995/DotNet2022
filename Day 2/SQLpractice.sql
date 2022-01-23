use Northwind

Select * from Products

select ProductName from Products
select ProductName, QuantityPerUnit from Products
select ProductName Product_Name, QuantityPerUnit Quantity_In_Every_Unit from Products

select * from Products where UnitPrice >= 15
select * from Products where UnitPrice >= 15 and UnitPrice <= 25
select * from Products where UnitPrice between 15 and 25
select * from Products where UnitPrice >= 15 and SupplierID = 17

select * from Products where SupplierID = 15 or UnitsInStock<5

select * from Products where SupplierID>5 and SupplierID<10
select * from Products where SupplierID not in (8,12,13,18)

select * from Products where ProductName = 'Ikura'

select * from Products where ProductName like '%cha%'

select * from Products where ProductName like '_an%'

select avg(unitsinstock) Average_Stock from Products

 

select avg(unitprice) Average_Price
from Products
where SupplierID in (2,6,9)

select count(SupplierId) from Products

select count (distinct SupplierId) from Products

select productName from products order by SupplierID desc

select * from products order by SupplierID, UnitsInStock


select * from Products 
where ProductName like '%e%'
order by SupplierID

select supplierid, count(productid) 'Number of products'
from products
group by SupplierID

select supplierid, count(productid) 'Number of products'
from products
where UnitsInStock >0
group by SupplierID
having count(productid) >2
order by 2

--print the avg price of product sold by every salesperson
--if the avg is greater than 3 
--where the shipcountry is france and the customer name contains
--'e' sort the result by the salesperson

select Salesperson, round(avg(unitprice),2) Average_Price 
from Invoices
where shipcountry  = 'france' and customername like '%e%'
group by Salesperson
having avg(unitprice) >3
order by Salesperson

select * from Suppliers

select SupplierId from Suppliers
where country = 'Germany'

select * from Products where SupplierID in (4,6)

select * from Products where SupplierID in (
select SupplierId from Suppliers
where Country = 'Germany'
)

select * from Products where supplierid = 
(select supplierid from suppliers
where CompanyName = 'tokyo traders')

-- select the avg units in stock of products that are supplied by
-- supplier whose region name is not null and the avg is greater than 3
-- sort the result by the average units

select * from invoices

select SupplierID, avg(UnitsInStock) Averagefrom Productswhere SupplierID in ( select SupplierID					  from Suppliers					  where Region is not null )group by SupplierIDhaving avg(UnitsInStock) > 3order by Average



select *from Productswhere CategoryID in ( select CategoryID					  from Categories					  where CategoryName like '%pro%' )and UnitsInStock > 0order by UnitPrice


select * from [Order Details]
where productId in 
(select ProductID from Products where CategoryId in
(select CategoryID from Categories where CategoryName like '%pro%')
)

select * from Products where ProductID not in
(select distinct ProductId from [Order Details])


select ProductName, od.UnitPrice,
Quantity, od.Unitprice*Quantity 'Product Price'
from Products p join [Order Details] od
on p.ProductId = od.ProductID
order by ProductName, Quantity


select ContactName 'Customer Name', CustomerId from Customers where customerID not in 
(select CustomerID from orders)

select ContactName 'Customer Name', OrderDate 'date' from customers c join Orders o
on c.CustomerID = o.customerID

select ContactName 'Customer Name', OrderDate 'date' from customers c join Orders o
on c.CustomerID = o.customerID
order by 1

select ContactName 'Customer Name', OrderDate 'date' 
from customers c left outer join Orders o
on c.CustomerID = o.customerID
order by 1

select concat(firstname, ' ', lastname) Employee_name , 
count(OrderID) 'Number orders'
from employees e join Orders o
on e.EmployeeID = o.EmployeeID
group by concat(firstname, ' ', lastname)
having count(OrderID) > 50
order by 2

select * from [Order details]

--print the orderid and the product name, customer name
--order, orderdetails, product, customer

select c.ContactName 'customer name', o.OrderID, p.ProductName,  od.UnitPrice * od.Quantity
from Customers c left outer join Orders o
on c.CustomerID = o.CustomerID
left outer join [Order Details] od on od.OrderID = o.OrderID
left outer join Products p on p.ProductID = od.ProductID


select c.ContactName 'customer name', o.OrderID, p.ProductName,  od.UnitPrice * od.Quantity
from Products p join [Order Details] od
on p.ProductID = od.ProductID
join Orders o on od.OrderID = o.OrderID
right outer join Customers c on c.CustomerID = o.CustomerID

select * from Region cross join Shippers

select * from Employees

select EmployeeId, ReportsTo
from Employees

select emp.EmployeeID 'Employee ID', emp.FirstName 'Employee name',
mgr.EmployeeID 'Manager id ', mgr.FirstName 'Manager name'
from Employees emp join Employees mgr
on emp.ReportsTo = mgr.EmployeeID

