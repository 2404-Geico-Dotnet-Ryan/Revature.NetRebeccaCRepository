-- Comments in Sql not // like C# 
--but will still allow 
/* multi line comments */ 


--CREATE - DDL command
CREATE TABLE Movie 
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
INSERT INTO dbo.Movie VALUES (1,'Iron Man', 5,1,0);
INSERT INTO dbo.Movie VALUES (2,'The Avengers', 4.5,1,0);
INSERT INTO dbo.Movie VALUES (3,'Winter Solider',3.99,1,0);
INSERT INTO dbo.Movie VALUES (4,'Ant Man',4.25,1,0);

--viewing information 
-- Select - DQL
Select* FROM Movie;