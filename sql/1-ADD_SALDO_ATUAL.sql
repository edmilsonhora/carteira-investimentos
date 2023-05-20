USE [DBb3]
ALTER TABLE [dbo].[Ativos]
ADD [SaldoAtual] decimal(18,2) NOT NULL DEFAULT(0)

UPDATE [dbo].[Ativos]
SET [SaldoAtual] =[TotalInvestido]