using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoppa.francesco._4I.Gelati
{
    public class Gelati : List<Gelati>
    {
        public int idGelato { get; set; }
        public TipoIngrediente Tipo { get; set; }
        public Gelati() { }

        public Gelati(string nomeFile)
        {
            StreamReader sr = new StreamReader("Persone.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                base.Add(new Gelato(sr.ReadLine()));

                sr.Close();
            }


        }
    }
}
