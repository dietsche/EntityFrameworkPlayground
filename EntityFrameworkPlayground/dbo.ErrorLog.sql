CREATE TABLE [dbo].[ErrorLog]
(
	[ErrorLogId]   INT           IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [When] DATETIME2 NOT NULL, 
    [Message] VARCHAR(MAX) NOT NULL
)
