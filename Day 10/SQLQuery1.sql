

create database dbSample28Jan22

use dbSample28Jan22

create table tblUser
(userid varchar(20) primary key,
password varchar(20),
Name varchar(20),
age int)

select * from tblUser

create proc proc_GetAllUsers
as
begin
select * from tblUser
end
