using System;
using VeiculoList;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        protected List<Veiculo> Veiculos { get; set; }

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        Veiculos = new List<Veiculo>();
    }

    public void AdicionarVeiculo()
    {
        var veiculo = new Veiculo();

        Console.WriteLine("Digite a placa do veículo para estacionar:");
        veiculo.Placa = Console.ReadLine();
        veiculo.Placa = veiculo.Placa.ToUpper();

        veiculos.Add(placa);
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placaASerRemovida = Console.ReadLine();
        string placa = "";

        // Verifica se o veículo existe
        if (veiculos.Any())
        {

                var checagem = veiculos.Where(x => x.placa);
                    Console.WriteLine("Digite a quantidade de h3oras que o veículo permaneceu estacionado:");

            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
            // *IMPLEMENTE AQUI*
            int horas = 0;
            decimal valorTotal = 0;

            // TODO: Remover a placa digitada da lista de veículos
            // *IMPLEMENTE AQUI*

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var item in veiculos)
            {
                Console.WriteLine(item);
            }


        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
    }

