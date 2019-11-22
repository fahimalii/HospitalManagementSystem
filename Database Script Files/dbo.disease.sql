USE [D:\C#\C# FINAL PROJECT\HMSFINAL\HOSPITALMGMTSYS\HOSPITALMGMTSYS\HMS.MDF]
GO

/****** Object: Table [dbo].[disease] Script Date: 4/25/2019 10:03:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[disease] (
    [diseaseid]   INT          IDENTITY (1, 1) NOT NULL,
    [diseasename] VARCHAR (50) NOT NULL
);


