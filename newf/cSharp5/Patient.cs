using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp5
{
    public class Patient
    {
        private string name;
        private string lastName;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set {lastName = value; }
        }
    }
}