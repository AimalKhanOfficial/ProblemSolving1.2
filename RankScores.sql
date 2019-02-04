--Accepted
--Runtime: 1331 ms, faster than 34.46% of MS SQL Server online submissions for Rank Scores.

--Create table Scores (Id int, Score DECIMAL(3,2))
--Truncate table Scores
--insert into Scores (Id, Score) values ('1', '3.5')
--insert into Scores (Id, Score) values ('2', '3.65')
--insert into Scores (Id, Score) values ('3', '4.0')
--insert into Scores (Id, Score) values ('4', '3.85')
--insert into Scores (Id, Score) values ('5', '4.0')
--insert into Scores (Id, Score) values ('6', '3.65')

SELECT 
	SCORE AS Score,
	DENSE_RANK() OVER(ORDER BY SCORE DESC) AS Rank
FROM
	SCORES
