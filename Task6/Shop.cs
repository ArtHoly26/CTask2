using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Shop
    {
        string? _name;
        string? _adress;
        string? _description;
        string? _telephonNumber;
        string? _mail;

        public Shop(string? name, string? adress, string? description, string? telephonNumber, string? mail)
        {
           setName(name);
           setAdress(adress);
           setDescription(description);
           setTelephonNumber(telephonNumber);
           setMail(mail);
        }

        public string? getName()
        {
            return this._name;
        }
        public void setName(string? name)
        {
            this._name = name;
        }
        public string? getAdress()
        {
            return this._adress;
        }
        public void setAdress(string? adress)
        {
            this._adress = adress;
        }
        public string? getDescription()
        {
            return this._description;
        }
        public void setDescription(string? description)
        {
            this._description = description;
        }
        public string? getTelephonNumber()
        {
            return this._telephonNumber;
        }
        public void setTelephonNumber(string? telephonNumber)
        {
            this._telephonNumber = telephonNumber;
        }
        public string? getMail()
        {
            return this._mail;
        }
        public void setMail(string? mail)
        {
            this._mail = mail;
        }

        public void printInfo()
        {
            Console.WriteLine(getName());
            Console.WriteLine(getAdress());
            Console.WriteLine(getDescription());
            Console.WriteLine(getTelephonNumber());
            Console.WriteLine(getMail());
        }

    }
}
