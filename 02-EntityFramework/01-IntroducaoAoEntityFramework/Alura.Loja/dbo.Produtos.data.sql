SET IDENTITY_INSERT [dbo].[Produtos] ON
INSERT INTO [dbo].[Produtos] ([Id], [Nome], [Categoria], [Preco]) VALUES (1, N'Harry Potter e a Ordem da Fênix', N'Livros', 19.89)
SET IDENTITY_INSERT [dbo].[Produtos] OFF

DELETE FROM [dbo].Produtos;