using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _6___Esercitazione_Tablet
{
    class Tablet
    {
        // attributi
        private string _marca;
        private double _velocita;
        private double _schermo;
        private double _batteria;

        // costruttore
        public Tablet(string _marca, double _velocita, double _schermo, double _batteria)
        {
            Marca = _marca;
            Velocita = _velocita;
            Schermo = _schermo;
            Batteria = _batteria;
        }

        // metodi accessor
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public double Velocita
        {
            get { return _velocita; }
            set { _velocita = value; }
        }
        public double Schermo
        {
            get { return _schermo; }
            set { _schermo = value; }
        }
        public double Batteria
        {
            get { return _batteria; }
            set { _batteria = value; }
        }

        // metodi
        public string[] StampaDati(Tablet[] array)
        {
            string[] output = new string[5];
            for(int i = 0; i < 5; i++)
            {
                output[i] += $"La marca del tablet n.{i} è: {array[i].Marca}\n La velocita del tablet n.{i} è: {array[i].Velocita} GHz\n Le dimensioni dello schermo del tablet n.{i} sono: {array[i].Velocita} pollici\n La durata della batteria del tablet n.{i} è: {array[i].Batteria} mAh\n";
            }
            return output;
        }

        public double[] Punteggio(Tablet[] array)
        {
            double[] punteggio = new double[5];
            for(int i = 0; i < 5; i++)
            {
                punteggio[i] = (Math.Floor(array[i].Velocita) * 10);
                punteggio[i] += Math.Floor(array[i].Schermo);
                if (Math.Floor(array[i].Batteria) > 1000)
                    punteggio[i] += (Math.Floor(array[i].Batteria / 1000));
            }
            return punteggio;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Tablet[] t = new Tablet[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Inserire la marca del tablet n.{i}");
                    string marca = Console.ReadLine();
                    Console.WriteLine($"Inserire la velocita del tablet n.{i}");
                    double velocita = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire la dimensione dello schermo del tablet n.{i}");
                    double schermo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire la durata della tablet n.{i}");
                    double batteria = double.Parse(Console.ReadLine());
                    t[i] = new Tablet(marca, velocita, schermo, batteria);
                    Console.Clear();
                }
                string[] stampa = new string[5];
                stampa = t[0].StampaDati(t);
                Console.WriteLine(stampa);
            }
        }
    }
}
