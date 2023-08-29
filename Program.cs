using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the name");
            string name = Console.ReadLine();
            Console.WriteLine("Insert the surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Insert the age");
            int age = Convert.ToInt32(Console.ReadLine());

            Persona user = new Persona(name, surname, age);
            Console.WriteLine(user.getDetails());
            Console.ReadLine();

            Console.WriteLine("Insert Product Name");
            string productName = Console.ReadLine();
            Console.WriteLine("Insert Product Price");
            double productPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert Product Quantity");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            Prodotto product = new Prodotto(productName, productPrice, productQuantity);
            Console.WriteLine("Total Cost= " + product.Total());
            Console.ReadLine();

            Console.WriteLine("La TV è accesa?");
            Boolean powerOn = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Volume di accensione=");
            int volume = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Canale=");
            int canale = Convert.ToInt32(Console.ReadLine());
            1
            Televisione televisione = new Televisione(powerOn, volume, canale);
            Console.WriteLine(televisione.StatoTV());
            Console.ReadLine();
            televisione.CanaleSuccessivo();
            televisione.AbbassaVolume();
            Console.Write("A che canale vuoi passare?");
            int c = Convert.ToInt32(Console.ReadLine());
            televisione.ImpostaCanale(c);
            televisione.PulsanteSilenzioso();
            Console.WriteLine(televisione.StatoTV());
            Console.ReadLine();

        }
    }
}
