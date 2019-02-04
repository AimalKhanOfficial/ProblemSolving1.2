--Accepted
--Runtime: 1709 ms, faster than 73.98% of MySQL online submissions for Big Countries.

--use ExampleDb
--Create table World (name varchar(255), continent varchar(255), area int, population int, gdp BIGINT)
--Truncate table World
--insert into World (name, continent, area, population, gdp) values ('Afghanistan', 'Asia', '652230', '25500100', '20343000000')
--insert into World (name, continent, area, population, gdp) values ('Albania', 'Europe', '28748', '2831741', '12960000000')
--insert into World (name, continent, area, population, gdp) values ('Algeria', 'Africa', '2381741', '37100000', '188681000000')
--insert into World (name, continent, area, population, gdp) values ('Andorra', 'Europe', '468', '78115', '3712000000')
--insert into World (name, continent, area, population, gdp) values ('Angola', 'Africa', '1246700', '20609294', '100990000000')

SELECT name, population, area FROM World where population > 25000000 OR area > 3000000