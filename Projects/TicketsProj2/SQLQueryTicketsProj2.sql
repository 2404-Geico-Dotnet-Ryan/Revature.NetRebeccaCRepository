CREATE TABLE Employee
(
	EmpId int Identity(1,1) Primary Key, -- identity(1,1) indicates that system will assign staring at number 1 and increment by 1 each time (this is sequence generation) - Primary key makes sure not null and is unique value
	EmpName varchar(50) Unique not null, 
	EmpPassword varchar(50) not null,
	EmpRole varchar(50) not null check(EmpRole in ('developer' , 'user'))
);


Create Table Ticket
(
	TicketId int Identity(1,1) Primary Key,
	Type varchar (50) Unique not null, 
	OpenedBy varchar (50),
	Department varchar (50),
	Available Bit default 0,
	Completed Bit default 1,
	DueDate BigInt default 0,
	CompletedDate BigInt default 0,
	EmpId int,
	Constraint FK_Ticket_Driver Foreign Key (EmpId) references Employee (EmpId)
);


--unable to do this right now for some reason
Insert Into Employee values ('Rebeccca', 'pass1', 'developer');
Insert Into Employee values ('Jennifer', 'pass2', 'developer');
Insert Into Employee values ('Derrick', 'pass3', 'user');

Insert Into Ticket Values ('Fix Balance on Policy', 'John Doe', 'Service', default, default, default, default);
Insert Into Ticket Values ('Fix Balance on Policy', 'John Doe', 'Service', default, default, default, default);
Insert Into Ticket Values ('Fix Balance on Policy', 'John Doe', 'Service', default, default, default, default);
Insert Into Ticket Values ('Fix Balance on Policy', 'John Doe', 'Service', default, default, default, default);

Select * from Ticket;
Select * From Employee;

Select * From Employee where EmpId =1;
Select * From Ticket where Department = 'Service';