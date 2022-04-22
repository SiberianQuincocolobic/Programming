using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private string _number;
        public Contact()
        {

        }
        public Contact(string name, string surname,string number )
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (!long.TryParse(value, out long num))
                {
                    throw new ArgumentException("Номер должно состоять только из цифр");
                }

                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер должен состоять из 11 цифр");
                }

                _number = value;
            }
        }
    }
}
