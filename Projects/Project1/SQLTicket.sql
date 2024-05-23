CREATE TABLE Driver
(
	DriverId int Identity(1,1) Primary Key, -- identity(1,1) indicates that system will assign staring at number 1 and increment by 1 each time (this is sequence generation) - Primary key makes sure not null and is unique value
	DriverName varchar(50) Unique not null, 
	[Password] varchar(50) not null,
	[Role] varchar(50) not null check(Role in ('user' , 'admin'))
);
--drop table Driver;

Create Table Ticket
(
	TicketId int Identity(1,1) Primary Key,
	Type varchar (50) not null, 
	Cost Decimal (12, 2),
	Balance Decimal (12, 2),
	PaidInFull Bit default 0,
	DueDate BigInt default 0,
	DriverID int,
	Constraint FK_Ticket_Driver Foreign Key (DriverID) references driver(Id)
);
--drop table ticket;
Insert Into Driver values ('Rebeccca', 'pass1', 'admin');
Insert Into Driver values ('Scott', 'pass2', 'user');
Insert Into Driver values ('Jennifer', 'pass1', 'user');


Insert Into Ticket Values ('Speeding', 250.00, 150.00, default, default, 1);
Insert Into Ticket Values ('Sealtbelt', 250.00, 250.00, default, default, 2);
Insert Into Ticket Values ('Cell Phone', 100.00, 100.00, default, default, 3);
Insert Into Ticket Values ('Failure to Yield', 150.00, 75.00, default, default, 1);
Insert Into Ticket Values ('Reckless Driving', 500.00, 350.00, default, default, 2);
Insert Into Ticket Values ('DUI', 750.00, 550.00, default, default, 3);

Select * From dbo.Driver;
Select * From dbo.Ticket;