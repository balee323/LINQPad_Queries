<Query Kind="SQL" />

USE [DatabaseName]
GO
/****** Object:  StoredProcedure [dbo].[InsertProcedure]    Script Date: 1/13/2021 12:59:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Brian Lee
-- Create date: 1/13/2021
-- Description:	This procedure inserts into a table using a JSON parameter
-- EXEC WinCommunitiesInsertUserAgents @Json = '[{"UserName" : "BLee"}, {"UserName" : "JDoe"}]'
-- =============================================
ALTER OR CREATE PROCEDURE [dbo].[InsertProcedure] 
	@Json nvarchar(max) 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @ReturnVal int

	select * into #S 
	from OPENJSON(@Json)
	with (
		USER_AGENT_STRING nvarchar(255) '$.UserName'
	)

	MERGE [dbo].[WIN_COMMUNITIES_USER_AGENTS] AS t
	USING #S AS s
		ON (s.[UserName] = t.[UserName])
	WHEN MATCHED THEN
		UPDATE
			set
			 [UserName] = s.[UserName],
			 [USER_MODIFIED_DATE] = GETUTCDATE(),
			 [IS_ENABLED] = 1

	WHEN NOT MATCHED THEN
		INSERT ([UserName], [USER_ADDED_DATE], [IS_ENABLED])
		VALUES (s.[UserName],  GETUTCDATE(), 1);
END