--Accepted
--Runtime: 1121 ms, faster than 49.43% of MS SQL Server online submissions for Department Top Three Salaries.

--Create table Employee (Id int, Name varchar(255), Salary int, DepartmentId int)
--Create table Department (Id int, Name varchar(255))
--Truncate table Employee
--insert into Employee (Id, Name, Salary, DepartmentId) values ('1', 'Joe', '70000', '1')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('2', 'Henry', '80000', '2')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('3', 'Sam', '60000', '2')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('4', 'Max', '90000', '1')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('5', 'Janet', '69000', '1')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('6', 'Randy', '85000', '1')
--Truncate table Department
--insert into Department (Id, Name) values ('1', 'IT')
--insert into Department (Id, Name) values ('2', 'Sales')

--Second Scenario:
--insert into Employee (Id, Name, Salary, DepartmentId) values ('1', 'Joe', '60000', '1')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('2', 'Ralph', '50000', '1')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('3', 'Joel', '60000', '1')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('4', 'Tracy', '75000', '1')

select Department, Employee, Salary from (
	select 
		dept.name as Department, 
		emp.Name as Employee, 
		Salary, 
		dense_rank() over (partition by departmentId order by salary desc) as 'SalaryOrder' 
	from 
		Employee emp join department dept
	on 
		emp.DepartmentId = dept.id
) as subQueryResults where SalaryOrder in ('1', '2', '3')
