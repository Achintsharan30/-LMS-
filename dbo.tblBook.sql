CREATE TABLE [dbo].[tblBook] (
    [BookId]          INT           IDENTITY (1, 1) NOT NULL,
    [AuthorName]      NVARCHAR (25) NULL,
    [BookCategeory]   NVARCHAR (15) NULL,
    [BookPublisher]   NVARCHAR (15) NULL,
    [BookReleaseDate] DATE          NULL,
    [Booktitle]       NVARCHAR (40) NULL,
    PRIMARY KEY CLUSTERED ([BookId] ASC)
);

