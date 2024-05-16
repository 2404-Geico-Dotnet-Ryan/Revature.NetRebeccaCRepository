-- Comments in Sql not // like C# 
--but will still allow 
/* multi line comments */ 


--CREATE - DDL command
CREATE TABLE Movie1
(
	Id int,
	Title varchar(100), --be careful with text you need to limit the size at some point for users to input data you have to store
	Price numeric(12,2), -- leaves 10 digits for front and 2 after decimal point like money 
	Available bit, --closest thing to bool
	ReturnDate bigint
	--User will need to be added later
);


--  to delete a table (this does not clear data this deletes the table entirely) BE CAREFUL WHEN USING THIS 
-- Drop - this is another DDL command
--DROP TABLE Movie;

--Adding in some new data  (one means true is available
-- Insert is -DML
INSERT INTO dbo.Movie1 VALUES (1,'Iron Man', 5,1,0);
INSERT INTO dbo.Movie1 VALUES (2,'The Avengers', 4.5,1,0);
INSERT INTO dbo.Movie1 VALUES (3,'Winter Solider',3.99,1,0);
INSERT INTO dbo.Movie1 VALUES (4,'Ant Man',4.25,1,0);
INSERT INTO dbo.Movie1 VALUES (5,'The Grinch', 3.25,1,0);
INSERT INTO dbo.Movie1 VALUES (6,'Bad Teacher',1.99,1,0);
INSERT INTO dbo.Movie1 VALUES (7,'Wolverine',4.50,1,0);
INSERT INTO dbo.Movie1 VALUES 
(8,'Madea',1.50,1,0),
(9,'Office Space',2.50,1,0);
INSERT INTO dbo.Movie1 VALUES(9,'Office Space',2.50,1,0);
INSERT INTO dbo.Movie1 VALUES 
(10,'Black Widow',7.00,1,0),
(11,'Black Panther',4.50,1,0),
(12,'Thor',7.00,1,0),
(13,'Iron Man 2',4.50,1,0);


--viewing information 
-- Select - DQL
Select* FROM Movie1;
Select Title from Movie1;
Select ID, Title, Price from Movie1;

--Update -DML
Update Movie1 SET Available=1; -- update all movies because Id was not part of the command
Update Movie1 SET Available=0 -- update only one movie
	where id ='4'; 

--Delete - DML
Delete from Movie1; -- this will affect all movies
Delete from Movie1  -- update only one movie
	where id ='9'; 
--WHERE clause -> allows us to pick and chose which records we want to apply the statement to.
-- uses a Predicate : field = value

--Select 
Select * from Movie1 where Price=5.00;
Select * from Movie1 where Price>=5.00;
Select * from Movie1 where Available = 0;

--Update
Update Movie1 SET Price=6.00 -- update only one movie
	where id ='4'; 
Update Movie1 SET Price=7.00 -- update only one movie
	where Title ='Bad Teacher'; 

--Delete 
Delete from Movie1  -- Delete only one movie
	where id ='9';

Select* FROM dbo.Movie1; -- just bringing this down it is a duplicate but helps with not scrolling for it to find it 
-- Other predicates for our WHERE clause 

Select * from Movie1 Where Title = 'Iron Man';
Select * from Movie1 Where Title Like 'Iron Man%';-- this syntax allows for anything with Iron man with anything after it will be included 
Select * from Movie1 Where Title Like 'Black%'; -- same 
Select * from Movie1 Where Title Like '%Man'; -- anything that ends with Man
Select * from Movie1 Where Title Like '%a%'; -- anything in front of the a or after the a returns -- this is not case sensitive

Select Lower(title) as LowerName from Movie1 where Title like '%a%';
Select Upper(title) as UpperName from Movie1 where Title like '%a%';
-- Lower() and Upper() are scalar Functions 
-- Function that accepts 1 input (record) and produces 1 output
-- These do NOT update the actual data just returns in a different format
-- adding as UpperName or as Lower gives the out put a column title (AKA alias for what the output is) Select Statements do not affect data just return what is asked for 
-- lower, upper, round, mod, etc - there are a ton of functions that can be used
Select Round (price, 0) from Movie1;

--Aggregate Functions
--They will calculate some value (1 output) using multiple records (many inputs) 
-- Avg, Max, Min, Sum, Count
Select Max(Price) from Movie1; -- returns only the highest price not the movie as a whole
Select Min(Price) from Movie1;
Select Round(Avg (Price), 2) from Movie1; -- rounds the average to 2 digits
Select Sum(Price) from Movie1 where Available = 0;

Select Count(Title) From Movie1; --this counts the number of records that are not null in the title field
-- Update Movie Set Title = Null where Title = 'Thor';
Select Count(*) from Movie1; -- Counts all records that are not completely null in every field


--Group by - is used with aggregate functions to break records into values of that catagory - group/buckets
Select Available, Count(*) as NumberOfMovies,Sum(Price) as TotalPrice from Movie1 Group By Available;-- the only columns that can be added are those that are included in the Group By or the Function Sum(Price) 

Select Count(*) as NumberOfMovies, Price from Movie1 Group By Price;
Select Count(*) as NumberOfMovies, Price from Movie1 where Price >= 5 Group By Price;
Select Count(*) as NumberOfMovies, Price from Movie1 where Id >=3 Group By Price;
-- you can group while using only specific data from the Movie records (this is where statement) 

Select Available, Sum(Price) as TotalOfPricesLessThanOrEqualto5 from Movie1 where Price <= 5 Group By Available;
--HAVING Clause is rarely used and no need to know other than that it exists
Select Count(*) as NumberOfMovies, Price from Movie1 Group By Price Having Count(*) >=2;

--Order By clause
-- this changes the way in which the view/cursor is displayed/returned. It does not filter records, just organizes them in the return. Does not affect their order in reference to how it is stored in the database

Select * From Movie1 Order BY Price; -- list in ascending order by default (lowest to highest)
Select * From Movie1 Order By Price DESC; -- reverses order to highest to lowest number 
--ASC is also available but since that is the default order do not use this often unless trying to be explict about the order it will be in 

Select * from Movie1 Order by Available, Price, Title; -- can order by multiple fields 

-- study safe sort - perserves order in case of a tie in sorting - this did not work for him while going over it


--Challenge 
--of available movies, get me the top 2 cheapest rentals

Select Top 2* From Movie1
	where Available = 1 
	Order by Price ASC
--Bonus Self Study --subqueries 
--[12:57 PM] Ryan Schlientz
--Sample challenge to test yourself on Subqueries:
--Get me the movie with the lowest price. (WITHOUT using TOP 1)
--OR
--Get me the Movies that share a price with 1 or more other movies.

Select * from Movie1
	where Price = (select Min(Price) from Movie1);


--this one had to use google a little

Select * from Movie1
 Where Price in (select Price from Movie1 Group by Price having count(price) >=2);



