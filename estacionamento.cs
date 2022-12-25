using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento
{
    public class Sistema
    {
        private decimal precoinicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public  Sistema(decimal precoinicial, decimal precoPorHora)
        {
            this.precoinicial = precoinicial;
            this.precoPorHora = precoPorHora;
        }
        
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar");
            string numCar = Console.ReadLine();
            veiculos.Add(numCar);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover");
        
            string placa = Console.ReadLine();
           

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int hora = 0;
                decimal valorTotal = 0;
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionados");
                hora = Convert.ToInt32(Console.ReadLine());

                valorTotal = precoinicial + precoPorHora * hora;
                
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }

            else 
            {
                Console.WriteLine("Desculpe, esse veículo não esta estacionado aqui. Confira se digitou a placa corretamente");
            }


        }
        public void Listarveiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são: ");
                foreach (string item in veiculos){
                    Console.WriteLine(item);
                }
                {
                    
                }

           
            }
            else{
                Console.WriteLine("Não há veiculos estacionados.");
            }
        }
    }
}      


           
