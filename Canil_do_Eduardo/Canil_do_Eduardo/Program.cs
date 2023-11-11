using System.Globalization;
namespace Canil_do_Eduardo
{
    internal class Program
    {
        
        class PetShop 
        {
            public string Nome { get; set; }
            public double Km { get; set; }
            public double ValorPequeno { get; set; }
            public double ValorGrande { get; set; }
            public double ValorPequenoFimSemana { get; set; }
            public double ValorGrandeFimSemana { get; set; }


        }

        class Valores 
        {
            public List<PetShop> ListaValor { get; set; }
            public string PetShopEscolhido { get; set; }

            public Valores()
            {
                ListaValor = new List<PetShop>
                {
                    new PetShop
                    {
                        Nome = "Meu Canino Feliz",
                        Km = 2.0,
                        ValorPequeno = 20.00,
                        ValorGrande = 40.00,
                        ValorPequenoFimSemana = (20*20)/100 + 20,
                        ValorGrandeFimSemana = (40*20)/100 + 40
                    },
                    new PetShop 
                    {
                        Nome = "Vai Rex",
                        Km = 1.7,
                        ValorPequeno = 15.00,
                        ValorGrande = 50.00,
                        ValorPequenoFimSemana = 20.00,
                        ValorGrandeFimSemana = 55.00
                    },
                    new PetShop 
                    {
                        Nome = "ChowChawgas",
                        Km = 0.8,
                        ValorPequeno = 30.00,
                        ValorGrande = 45.00,
                        ValorPequenoFimSemana = 30.00,
                        ValorGrandeFimSemana = 45.00
                    }
                };

            }
            private bool ValidarValoresIguais(double valor1, double valor2, double valor3) 
              => (valor1 == valor2 || valor1 == valor3 || valor2 == valor3 || (valor1 == valor2 && valor1 == valor3));

            private double BuscarMenor(double valor1, double valor2, double valor3)
            {
                double valorMenor = 0;

                if (ValidarValoresIguais(valor1, valor2, valor3))
                {
                    if (valor1 == valor2 && valor1 == valor3) // 3 valores iguais
                    {
                        PetShopEscolhido = ListaValor[0].Nome;
                        return valor1;
                    }
                    else if (valor1 == valor2 && valor1 < valor3) // 1 e 2 iguais
                    {
                        if (ListaValor[0].Km < ListaValor[1].Km)
                        {
                            PetShopEscolhido = ListaValor[0].Nome;
                            return valor1;

                        }
                        else
                        {
                            PetShopEscolhido = ListaValor[1].Nome;
                            return valor2;
                        }
                    }
                    else if (valor1 == valor2 && valor1 > valor3) // caso o 3 for o menor dos outros iguais
                    {

                        PetShopEscolhido = ListaValor[2].Nome;
                        return valor3;

                    }
                    else if (valor2 == valor3 && valor2 < valor1) // 2 e 3 iguais
                    {
                        if (ListaValor[1].Km < ListaValor[2].Km)
                        {
                            PetShopEscolhido = ListaValor[1].Nome;
                            return valor2;

                        }
                        else
                        {
                            PetShopEscolhido = ListaValor[2].Nome;
                            return valor3;
                        }
                    }
                    else if (valor2 == valor3 && valor2 > valor1) // caso o 1 for menor dos outros iguais
                    {
                     
                            PetShopEscolhido = ListaValor[0].Nome;
                            return valor1;
                        
                    }

                    else if (valor1 == valor3 && valor1 < valor2) // 1 e 3 iguais
                    {
                        if (ListaValor[0].Km < ListaValor[2].Km)
                        {
                            PetShopEscolhido = ListaValor[0].Nome;
                            return valor1;

                        }
                        else
                        {
                            PetShopEscolhido = ListaValor[2].Nome;
                            return valor3;
                        }
                    }
                    else if (valor1 == valor3 && valor1 > valor2) //caso o 2 for menor que os outros iguais
                    {

                        PetShopEscolhido = ListaValor[1].Nome;
                        return valor2;

                    }
                }
                else //se não existir valores iguais
                {
                    if (valor1 < valor2 && valor1 < valor3)
                    {
                        valorMenor = valor1;
                        PetShopEscolhido = ListaValor[0].Nome;
                    }
                    else if (valor2 < valor1 && valor2 < valor3)
                    {
                        valorMenor = valor2;
                        PetShopEscolhido = ListaValor[1].Nome;
                    }
                    else
                    {
                        PetShopEscolhido = ListaValor[2].Nome;
                        valorMenor = valor3;
                    }

                    return valorMenor;
                }
                return valorMenor;
            }

            public double CalcularValor(DateTime data, int pequeno, int grande)
            {
                double valorPequeno = 0, valorGrande = 0;
                double soma1 = 0, soma2 = 0, soma3 = 0;

                var diaSemana = data.DayOfWeek;
                if (diaSemana == DayOfWeek.Saturday || diaSemana == DayOfWeek.Sunday)
                {
                    valorPequeno = ListaValor[0].ValorPequenoFimSemana * pequeno;
                    valorGrande = ListaValor[0].ValorGrandeFimSemana * grande;
                    soma1 = valorPequeno + valorGrande;

                    valorPequeno = ListaValor[1].ValorPequenoFimSemana * pequeno;
                    valorGrande = ListaValor[1].ValorGrandeFimSemana * grande;
                    soma2 = valorPequeno + valorGrande;

                    valorPequeno = ListaValor[2].ValorPequenoFimSemana * pequeno;
                    valorGrande = ListaValor[2].ValorGrandeFimSemana * grande;
                    soma3 = valorPequeno + valorGrande;

                }
                else
                {
                    valorPequeno = ListaValor[0].ValorPequeno * pequeno;
                    valorGrande = ListaValor[0].ValorGrande * grande;
                    soma1 = valorPequeno + valorGrande;

                    valorPequeno = ListaValor[1].ValorPequeno * pequeno;
                    valorGrande = ListaValor[1].ValorGrande * grande;
                    soma2 = valorPequeno + valorGrande;

                    valorPequeno = ListaValor[2].ValorPequeno * pequeno;
                    valorGrande = ListaValor[2].ValorGrande * grande;
                    soma3 = valorPequeno + valorGrande;

                    
                }
              
                double menorValor = BuscarMenor(soma1, soma2, soma3);
                return menorValor;
            }

        }

        static string[] ImputDados()
        {
            string informacoes = Console.ReadLine(); // data, cão pequeno, cão grande
            return informacoes.Split(' ');

        }

        static void Main(string[] args)
        {
            List<string> resultados = new List<string>();
            string[] dados;
            dados = ImputDados();

            while (dados[0] != "0")
            {
                Valores valores = new Valores();
                var resultado = valores.CalcularValor(DateTime.Parse(dados[0]), int.Parse(dados[1]), int.Parse(dados[2]));
                resultados.Add($"{valores.PetShopEscolhido} - R$ {resultado.ToString("##0.00")}");
                dados = ImputDados();

            }

            for (int i =0; i < resultados.Count; i++)
            {
                Console.WriteLine(resultados[i]);
            }

         
            

            


        }
    }
}