
       recomecar WebApI.Models
{
    public class Produto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int LowStock { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Descri��o: {Description}");
        Console.WriteLine($"Pre�o: R${Price:F2}");
        Console.WriteLine($"Estoque: {Stock} unidades");
    }

    public void AtualizarEstoque(int quantidade)
    {
        Stock += quantidade;

        // Verificar se o estoque m�nimo foi atingido
        if (Stock <= EstoqueMinimo)
        {
            NotificarAdministradorEstoqueMinimoAtingido();
        }

        Console.WriteLine($"Estoque atualizado: {Stock} unidades");
    }

    private void NotificarAdministradorEstoqueMinimoAtingido()
    {
        // L�gica para enviar notifica��o ao administrador (pode ser um email, mensagem, etc.)
        Console.WriteLine($"Aviso: Estoque m�nimo atingido para o produto {Name}. Estoque atual: {Stock} unidades.");
        
        foreach (var produto in produtos)
        {
            mensagem += $"{produto.Nome} - Estoque: {produto.QuantidadeEmEstoque}\n";
        }

        _emailService.EnviarEmail("admin@loja.com", "Estoque Baixo", mensagem);
    }
 }
}  
