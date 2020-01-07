CREATE PROCEDURE[dbo].[ps_Itens_Por_Cliente] @clienteId int = 0
AS
BEGIN
SELECT
i.FaixaId,
i.ItemNotaFiscalId,
i.NotaFiscalId,
i.PrecoUnitario,
i.Quantidade,
i.PrecoUnitario* i.Quantidade As Total,
n.DataNotaFiscal,
f.Nome
FROM ItemNotaFiscal i
JOIN NotaFiscal n ON i.NotaFiscalId = n.NotaFiscalId
JOIN Faixa f ON f.FaixaId = i.FaixaId
WHERE n.ClienteId = @clienteId
END