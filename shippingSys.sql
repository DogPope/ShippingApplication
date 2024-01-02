-- T00158237 Daniel Jameson
-- ShippingSYS.sql
-- This script is responsible for creating the associated tables and adding data to ShippingApplication.  CASCADE CONSTRAINTS

DROP TABLE Order_Items;
DROP TABLE Orders;
DROP TABLE Games;
DROP TABLE Customers;

CREATE Table Customers(
Cust_Id Numeric(5),
Surname Varchar2(20) NOT NULL,
Forename Varchar2(20) NOT NULL,
Town Varchar2(20) NOT NULL,
EIRcode Varchar2(8) NOT NULL,
Password Varchar2(20) NOT NULL,
Phone Varchar2(15) NOT NULL,
Email Varchar2(50) NOT NULL,
CardNumber Varchar2(16) NOT NULL,
Status Varchar2(15) DEFAULT 'Registered',
County Varchar2(9) NOT NULL,
CONSTRAINT Cust_Id_pk PRIMARY KEY (Cust_Id)
);

CREATE TABLE Games(
Game_Id Numeric(5),
Title Varchar2(20)NOT NULL,
Developer Varchar2(20)NOT NULL,
Publisher Varchar2(20)NOT NULL,
Genre Varchar2(20),
Description varchar2(50),
BuyPrice numeric(4,2)NOT NULL CHECK(BuyPrice > -1),
SalePrice numeric(4,2)NOT NULL CHECK(SalePrice > -1),
Quantity numeric(5) NOT NULL CHECK(Quantity > -1),
Status Varchar2(15) DEFAULT 'Registered',
CONSTRAINT Game_Id_pk PRIMARY KEY (Game_ID)
);

CREATE TABLE Orders(
Order_Id Numeric(5),
Order_Date Date DEFAULT SYSDATE,
Cost Numeric(6,2) NOT NULL CHECK(Cost > -1),
Status varchar2(15) DEFAULT 'Placed',
Cust_Id Numeric(5),
CONSTRAINT Order_Id_pk PRIMARY KEY (Order_Id),
CONSTRAINT Cust_Id_fk FOREIGN KEY (Cust_Id) REFERENCES Customers
);

CREATE TABLE Order_Items(
Order_Id Numeric(5),
Cost numeric(4,2) NOT NULL CHECK(Cost > -1),
Game_Id Numeric(5),
CONSTRAINT Order_Id_fk FOREIGN KEY(Order_Id) REFERENCES Orders,
CONSTRAINT Game_Id_fk FOREIGN KEY (Game_Id) REFERENCES Games
);

-- static customer data for testing and diagnostic purposes. 
INSERT INTO Customers VALUES 
(1, 'Langford', 'Adam', 'Tralee', 'V93 RG84', 'password', '0874772653','fakeEmail@gmail.com', '4444444444444444', 'Registered','Kerry');
INSERT INTO Customers VALUES
(2, 'Murphy', 'Patrick', 'Limerick', 'C65 VB54', 'hunter2', '0873572046','murphy@gmail.com', '1234123412341234', 'Registered','Limerick');
INSERT INTO Customers VALUES 
(3, 'O Shea', 'Jennifer', 'Cork', 'P98 TH54', 'password1', '0872020048','jennifer@gmail.com', '1111111111111111', 'Registered','Cork');
INSERT INTO Customers VALUES
(4, 'O Connell', 'Patrick', 'Dundalk', 'M54 TH65', 'randomString', '08512127035','OCONNELL@gmail.com', '4321432143214321', 'Registered','Louth');
INSERT INTO Customers VALUES
(5, 'McCarthy', 'Orla', 'Roscommon', 'R34 TG84', 'nopassforyou', '0857120341','yancy@gmail.com', '4871903265918452', 'Registered','Carlow');
INSERT INTO Customers VALUES
(6, 'Ryan', 'Thomas', 'Wexford', 'B93 PO68', 'realpassword', '0833812639','thomas@gmail.com', '9365837501810381', 'Registered','Leitrim');
INSERT INTO Customers VALUES
(7, 'Placeholder', 'Placeholder', 'Wexford', 'K93 AG12', 'Placeholder', '0833816339','Placeholder@gmail.com', '9365837501810381', 'Registered','Leitrim');

-- Static data for the games table for testing and diagnostic purposes.
-- Game_Id, Title, Developer, Publisher, Genre, Description, BuyPrice, SalePrice, Quantity, Status
INSERT INTO Games VALUES
(1, 'Sonic', 'Sonic Team', 'SEGA','Platformer','Small Blue rodent runs fast!', 45.00, 80.00, 8, 'Registered');
INSERT INTO Games VALUES
(2, 'Metal', 'Increasing Values', 'Plutonium', 'Jack tries out chemistry!', 25.00, 45.00, 4,'Registered');
INSERT INTO Games VALUES
(3, 'Mario', 'Nintendo', 'Nintendo','Platformer','Plumber fixes sinks and jumps on turtles!', 30.00, 60.00, 1, 'Registered');
INSERT INTO Games VALUES
(4, 'Kids Game', 'Sega', 'Sega', 'Platformer', 'Cinderella rescues Italian plumber!', 30.00, 60.00, 0, 'Deregistered');
INSERT INTO Games VALUES
(5, 'Zelda', 'Nintendo', 'Nintendo', 'Platformer', 'Little Green man rescues princess!', 30.00, 60.00, 12, 'Registered');
INSERT INTO Games VALUES
(6, 'Find Ruler', 'Rockstar', 'Rockstar', 'Puzzle', 'While under a porch, seek the red graphing tool!', 30.00, 60.00, 62, 'Registered');

