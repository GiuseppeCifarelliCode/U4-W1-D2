using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    internal class Televisione
    {
        public Boolean PowerOn;
        public int Volume;
        public int Canale;
        public Boolean Silenced;

        public Televisione() { }
        public Televisione(bool status, int volume, int canale)
        {
            PowerOn = status;
            Volume = volume;
            Canale = canale;

            if(Volume < 0 || Volume > 10) {
                Console.WriteLine("Volume non consentito");
                Console.ReadLine();

            if(Canale < 0 || Canale > 99)
                {
                    Console.WriteLine("Canale inesistente");
                    Console.ReadLine();
                }

            if(Volume == 0)
                {
                    Silenced = true;
                }
            }
        }

        public void PulsanteAccensione()
        {
            if(PowerOn == false) {
                PowerOn = true;
                Console.WriteLine("TV accesa");
            }
        }

        public void CanaleSuccessivo()
        {
            if (Canale == 99)
            {
                Console.WriteLine("Non esiste un canale successivo");
            }
            else
            {
                Canale += 1;
                Console.WriteLine("Passato al canale successivo! Sei su ITALIA1");
            }
        }

        public void CanalePrecedente()
        {
            if (Canale == 0)
            {
                Console.WriteLine("Non esiste un canale precedente");
            }
            else { 
                Canale -= 1;
                Console.WriteLine("Passato al canale precedente! Sei su ITALIA1");
            }
        }

        public void AumentaVolume()
        {
            if (Volume == 10)
            {
                Console.WriteLine("Volume al massimo");
            }
            else
            {
                Volume += 1;
                Console.WriteLine("Volume aumentato");
                if (Volume > 0)
                {
                    Silenced = false;
                }
            }
        }

        public void AbbassaVolume()
        {
            if (Volume == 0)
            {
                Console.WriteLine("Volume al minimo");
            }
            else
            {
                Volume -= 1;
                Console.WriteLine("Volume diminuito");
                if (Volume == 0)
                {
                    Silenced = true;
                }
            }
        }

        public void ImpostaCanale(int c)
        {
            if (c < 0 || c > 99)
            {
                Console.WriteLine("Canale inesistente");
            }
            else
            {
                Canale = c;
                Console.WriteLine("Canale cambiato");
            }
        }

        public void PulsanteSilenzioso()
        {
            Volume = 0;
            Silenced = true;
            Console.WriteLine("Passaggio in modalità silenziosa");
        }

        public string StatoTV()
        {
            if (PowerOn)
            {
                return " Canale " + Canale + " Volume " + Volume;
            }

            else return "La TV è spenta";
            
        }
    }
}
