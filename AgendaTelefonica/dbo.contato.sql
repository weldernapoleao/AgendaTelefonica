CREATE TABLE [dbo].[contato]
(
	[contatoId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nomecontato] VARCHAR(50) NOT NULL, 
    [empresa] VARCHAR(50) NULL, 
    [email] VARCHAR(50) NULL, 
    [telefone] VARCHAR(50) NOT NULL, 
    [cliente] BIT NULL, 
    [ultimocontato] DATE NULL
)
