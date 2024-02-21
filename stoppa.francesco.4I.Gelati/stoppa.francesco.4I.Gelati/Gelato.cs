using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoppa.francesco._4I.Gelati
{
    public class Gelato : Gelati
    {
        public int idGelato { get; set; }
        public TipoIngrediente Tipo { get; set; }
        public Gelato() { }

        public Gelato(string riga)
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
}
