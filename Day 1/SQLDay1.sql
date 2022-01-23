create table DEPARTMENT 
(
deptname varchar(30) primary key, 
deptfloor int, 
deptphone int,
)


create table EMP (
empno int identity(1,1) primary key, 
empname varchar(30), 
salary float, 
deptname varchar(30) null constraint fk_EMP foreign key references
DEPARTMENT(deptname),
bossno int references EMP(empno)
)

create table ITEM (
itemname varchar(30) primary key, 
itemtype char(1), 
itemcolor varchar(20)
)

create table SALES (
salesno int identity(101,1) primary key not null, 
saleqty int, 
itemname varchar(30) constraint fk_Sales references ITEM(itemname) not null, 
deptName varchar(30)constraint fk_Sales1 references DEPARTMENT(deptName) not null
)

insert DEPARTMENT values('Management',5,34)
insert DEPARTMENT values('Books',1,81)
insert DEPARTMENT values('Clothes',2,24)
insert DEPARTMENT values('Equipment',3,57)
insert DEPARTMENT values('Furniture',4,14)
insert DEPARTMENT values('Navigation',1,41)
insert DEPARTMENT values('Recreation',2,29)
insert DEPARTMENT values('Accounting',5,35)
insert DEPARTMENT values('Purchasing',5,36)
insert DEPARTMENT values('Personnel',5,37)
insert DEPARTMENT values('Marketing',5,38)

SELECT * FROM DEPARTMENT


insert EMP values('Alice',75000,'Management',NULL)
insert EMP values('Ned',45000,'Marketing',1)
insert EMP values('Andrew',25000,'Marketing',2)
insert EMP values('Clare',22000,'Marketing',2)
insert EMP values('Todd',38000,'Accounting',1)
insert EMP values('Nancy',22000,'Accounting',5)
insert EMP values('Brier',43000,'Purchasing',1)
insert EMP values('Sarah',56000,'Purchasing',7)
insert EMP values('Sophile',35000,'Personnel',1)
insert EMP values('Sanjay',15000,'Navigation',3)
insert EMP values('Rita',15000,'Books',4)
insert EMP values('Gigi',16000,'Clothes',4)
insert EMP values('Maggie',11000,'Clothes',4)
insert EMP values('Paul',15000,'Equipment',3)
insert EMP values('James',15000,'Equipment',3)
insert EMP values('Pat',15000,'Furniture',3)
insert EMP values('Mark',15000,'Recreation',3)

SELECT * FROM EMP

Alter table DEPARTMENT
Add mgrId int constraint fk_department references EMP(empno) null

update DEPARTMENT set mgrId=1 where deptname='Management'
update DEPARTMENT set mgrId=4 where deptname='Books'
update DEPARTMENT set mgrId=4 where deptname='Clothes'
update DEPARTMENT set mgrId=3 where deptname='Equipment'
update DEPARTMENT set mgrId=3 where deptname='Furniture'
update DEPARTMENT set mgrId=3 where deptname='Navigation'
update DEPARTMENT set mgrId=4 where deptname='Recreation'
update DEPARTMENT set mgrId=5 where deptname='Accounting'
update DEPARTMENT set mgrId=7 where deptname='Purchasing'
update DEPARTMENT set mgrId=9 where deptname='Personnel'
update DEPARTMENT set mgrId=2 where deptname='Marketing'

SELECT * FROM DEPARTMENT

insert SALES values(2,'Boots-snake proof','Clothes')
insert SALES values(1,'Pith Helmet','Clothes')
insert SALES values(1,'Sextant','Navigation')
insert SALES values(3,'Hat-polar Explorer','Clothes')
insert SALES values(5,'Pith Helmet','Equipment')
insert SALES values(2,'Pocket Knife-Nile','Clothes')
insert SALES values(3,'Pocket Knife-Nile','Recreation')
insert SALES values(1,'Compass','Navigation')
insert SALES values(2,'Geo positioning system','Navigation')
insert SALES values(5,'Map Measure','Navigation')
insert SALES values(1,'Geo positioning system','Books')
insert SALES values(1,'Sextant','Books')
insert SALES values(3,'Pocket Knife-Nile','Books')
insert SALES values(1,'Pocket Knife-Nile','Navigation')
insert SALES values(1,'Pocket Knife-Nile','Equipment')
insert SALES values(1,'Sextant','Clothes')
insert SALES values(1,'','Equipment')
insert SALES values(1,'','Recreation')
insert SALES values(1,'','Furniture')
insert SALES values(1,'Pocket Knife-Nile','')
insert SALES values(1,'Exploring in 10 easy lessons','Books')
insert SALES values(1,'How to win foreign friends','')
insert SALES values(1,'Compass','')
insert SALES values(1,'Pith Helmet','')
insert SALES values(1,'Elephant Polo stick','Recreation')
insert SALES values(1,'Camel Saddle','Recreation')

SELECT * FROM SALES

insert ITEM values('Pocket Knife-Nile','E','Brown')
insert ITEM values('Pocket Knife-Avon','E','Brown')
insert ITEM values('Compass','N','')
insert ITEM values('Geo positioning system','N','')
insert ITEM values('Elephant Polo stick','R','Bamboo')
insert ITEM values('Camel Saddle','R','Brown')
insert ITEM values('Sextant','N','')
insert ITEM values('Map Measure','N','')
insert ITEM values('Boots-snake proof','C','Green')
insert ITEM values('Pith Helmet','C','Khaki')
insert ITEM values('Hat-polar Explorer','C','White')
insert ITEM values('Exploring in 10 Easy Lessons','B','')
insert ITEM values('Hammock','F','Khaki')
insert ITEM values('How to win Foreign Friends','B','')
insert ITEM values('Map case','E','Brown')
insert ITEM values('Safari Chair','F','Khaki')
insert ITEM values('Safari cooking kit','F','Khaki')
insert ITEM values('Stetson','C','Black')
insert ITEM values('Tent - 2 person','F','Khaki')
insert ITEM values('Tent -8','F','Khaki')

SELECT * FROM ITEM