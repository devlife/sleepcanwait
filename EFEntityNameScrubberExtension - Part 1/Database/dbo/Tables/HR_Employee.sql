CREATE TABLE [dbo].[HR_Employee] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Email]     VARCHAR (100) NOT NULL,
    [ContactId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_HR_Employee_HR_Contact] FOREIGN KEY ([ContactId]) REFERENCES [dbo].[HR_Contact] ([Id])
);

