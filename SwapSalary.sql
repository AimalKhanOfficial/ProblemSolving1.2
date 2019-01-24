--Accepted
--Runtime: 331 ms, faster than 23.38% of MySQL online submissions for Swap Salary.

--create table salary(id int, name varchar(100), sex char(1), salary int)
--Truncate table salary
--insert into salary (id, name, sex, salary) values ('1', 'A', 'm', '2500')
--insert into salary (id, name, sex, salary) values ('2', 'B', 'f', '1500')
--insert into salary (id, name, sex, salary) values ('3', 'C', 'm', '5500')
--insert into salary (id, name, sex, salary) values ('4', 'D', 'f', '500')
update salary 
set sex = (case when sex = 'f' then 'm' when sex = 'm' then 'f' end)