CREATE TABLE Driver
(
	Id int Identity(1,1) Primary Key, -- identity(1,1) indicates that system will assign staring at number 1 and increment by 1 each time (this is sequence generation) - Primary key makes sure not null and is unique value
	DriverName varchar(50) Unique not null, 
	[Password] varchar(50) not null,
	[Role] varchar(50) not null check(Role in ('user' , 'admin'))
);


Create Table Ticket
(
	TicketId int Identity(1,1) Primary Key,
	Type varchar (50) Unique not null, --may want to allow duplicates so that you can have multiple copies of same movie -- add unique means the renter can only have one copy of of a particular movie title
	Cost Decimal (12, 2),
	Balance Decimal (12, 2),
	PaidInFull Bit default 1,
	DueDate BigInt default 0,
	DriverID int,
	Constraint FK_Ticket_Driver Foreign Key (DriverID) references driver(Id)
);





