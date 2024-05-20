CREATE TABLE [User]
(
	Id int Identity(1,1) Primary Key, -- identity(1,1) indicates that system will assign staring at number 1 and increment by 1 each time (this is sequence generation) - Primary key makes sure not null and is unique value
	UserName varchar(50) Unique not null, 
	[Password] varchar(50) not null,
	[Role] varchar(50) not null check(Role in ('user' , 'admin'))
);


Create Table Movie
(
	Id int Identity(1,1) Primary Key,
	Title varchar (50) Unique not null, --may want to allow duplicates so that you can have multiple copies of same movie -- add unique means the renter can only have one copy of of a particular movie title
	Price Decimal (12, 2),
	Available Bit default 1,
	ReturnDate BigInt default 0,
	UserID int,    --similiar to renter in CS named this way to not think it is a new item we are making it a foriegn key FK_
	Constraint FK_Movie_User Foreign Key (UserID) references [User](Id)
);
insert into [User] values ('Rebecca','pass1', 'admin');
insert into [User] values ('Brandon','pass1', 'user');
insert into [User] values ('Ryan','pass1', 'user');
-- if any field does not match like user or admin is not used for role SQL will not allow it to be completed 


INSERT INTO Movie VALUES ('Iron Man', 5,1,0, null);
INSERT INTO dbo.Movie VALUES ('The Avengers', 4.5,1,0, null);
INSERT INTO dbo.Movie VALUES ('Winter Solider',3.99,1,0, null);
INSERT INTO dbo.Movie VALUES ('Ant Man',4.25,1,0, null);
INSERT INTO dbo.Movie VALUES ('The Grinch', 3.25,1,0, null);
INSERT INTO dbo.Movie VALUES ('Bad Teacher',1.99,1,0, null);
INSERT INTO dbo.Movie VALUES ('Wolverine',4.50,1,0, null);
INSERT INTO dbo.Movie VALUES 
('Madea',1.50,1,0, null),
('Office Space',2.50,1,0, null);
INSERT INTO dbo.Movie VALUES('Office Space',2.50,1,0, null);
INSERT INTO dbo.Movie VALUES 
('Black Widow',7.00,1,0, null),
('Black Panther',4.50,1,0, null),
('Thor',7.00,1,0, null),
('Iron Man 2',4.50,1,0, null);

Insert into Movie Values ('Roger Rabit', 4, 1, 0, 1); -- inaccuragte as should show unavailable with return date 
Update Movie SET Available=0 where Id=14;
Update Movie SET ReturnDate=1715958473792 where Id=14;

Select * from [User];
Select * from Movie;

Select * from Movie where Id =6;
Select * from [User] where Id =2;

-- the Problem : Many to many relationships cause a problem in normalizing our data. Especially as it partains to our Primary Keys. 
--Probably talk about this next week 
--This principle  is about redunancy and how we should not have to do things over and over to get "normal" 
--There are many forms - common to get up to the third level
-- you can avoid this with a join table see Ryan whiteboard in class recording before break at 11:54 am 
