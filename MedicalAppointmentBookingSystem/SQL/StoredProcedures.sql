-- Stored Procedures for MedicalDB
GO
CREATE PROCEDURE AddMedicine
    @Name VARCHAR(100),
    @Category VARCHAR(50),
    @Price DECIMAL(10,2),
    @Quantity INT
AS
BEGIN
    INSERT INTO Medicines (Name, Category, Price, Quantity)
    VALUES (@Name, @Category, @Price, @Quantity)
END
GO

CREATE PROCEDURE SearchMedicine
    @SearchTerm VARCHAR(100)
AS
BEGIN
    SELECT * FROM Medicines
    WHERE Name LIKE '%' + @SearchTerm + '%'
       OR Category LIKE '%' + @SearchTerm + '%'
END
GO

CREATE PROCEDURE UpdateStock
    @MedicineID INT,
    @Quantity INT
AS
BEGIN
    UPDATE Medicines SET Quantity = @Quantity WHERE MedicineID = @MedicineID
END
GO

CREATE PROCEDURE RecordSale
    @MedicineID INT,
    @QuantitySold INT
AS
BEGIN
    INSERT INTO Sales (MedicineID, QuantitySold, SaleDate)
    VALUES (@MedicineID, @QuantitySold, GETDATE())
    UPDATE Medicines SET Quantity = Quantity - @QuantitySold WHERE MedicineID = @MedicineID
END
GO

CREATE PROCEDURE GetAllMedicines
AS
BEGIN
    SELECT * FROM Medicines
END
GO
