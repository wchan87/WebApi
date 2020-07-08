CREATE TABLE [dbo].[Pet_Tag]
(
    PetId       BIGINT NOT NULL,
    TagId       BIGINT NOT NULL,
    FOREIGN KEY (PetId) REFERENCES Pet(Id),
    FOREIGN KEY (TagId) REFERENCES Tag(Id)
);
