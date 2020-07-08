CREATE TABLE [dbo].[User]
(
    Id          BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    Username    VARCHAR(255) NULL,
    FirstName   VARCHAR(255) NULL,
    LastName    VARCHAR(255) NULL,
    Email       VARCHAR(255) NULL,
    /* Update to store hash */
    Password    VARCHAR(255) NOT NULL,
    Phone       VARCHAR(255) NULL,
    UserStatus  INT NOT NULL
);
