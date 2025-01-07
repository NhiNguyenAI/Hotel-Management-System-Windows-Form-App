-- Create the database

CREATE DATABASE Hotel_Management;

-- Create the User_Table
CREATE TABLE User_Table (
    UserID INT IDENTITY(1,1) NOT NULL, -- Auto-increment User ID
    UserName VARCHAR(150) NOT NULL,   -- Username
    UserPassword VARCHAR(150) NOT NULL, -- Password
    FristName VARCHAR(150) NOT NULL, -- First Name
    LastName VARCHAR(150) NOT NULL, -- Last Name
	Roll VARCHAR(150) NOT NULL,
    Telefone VARCHAR(200) NOT NULL, -- Telephone
    Adress VARCHAR(400) NOT NULL, -- Address
	PostalCode VARCHAR(150) NOT NULL,
	City VARCHAR(400) NOT NULL,
    CONSTRAINT User_Table_User_ID_PK PRIMARY KEY (UserID) -- Primary Key constraint on User_ID
);

-- Insert sample data into the User_Table
INSERT INTO User_Table (UserName, UserPassword, FristName, LastName, Roll,Telefone, Adress, PostalCode, City)
VALUES ('jack', '123', 'Nguyen', 'Jack',  'Admin','0152', 'Ahornweg', '25689','Fulda' );

Select *
From dbo.User_Table;