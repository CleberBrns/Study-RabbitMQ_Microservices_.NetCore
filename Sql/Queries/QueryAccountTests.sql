/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Type]
      ,[Balance]
  FROM [BankingDB].[dbo].[Accounts];


  --insert into Accounts
  --(Type, Balance)
  --values
  --('Checking', '0.00'),
  --('Savings', '1234.00'),
  --('Investing', '997.00'),
  --('LoanDebt', '432.00'),
  --('StudentDebit', '158.00')

  --commit


  --update Accounts set Type = 'LoanDebit' where Id = 4;