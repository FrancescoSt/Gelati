using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoppa.francesco._4I.Gelati
{
    public enum TipoIngrediente { }
    public class Ingredienti : List<Ingredienti>
    {
        public int idGelati { get; set; }
        public TipoIngrediente Tipo { get; set; }
        public string Valore { get; set; }

        public Ingredienti(string riga)
        {
            string[] campi = riga.Split(';');

            if (campi.Count() != 3)
            {
                throw new Exception("Le righe devono essere di tre colonne");
            }
        }

    }
}
}
