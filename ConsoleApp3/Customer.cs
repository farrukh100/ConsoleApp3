using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Customer
    {
        private string name;
        private int id;

        public string Name
        {
            get
            {
              return name;
            }
            set
            {
                name = value;
            }
        }

        public int Id
        {
            get
            {
              return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
