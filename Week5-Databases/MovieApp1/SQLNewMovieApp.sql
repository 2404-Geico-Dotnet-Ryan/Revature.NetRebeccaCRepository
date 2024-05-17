CREATE TABLE [User]
(
	Id INT Identity(1,1) Primary Key, -- identity(1,1) indicates that system will assign staring at number 1 and increment by 1 each time (this is sequence generation) - Primary key makes sure not null and is unique value
	UserName varchar(50) Unique not null, 
	[Password] varchar(50) not null,
	[Role] varchar(50) not null check(Role in ('user' , 'admin'))
);

