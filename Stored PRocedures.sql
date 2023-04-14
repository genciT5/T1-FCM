Go
CREATE PROCEDURE CreateClub
    @ClubName NVARCHAR(50),
    @FoundingDate DATE
AS
BEGIN
    INSERT INTO FCM.dbo.Clubs (ClubName, FoundingDate, CreatedAt, UpdatedAt)
    VALUES (@ClubName, @FoundingDate, GETDATE(), GETDATE());
END

Go
CREATE PROCEDURE GetClubs
AS
BEGIN
    SELECT Id, ClubName, FoundingDate, CreatedAt, UpdatedAt FROM Clubs;
END

Go
CREATE PROCEDURE UpdateClub
    @Id INT,
    @ClubName NVARCHAR(50),
    @FoundingDate DATE
AS
BEGIN
    UPDATE Clubs SET ClubName = @ClubName, FoundingDate = @FoundingDate, UpdatedAt = GETDATE()
    WHERE Id = @Id;
END

Go
CREATE PROCEDURE DeleteClub
    @Id INT
AS
BEGIN
    BEGIN TRANSACTION;
    
    DELETE FROM CoachingStaff WHERE ClubId = @Id;
    DELETE FROM Players WHERE ClubId = @Id;
    DELETE FROM Clubs WHERE Id = @Id;

    COMMIT TRANSACTION;
END

Go
CREATE PROCEDURE CreatePlayer
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @PhoneNumber NVARCHAR(20),
    @EmailAddress NVARCHAR(100),
    @PersonalIdNumber NVARCHAR(50),
    @PlayingPosition NVARCHAR(50),
    @ClubId INT
AS
BEGIN
    INSERT INTO Players (FirstName, LastName, PhoneNumber, EmailAddress, PersonalIdNumber, PlayingPosition, ClubId, CreatedAt, UpdatedAt)
    VALUES (@FirstName, @LastName, @PhoneNumber, @EmailAddress, @PersonalIdNumber, @PlayingPosition, @ClubId, GETDATE(), GETDATE());
END;

Go
CREATE PROCEDURE GetPlayers
    @ClubId INT
AS
BEGIN
    SELECT Id, FirstName, LastName, PhoneNumber, EmailAddress, PersonalIdNumber, PlayingPosition, ClubId, CreatedAt, UpdatedAt
    FROM Players
    WHERE ClubId = @ClubId;
END

Go
CREATE PROCEDURE GetAllPlayers
AS
BEGIN
    SELECT Id, FirstName, LastName, PhoneNumber, EmailAddress, PersonalIdNumber, PlayingPosition, ClubId, CreatedAt, UpdatedAt
    FROM Players
END

Go
CREATE PROCEDURE UpdatePlayer
    @Id INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @PhoneNumber NVARCHAR(20),
    @EmailAddress NVARCHAR(100),
    @PersonalIdNumber NVARCHAR(50),
    @PlayingPosition NVARCHAR(50),
    @ClubId INT
AS
BEGIN
    UPDATE Players SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, EmailAddress = @EmailAddress, PersonalIdNumber = @PersonalIdNumber, PlayingPosition = @PlayingPosition, ClubId = @ClubId, UpdatedAt = GETDATE()
    WHERE Id = @Id;
END


Go
CREATE PROCEDURE DeletePlayer
    @Id INT
AS
BEGIN
    DELETE FROM Players WHERE Id = @Id;
END


Go
CREATE PROCEDURE CreateCoachingStaff
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @PhoneNumber NVARCHAR(20),
    @EmailAddress NVARCHAR(100),
    @PersonalIdNumber NVARCHAR(50),
    @Role NVARCHAR(50),
    @ClubId INT
AS
BEGIN
    INSERT INTO CoachingStaff (FirstName, LastName, PhoneNumber, EmailAddress, PersonalIdNumber, Role, ClubId, CreatedAt, UpdatedAt)
    VALUES (@FirstName, @LastName, @PhoneNumber, @EmailAddress, @PersonalIdNumber, @Role, @ClubId, GETDATE(), GETDATE());
END

-- Create stored procedure to read CoachingStaff
Go
CREATE PROCEDURE GetCoachingStaff
    @ClubId INT
AS
BEGIN
    SELECT Id, FirstName, LastName, PhoneNumber, EmailAddress, PersonalIdNumber, Role, ClubId, CreatedAt, UpdatedAt
    FROM CoachingStaff
    WHERE ClubId = @ClubId;
END

-- Create stored procedure to update CoachingStaff
Go
CREATE PROCEDURE UpdateCoachingStaff
    @Id INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @PhoneNumber NVARCHAR(20),
    @EmailAddress NVARCHAR(100),
    @PersonalIdNumber NVARCHAR(50),
    @Role NVARCHAR(50),
    @ClubId INT
AS
BEGIN
    UPDATE CoachingStaff SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, EmailAddress = @EmailAddress, PersonalIdNumber = @PersonalIdNumber, Role = @Role, ClubId = @ClubId, UpdatedAt = GETDATE()
    WHERE Id = @Id;
END

-- Create stored procedure to delete CoachingStaff
go
CREATE PROCEDURE DeleteCoachingStaff
    @Id INT
AS
BEGIN
    DELETE FROM CoachingStaff WHERE Id = @Id;
END