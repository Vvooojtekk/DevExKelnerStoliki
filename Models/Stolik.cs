
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KelnerStoliki.Models.DataGrid;

namespace KelnerStoliki.Models
{
    //Klasa reprezentująca stolik, zawierająca listę zamówionych dań
    public class Stolik
    {
        //lista zamówionych pozycji
        public List<PrzedmiotZamowienia> Lista_zamowien { get; set; }
        public string Nazwa { get; set; }

    }
}