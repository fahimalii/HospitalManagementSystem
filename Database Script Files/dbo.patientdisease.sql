USE [D:\C#\C# FINAL PROJECT\HMSFINAL\HOSPITALMGMTSYS\HOSPITALMGMTSYS\HMS.MDF]
GO

/****** Object: Table [dbo].[patientdisease] Script Date: 4/25/2019 10:03:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[patientdisease] (
    [pdid]         INT          IDENTITY (1, 1) NOT NULL,
    [personid]     INT          NOT NULL,
    [diseasename]  VARCHAR (50) NULL,
    [medicinename] VARCHAR (50) NULL,
    [doctorid]     INT          NOT NULL
);


