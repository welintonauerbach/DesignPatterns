using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// Prototype Pattern - Clona um classe
    /// </summary>
    public static class PrototypePattern
    {
        public static void CreateCars()
        {
            // Cria o carro 01
            var car1 = new Car{Model = "Palio",Brand = "Fiat", Year = 2010};
            
            // Cria a variável o carro 02 apontando para o mesmo carro 2
            var car2 = car1; /* neste cenário não está sendo criado um novo carro,
                              mas sim apontando p/ o mesmo endereço de memória do carro1
                             Teste para mostrar que aponta p/ o mesmo endereço de memória*/
            
            // Carro 3 usando Prototype Pattern
            var car3 = car1.ShallowCopy();
            
            Console.WriteLine("- Carro 01");
            Console.WriteLine($"\t{car1.Brand} | {car1.Model} | {car1.Year}");

            // Modifica carro 2
            car2.Year = 2015;
            car2.Model = "Uno";

            Console.WriteLine("- Carro 02 - modificao - Variávei são car1");
            Console.WriteLine($"\t{car1.Brand} | {car1.Model} | {car1.Year}");
            Console.WriteLine("O resultado será modificar o carro car1\n" +
                              "pois está apontando para o mesmo endereço de memória");

            Console.WriteLine(" - Carro 03 - usando Deepclone ou ShallowCopy");
            Console.WriteLine($"\t{car3.Brand} | {car3.Model} | {car3.Year}");
            Console.WriteLine("O resultado será um novo carro conforme car1 antes de ser modificado pelo car2");
        }
    }
}
