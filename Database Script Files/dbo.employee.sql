USE [D:\C#\C# FINAL PROJECT\HMSFINAL\HOSPITALMGMTSYS\HOSPITALMGMTSYS\HMS.MDF]
GO

/****** Object: Table [dbo].[employee] Script Date: 4/25/2019 10:03:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employee] (
    [empid]       INT          IDENTITY (1, 1) NOT NULL,
    [designation] VARCHAR (50) NOT NULL,
    [salary]      INT          NOT NULL,
    [personid]    INT          NOT NULL
);


