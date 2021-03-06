CREATE TABLE [Message](
    Id UNIQUEIDENTIFIER NOT NULL,
    ContactId UNIQUEIDENTIFIER NOT NULL,
    StatusId UNIQUEIDENTIFIER NOT NULL,
    [DateTime] DATETIME2 NOT NULL,
    [Text] VARCHAR (2048) NOT NULL,
);

CREATE TABLE Contact(
    Id UNIQUEIDENTIFIER NOT NULL,
    NickName VARCHAR(128) NOT NULL
);
CREATE TABLE [Status] (
    Id UNIQUEIDENTIFIER NOT NULL,
    [Status] VARCHAR (20) NOT NULL
);


ALTER TABLE [Message]
    ADD CONSTRAINT PK_Message PRIMARY KEY CLUSTERED (Id);
ALTER TABLE Contact
    ADD CONSTRAINT PK_Contact PRIMARY KEY CLUSTERED (Id);
ALTER TABLE [Status]
    ADD CONSTRAINT PK_Status PRIMARY KEY CLUSTERED (Id);

ALTER TABLE [Message]
    ADD CONSTRAINT FK_ContactId_Contact FOREIGN KEY (ContactId)
    REFERENCES Contact (Id)
    ON DELETE NO ACTION
    ON UPDATE CASCADE;
ALTER TABLE [Message]
    ADD CONSTRAINT FK_StatusId_Status FOREIGN KEY (StatusId)
    REFERENCES [Status] (Id)
    ON DELETE NO ACTION
    ON UPDATE CASCADE;
