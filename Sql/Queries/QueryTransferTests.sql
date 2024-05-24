/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[FromAccount]
      ,[ToAccount]
      ,[TransferAmount]
  FROM [TransferDB].[dbo].[AccountTransferLogs];

  --insert into AccountTransferLogs 
  --(FromAccount, ToAccount, TransferAmount)
  --values
  --(123, 456, 250.79),
  --(456, 123, 92.59),
  --(789, 123, 1250.35)