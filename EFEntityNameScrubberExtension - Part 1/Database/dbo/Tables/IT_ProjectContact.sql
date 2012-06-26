CREATE TABLE [dbo].[IT_ProjectContact] (
    [ProjectId] INT NOT NULL,
    [ContactId] INT NOT NULL,
    CONSTRAINT [FK_IT_ProjectContact_HR_Contact] FOREIGN KEY ([ContactId]) REFERENCES [dbo].[HR_Contact] ([Id]),
    CONSTRAINT [FK_IT_ProjectContact_IT_Projects] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[IT_Project] ([Id])
);

