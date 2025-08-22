-- SQL script to create MedicalDB and all required tables
CREATE DATABASE MedicalDB;
GO
USE MedicalDB;
GO

CREATE TABLE Doctors (
    DoctorID INT PRIMARY KEY IDENTITY,
    FullName VARCHAR(100),
    Specialty VARCHAR(100),
    Availability BIT
);

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY IDENTITY,
    FullName VARCHAR(100),
    Email VARCHAR(100)
);

CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY IDENTITY,
    PatientID INT FOREIGN KEY REFERENCES Patients(PatientID),
    DoctorID INT FOREIGN KEY REFERENCES Doctors(DoctorID),
    AppointmentDate DATETIME,
    Category VARCHAR(100),
    Price DECIMAL(10,2),
    Quantity INT
);

CREATE TABLE Medicines (
    MedicineID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2),
    Quantity INT
);

CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY,
    MedicineID INT FOREIGN KEY REFERENCES Medicines(MedicineID),
    QuantitySold INT,
    SaleDate DATETIME
);
