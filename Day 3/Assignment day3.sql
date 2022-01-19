--1) Select the author firtname and last name
select au_fname 'first name', au_lname 'last name' from authors

--2) Sort the titles by the title name in descending order and print all the details
select * from titles
order by title 

--3) Print the number of titlespublished by every author
select count(title_id) 'num of titles published', au_id 'authord id'
from titleauthor 
group by au_id


--4) print the author name and title name
select concat(au_lname, ' ', au_fname) 'Author name', title 'title name'
from authors a join [titleauthor] ta
on a.au_id = ta.au_id
left join titles t on t.title_id = ta.title_id

--5) print the publisher name and the average advance for every publisher
select pub_name, avg(advance) 'Avg advance' from publishers p
left join titles t
on p.pub_id = t.pub_id
group by pub_name


--6) print the publishername, author name, title name and the sale amount(qty*price)

select pub_name, concat(au_lname,' ',au_fname)'author name', title, qty*price 'sales amount'
from titles t
left join publishers p
on t.pub_id = p.pub_id
left join titleauthor ta
on ta.title_id = t.title_id
join authors a
on a.au_id = ta.au_id
left join sales s
on s.title_id = t.title_id

--7) print the price of all that titles that have name that ends with s

select price from titles where title like '%s'

--8) print the title names that contain 'and' in it

select title from titles where title like '%and%' 

--9) print the employee name and the publisher name

select concat(fname, ' ', lname)'Employee name', pub_name 'publisher name'
from employee e join [publishers] p 
on p.pub_id = e.pub_id

--10) print the publisher name and number of employees woking in it if the publisher has more than 2 employees

select pub_name 'publisher name', count(emp_id)'number of employees'
from employee e
join publishers p
on p.pub_id = e.pub_id
group by pub_name
having count(emp_id)>2

--11) Print the author names who have published using teh publisher name 'Algodata Infosystems'

select concat(au_lname,' ',au_fname)'Author name'
from authors a join titleauthor ta
on ta.au_id = a.au_id
left join titles t
on t.title_id = ta.title_id
where t.pub_id = (select pub_id from publishers p where pub_name = 
'Algodata Infosystems')


--12) Print the employees of the publisher 'Algodata Infosystems'

select concat(lname,' ',fname)'Employee name' , pub_name
from employee e
join publishers p 
on p.pub_id = e.pub_id
where p.pub_name = 'Algodata Infosystems'


--14)Create the following tables

--Employee(id-identity starts in 100 inc by 1,
--Name,age, phone cannot be null, gender)

create table tblEmployee(

empId int identity(100,1) primary key,
empName varchar(50),
empAge int,
empPhone varchar(15) not null,
empGender varchar(10)
)

--Salary(id-identity starts at 1 increments by 100,
--Basic,HRA,DA,deductions)

create table tblSalary
(
salId int identity(1,100) primary key,
base int,
hra int,
da int, 
deductions int
)

--EmployeeSalary(transaction_number int,
--employee_id-reference Employee's Id 
--Salary_id reference Salary Id,
--Date)

create table employeeSalary
(
transNo int identity(1,1) primary key,
employee_id int references tblEmployee(empId),
salary_id int references tblSalary(salId),
tDate datetime
)

--PS - In the emeployee salary table transaction number is the primary key
--the combination of employee_id, salary_id and date should always be unique

--Add a column email-varchar(100) to the employee table

alter table tblEmployee
add email varchar(100)

--Insert few records in all the tables

insert into tblEmployee values ('Phoebe toh','26','98765432','female','phoebe123@gmail.com')
insert into tblEmployee values ('Brandon koh','23','91234567','male','brandonk@gmail.com')
insert into tblEmployee values ('Tydus','18','91122334','male','tyduskzy@gmail.com')


insert into tblSalary values (2000,200,400,100)
insert into tblSalary values (3000,300,500,200)
insert into tblSalary values (4000,400,600,300)

insert into employeeSalary values (100,1,'2022-01-19')
insert into employeeSalary values (101,101,'2022-01-19')
insert into employeeSalary values (102,201,'2022-01-19')

select * from tblEmployee
select * from tblSalary
select * from employeeSalary

--Create a procedure which will print the total salary of employee by taking the employee id and the date
--total = Basic+HRA+DA-deductions

create proc proc_TotalSalary(@empId int,@date datetime)
as 
begin
	declare
	@total float,
	@basic float,
	@hra float,
	@da float,
	@deduction float,

end

--Create a procudure which will calculate the average salary of an employee taking his ID

--Create a procedure which will catculate tax payable by employee
--total - 100000 - 0%
--100000 > total < 200000 - 5%
--200000 > total < 350000 - 6%
--total > 350000 - 7.5%

--15) Create a function that will take the basic,HRA and da returns the sum of the three

--16) Create a cursor that will pick up every employee and print his details 
--then print all the entries for his salary in the employeesalary table. 
--Also show the salary splitt up(Hint-> use the salary table)

