CREATE TABLE Ticket
(
	Id int,
	TicketType varchar(100),
	Cost numeric(12,2), 
	Balance numeric(12,2), 
	PaidInFull bit, 
	DueDate bigint,
	--Driver needs to be added 
);
--DROP TABLE Ticket;

INSERT INTO Ticket VALUES (1,'Speeding',205.00,205.00,0,0);
INSERT INTO Ticket VALUES (2,'Failure to Yield Right of Way',50.00,25.00,0,0);
INSERT INTO Ticket VALUES (3,'Seat Belt Violation',30.85,30.85,0,0);


Select* From Ticket;
