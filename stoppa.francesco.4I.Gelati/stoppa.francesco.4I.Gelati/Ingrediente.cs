using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoppa.francesco._4I.Gelati
{
    public class Ingrediente : List<Ingredienti>
    {
        public int idGelato { get; set; }
        public TipoIngrediente Tipo { get; set; }

        public Ingrediente() { }

        public Ingrediente(string riga, string nomeFile)
        {
            string[] campi = riga.Split(';');

            if (campi.Count() != 3)
            {
                throw new Exception("Le righe devono essere di tre colonne");
            }

            //Conversione da stringa a intero
            int id = 0;
            int.TryParse(campi[0], out id);
            idGelato = id;


        }

        public void Lettura(string nomeFile)
        {
            StreamReader sr = new StreamReader("Ingredienti.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                this.Add(new Ingredienti(sr.ReadLine()));

                sr.Close();


            }
        }
    }
}
