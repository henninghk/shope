using System;
using System.Collections.Generic;
using System.Text;

namespace shope
{
    class Animal
    {
        public string Name, Race;
        public int Age;
        public bool Friendly;

        public Animal(string _name, string _race, int _age, bool _friendly)
        {
            Name = _name;
            Race = _race;
            Age = _age;
            Friendly = _friendly;
        }
        //public string MakeAnimalNameStr()
        //{
        //    var str = $"Animal Name : {Name}\n";
        //    return str;
        //}
        //public string MakeAnimalRaceStr()
        //{
        //    var str = $"Animal Race : {Race}\n";
        //    return str;
        //}
        //public string MakeAnimalAgeStr()
        //{
        //    var str = $"Animal Age : {Age}\n";
        //    return str;
        //}
        //public string MakeAnimalKnownStr()
        //{
        //    var str = $"Animal Friendly : {Friendly}\n";
        //    return str;
        //}
    }
}
