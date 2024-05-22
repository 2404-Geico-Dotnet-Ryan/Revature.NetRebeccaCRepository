--SELECT * FROM Movie WHERE Price IN (4, 5, 7);
--SELECT * FROM Movie WHERE Price BETWEEN 4 AND 7;
--SELECT * FROM Movie WHERE Price > 5 AND Available = 1;

CREATE TABLE [User] (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	Username VARCHAR(50) UNIQUE NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Role VARCHAR(50) NOT NULL CHECK(Role IN ('user', 'admin'))
);

DROP TABLE Movie;
CREATE TABLE Movie (
	Id INT IDENTITY PRIMARY KEY,
	Title VARCHAR(50) UNIQUE NOT NULL,
	Price DECIMAL(12,2),
	Available BIT DEFAULT 1,
	ReturnDate BIGINT DEFAULT 0,
	UserId INT,
	CONSTRAINT FK_Movie_User FOREIGN KEY (UserId) REFERENCES [User](Id)
);

INSERT INTO [User] VALUES ('ryan', 'pass1', 'user');
INSERT INTO [User] VALUES 
('jonathan', 'pass2', 'user'),
('admin', 'pass3', 'admin');
--INSERT INTO [User] VALUES ('brian', 'pass4', 'superuser'); --Rejected! Violates Check Constraint
SELECT * FROM [User];

INSERT INTO Movie VALUES ('Iron Man', 5, 1, 0, NULL);
INSERT INTO Movie VALUES ('The Avengers', 6, DEFAULT, DEFAULT, NULL);
INSERT INTO Movie (Title, Price, UserId) VALUES
('Ant-Man', 4, NULL);
INSERT INTO Movie VALUES ('Thor', 4, 0, 1715958473792, 4);

SELECT * FROM Movie;

SELECT * FROM Movie WHERE Id = 6;
SELECT * FROM [User] WHERE Id = 4;


-- The Problem: Many-to-Many Relationships cause a problem in normalizing our data. Especially as it pertains to our Primary Keys.

