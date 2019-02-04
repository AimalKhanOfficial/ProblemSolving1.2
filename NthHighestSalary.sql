--Accepted
--Runtime: 851 ms, faster than 13.06% of MS SQL Server online submissions for Nth Highest Salary.

--use ExampleDb
--create table Employee (Id int not null, Salary int)
--insert into Employee values (1, 100), (2, 100)


--ALTER FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
--BEGIN
--    RETURN (
--        /* Write your T-SQL query statement below. */
--        select Salary from (select row_number() over (order by Salary DESC) rn, Salary from (select distinct Salary from Employee) y) x where rn = @N 
--    );
--END

--TRUNCATE TABLE Employee
SELECT [DBO].[getNthHighestSalary](2) as getNthHighestSalary