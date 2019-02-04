--Accepted 
--Runtime: 1579 ms, faster than 48.64% of MySQL online submissions for Classes More Than 5 Students.

--Create table courses (student varchar(255), class varchar(255))
--Truncate table courses
--insert into courses (student, class) values ('A', 'Math')
--insert into courses (student, class) values ('B', 'English')
--insert into courses (student, class) values ('C', 'Math')
--insert into courses (student, class) values ('D', 'Biology')
--insert into courses (student, class) values ('E', 'Math')
--insert into courses (student, class) values ('F', 'Computer')
--insert into courses (student, class) values ('G', 'Math')
--insert into courses (student, class) values ('H', 'Math')
--insert into courses (student, class) values ('I', 'Math')
--truncate table courses

--insert into courses (student, class) values ('A', 'Math'), ('B', 'English'), ('C', 'Math'), ('D', 'Biology'), ('E', 'Math'), ('F', 'Math'), ('A', 'Math')

select * from courses
Select class from (select distinct student, class from courses) x group by class having count(student) >= 5