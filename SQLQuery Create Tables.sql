CREATE TABLE Clubs (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClubName NVARCHAR(50) NOT NULL,
    FoundingDate DATE NOT NULL,
    CreatedAt DATETIME NOT NULL,
    UpdatedAt DATETIME NOT NULL
);

CREATE TABLE Players (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL,
    EmailAddress NVARCHAR(100) NOT NULL,
    PersonalIdNumber NVARCHAR(50) NOT NULL,
    PlayingPosition NVARCHAR(50) NOT NULL,
    ClubId INT NOT NULL,
    CreatedAt DATETIME NOT NULL,
    UpdatedAt DATETIME NOT NULL,
    CONSTRAINT FK_Players_Clubs FOREIGN KEY (ClubId)
        REFERENCES Clubs (Id)
        ON DELETE CASCADE
);

CREATE TABLE CoachingStaff (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL,
    EmailAddress NVARCHAR(100) NOT NULL,
    PersonalIdNumber NVARCHAR(20) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    ClubId INT NOT NULL,
    CreatedAt DATETIME NOT NULL,
    UpdatedAt DATETIME NOT NULL,
    CONSTRAINT FK_CoachingStaff_Clubs FOREIGN KEY (ClubId)
        REFERENCES Clubs (Id)
        ON DELETE CASCADE
);