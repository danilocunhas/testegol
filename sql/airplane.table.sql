CREATE TABLE [dbo].[AirPlane](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NULL,
	[Model] [varchar](50) NULL,
	[NumberOfPassengers] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_AirPlane] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[AirPlane] ADD  CONSTRAINT [DF_AirPlane_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO


