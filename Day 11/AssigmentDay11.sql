create database AssignmentDay11

create table tblEmployee
(
	ID int identity(1,1) primary key,
	Name varchar(30),
	Age int
)

create proc proc_AddEmployee(@ename varchar(30), @eage int)
as
begin
	insert into tblEmployee(Name,Age) values(@ename,@eage)
end

exec proc_AddEmployee 'Alan', 20
exec proc_AddEmployee 'Bella', 21
exec proc_AddEmployee 'Casey', 22
exec proc_AddEmployee 'Dylan', 23
exec proc_AddEmployee 'Elaine', 24

create proc proc_GetAllEmployee
as
begin
	select * from tblEmployee
end

exec proc_GetAllEmployee

create proc proc_EditEmployeeAge(@eid int, @eage int)
as
begin
	update tblEmployee set Age = @eage where ID = @eid
end

exec proc_EditEmployeeAge 1, 29