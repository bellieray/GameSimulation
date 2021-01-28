using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class PlayerInfo
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public  string Surname { get; set; }
        public  int Date { get; set; }
        public  string Username { get { return Surname.ToLower() + Name.ToLower() ; } set { Surname = value;  } }
    }
}
