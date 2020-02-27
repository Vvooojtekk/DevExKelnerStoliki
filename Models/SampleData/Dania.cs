using System;
using System.Collections.Generic;

namespace KelnerStoliki.Models.SampleData {
    public partial class SampleData {
        public static IEnumerable<Danie> Dania = new[] {
            new Danie {
                ID = 1,
                Name = "Naleśniki",
                Cena = 12
            },
            new Danie {
                ID = 2,
                Name = "Ryba",
                Cena = 13

            },
            new Danie {
                ID = 3,
                Name = "Kurczak",
                Cena = 14
            },
            new Danie {
                ID = 4,
                Name = "Pączek",
                Cena = 6
            },
            new Danie {
                ID = 5,
                Name = "Frytki",
                Cena = 7
            },
            new Danie {
                ID = 6,
                Name = "Burger",
                Cena = 9
            }
        };
    }
}
