using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smarthphone : ICallable, IBrowsable
    {
        private string model;

        public Smarthphone(string model)
        {
            this.model = model;
        }

        public string Browse(string website)
        {
            bool hasNumber = website.Any(char.IsNumber);

            if (hasNumber == true)
            {
                return website = "Invalid URL!";
            }
            return website = $"Browsing: {website}!";
        }

        public string Call(string phone)
        {
            bool hasCharacter = phone.Any(char.IsLetter);

            if (hasCharacter == true)
            {
               return phone = "Invalid number!";
            }
            return phone = $"Calling... {phone}";
        }
    }
}
