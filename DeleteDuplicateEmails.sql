--Couldn't submit the Code because of mysql version but works! 
--Deleting Duplicate Emails 

--create table Person (Id int not null, Email varchar(255))
--insert into Person Values (1, 'john@example.com'),(2, 'bob@example.com'),(3, 'john@example.com')
select ROW_NUMBER() over (order by Id) as Id, Email from (select ROW_NUMBER() over(partition by email order by Id) as Id, Email from Person) as x where Id = 1