CREATE TABLE [dbo].[tbl_uye] (
    [TC]       NVARCHAR (50) NOT NULL,
    [Ad]       NVARCHAR (50) NOT NULL,
    [Tel]      NVARCHAR (50) NULL,
    [email]    NVARCHAR (50) NULL,
    [password] NVARCHAR (50) NULL,
    [kan]      NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Ad])
);

