using System;
using System.Collections.Generic;

namespace MyHobbies
{

    public enum Geslacht
    {
        Man,
        Vrouw,
    }

    public class Band
    {
        public int Jaar { get; set; }

        public string Naam { get; set; }

        public List<Bandlid> Leden { get; set; }

    }





public class Bandlid {

    public int Leeftijd { get; set; }

    public string Naam { get; set; }

    public Geslacht Geslacht { get; set; }

    public bool Levend { get; set; }

}
}
