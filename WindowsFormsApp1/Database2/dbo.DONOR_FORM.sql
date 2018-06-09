CREATE TABLE [dbo].[DONOR_FORM] (
    [Id]             INT           NOT NULL,
    [First_Name]     CHAR (70)     NOT NULL,
    [Last_Name]      CHAR (70)     NOT NULL,
    [Age]            INT           NOT NULL,
    [Gender]         CHAR (10)     NOT NULL,
    [Address]        VARCHAR (120) NOT NULL,
    [Marital_Status] CHAR (30)     NOT NULL,
    [Contact_Number] VARCHAR (20)  NOT NULL,
    [City]           CHAR (30)     NOT NULL,
    [Blood_Type]     VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

