CREATE TABLE [dbo].[Category]
(
    Id          BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    PetId       BIGINT NOT NULL,
    Quantity    INT NOT NULL,
    ShipDate    DATE NOT NULL,
    OrderStatus INT NOT NULL,
    FOREIGN KEY (PetId) REFERENCES Pet(Id)
);
