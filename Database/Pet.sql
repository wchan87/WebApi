CREATE TABLE [dbo].[Pet]
(
    Id          BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    CategoryId  BIGINT NOT NULL,
    Name        VARCHAR(255) NOT NULL,
    PetStatusId INT NOT NULL
    FOREIGN KEY (CategoryId) REFERENCES Category(Id)
)