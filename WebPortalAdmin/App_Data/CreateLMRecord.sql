USE [learnSystemDev]
GO

/****** Object:  Table [dbo].[LMRecord]    Script Date: 04/07/2015 13:30:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LMRecord](
	[lmid] [nchar](10) NULL,
	[sid] [nchar](10) NULL,
	[gid] [nchar](10) NULL,
	[uid] [nchar](10) NULL,
	[recdate] [nchar](40) NULL,
	[ifsucceed] [nchar](10) NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[LMRecord] SET (LOCK_ESCALATION = AUTO)
GO


