-- Create the database
CREATE DATABASE Hotel_Management;

-- Create the User_Table
CREATE TABLE User_Table (
    User_ID INT IDENTITY(1,1) NOT NULL, -- Auto-increment User ID
    User_Name VARCHAR(150) NOT NULL,   -- Username
    User_Password VARCHAR(150) NOT NULL, -- Password
    CONSTRAINT User_Table_User_ID_PK PRIMARY KEY (User_ID) -- Primary Key constraint on User_ID
);

-- Insert sample data into the User_Table
INSERT INTO User_Table (User_Name, User_Password)
VALUES ('JACK', '012345');
