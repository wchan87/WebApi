CREATE TABLE [dbo].[Pet_PhotoUrl]
(
    PetId       BIGINT NOT NULL,
    PhotoUrl    VARCHAR(255) NOT NULL,
    FOREIGN KEY (PetId) REFERENCES Pet(Id)
);
