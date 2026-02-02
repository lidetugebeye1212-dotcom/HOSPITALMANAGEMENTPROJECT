CREATE TABLE PatientTable (
    PatId INT PRIMARY KEY,          -- Unique ID for each patient
    PatName NVARCHAR(100) NOT NULL, -- Full Name
    PatPhone NVARCHAR(15),          -- Contact number
    PatGender NVARCHAR(10),         -- Male/Female
    PatAge INT,                     -- Age
    PatAddress NVARCHAR(255)        -- Home Address
);