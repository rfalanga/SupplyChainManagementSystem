-- Here is the SQL Tables that need to be added to the database

-- Supplier table
CREATE TABLE Supplier (
    Supplier_Id UniqueIdentifier PRIMARY KEY,
    Supplier_Name VARCHAR(255) NOT NULL,
    Supplier_Address VARCHAR(255) NOT NULL,
    Supplier_Contact VARCHAR(255),
    Supplier_Phone VARCHAR(20),
    Supplier_Email VARCHAR(20)
);

-- Product table
CREATE TABLE Product (
    Product_Id UniqueIdentifier PRIMARY KEY,
    Product_Name VARCHAR(255) NOT NULL,
    Product_Description TEXT,
    Unit_Price DECIMAL(10, 2) NOT NULL,
    Product_Quantity INT NOT NULL
);

-- Order table
CREATE TABLE [Order] (
    Order_Id UniqueIdentifier PRIMARY KEY,
    Product_Id UniqueIdentifier NOT NULL,
    Supplier_Id UniqueIdentifier NOT NULL,
    Order_date DATE NOT NULL,
    Order_Quantity INT NOT NULL,
    FOREIGN KEY (Product_Id) REFERENCES Product(Product_Id),
    FOREIGN KEY (Supplier_Id) REFERENCES Supplier(Supplier_Id)
);

-- Shipment table
CREATE TABLE Shipment (
    Shipment_Id UniqueIdentifier PRIMARY KEY,
    Order_Id UniqueIdentifier NOT NULL,
    Shipment_Date DATE NOT NULL,
    Estimated_Arrival_Date DATE NOT NULL,
    Actual_Arrival_Date DATE,
    FOREIGN KEY (Order_Id) REFERENCES [Order](Order_Id)
);

