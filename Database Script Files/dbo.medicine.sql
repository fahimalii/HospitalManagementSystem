USE [D:\C#\C# FINAL PROJECT\HMSFINAL\HOSPITALMGMTSYS\HOSPITALMGMTSYS\HMS.MDF]
GO

/****** Object: Table [dbo].[medicine] Script Date: 4/25/2019 10:03:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[medicine] (
    [medicineid]   INT          IDENTITY (1, 1) NOT NULL,
    [medicinename] VARCHAR (50) NOT NULL
);