-- Order_Id, Date, Total, Status, Cust_Id
-- Statuses are Placed, Fulfilled, Returned, Cancelled, In Transit
INSERT INTO Orders VALUES (1,'12-JAN-2022',30.00,'Placed',1);
INSERT INTO Orders VALUES (2,'08-FEB-2022',30.00,'Placed',2);
INSERT INTO Orders VALUES (3,'06-MAR-2022',90.00,'Fulfilled',3);
INSERT INTO Orders VALUES (4,'08-APR-2022',120.00,'Returned',4);
INSERT INTO Orders VALUES (5,'25-MAY-2022',120.00,'Cancelled',7);
INSERT INTO Orders VALUES (6,'30-JUN-2022',120.00,'Placed',6);
INSERT INTO Orders VALUES (7,'12-JUL-2022',250.00,'Placed',2);
INSERT INTO Orders VALUES (8,'12-AUG-2022',5500.00,'Cancelled',7);
INSERT INTO Orders VALUES (9,'01-SEP-2022',1.00,'Returned',6);
INSERT INTO Orders VALUES (10,'23-OCT-2022',0.50,'Fulfilled',3);
INSERT INTO Orders VALUES (11,'28-NOV-2022',3.00,'Cancelled',5);
INSERT INTO Orders VALUES (12,'02-DEC-2022',80.00,'Fulfilled',1);
INSERT INTO Orders VALUES (13,'12-JAN-2022',30.00,'In Transit',7);
INSERT INTO Orders VALUES (14,'02-DEC-2022',80.00,'Fulfilled',7);


-- OrderID, Cost, GameID
INSERT INTO Order_Items VALUES (1,60,1);
INSERT INTO Order_Items VALUES (1,60,2);
INSERT INTO Order_Items VALUES (1,60,3);
INSERT INTO Order_Items VALUES (1,60,4);
INSERT INTO Order_Items VALUES (2,60,1);
INSERT INTO Order_Items VALUES (2,60,2);
INSERT INTO Order_Items VALUES (2,60,3);
INSERT INTO Order_Items VALUES (2,60,4);
INSERT INTO Order_Items VALUES (3,60,5);
INSERT INTO Order_Items VALUES (3,60,1);
INSERT INTO Order_Items VALUES (3,60,2);
INSERT INTO Order_Items VALUES (3,60,3);
INSERT INTO Order_Items VALUES (4,60,4);
INSERT INTO Order_Items VALUES (4,60,5);
INSERT INTO Order_Items VALUES (4,60,6);
INSERT INTO Order_Items VALUES (4,60,1);
INSERT INTO Order_Items VALUES (5,60,4);
INSERT INTO Order_Items VALUES (5,60,5);
INSERT INTO Order_Items VALUES (5,60,6);
INSERT INTO Order_Items VALUES (5,60,1);
INSERT INTO Order_Items VALUES (6,60,4);
INSERT INTO Order_Items VALUES (6,60,5);
INSERT INTO Order_Items VALUES (6,60,6);
INSERT INTO Order_Items VALUES (6,60,1);
INSERT INTO Order_Items VALUES (7,60,4);
INSERT INTO Order_Items VALUES (7,60,5);
INSERT INTO Order_Items VALUES (7,60,6);
INSERT INTO Order_Items VALUES (7,60,1);
INSERT INTO Order_Items VALUES (8,60,4);
INSERT INTO Order_Items VALUES (8,60,5);
INSERT INTO Order_Items VALUES (8,60,6);
INSERT INTO Order_Items VALUES (8,60,1);
INSERT INTO Order_Items VALUES (9,60,4);
INSERT INTO Order_Items VALUES (9,60,5);
INSERT INTO Order_Items VALUES (9,60,6);
INSERT INTO Order_Items VALUES (9,60,1);
INSERT INTO Order_Items VALUES (10,60,4);
INSERT INTO Order_Items VALUES (10,60,5);
INSERT INTO Order_Items VALUES (10,60,6);
INSERT INTO Order_Items VALUES (10,60,1);
INSERT INTO Order_Items VALUES (11,60,4);
INSERT INTO Order_Items VALUES (11,60,5);
INSERT INTO Order_Items VALUES (11,60,6);
INSERT INTO Order_Items VALUES (11,60,1);
INSERT INTO Order_Items VALUES (12,60,4);
INSERT INTO Order_Items VALUES (12,60,5);
INSERT INTO Order_Items VALUES (12,60,6);
INSERT INTO Order_Items VALUES (12,60,1);
INSERT INTO Order_Items VALUES (13,60,4);
INSERT INTO Order_Items VALUES (13,60,5);
INSERT INTO Order_Items VALUES (13,60,6);
INSERT INTO Order_Items VALUES (13,60,1);
INSERT INTO Order_Items VALUES (14,60,4);
INSERT INTO Order_Items VALUES (14,60,5);
INSERT INTO Order_Items VALUES (14,60,6);
INSERT INTO Order_Items VALUES (14,60,1);


COMMIT;