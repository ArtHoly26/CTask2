using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Journal
    {
        string? _name;
        DateTime _year;
        string? _description;
        string? _telephonNumber;
        string? _contactDate;

        public Journal(string? name, DateTime year, string? description, string? telephonNumber, string? contactDate)
        {
            setName(name);
            setYear(year);
            setdescription(description);
            setTelephonNumber(telephonNumber);
            setContactDate(contactDate);  
        }

        public string? getName()
        {
            return this._name;
        }
        public void setName(string name)
        {
          this._name = name;
        }
        public DateTime getYear()
        {
            return this._year;
        }
        public void setYear(DateTime year)
        {
            this._year = year;
        }
        public string? getDescription()
        {
            return this._description;
        }
        public void setdescription(string description)
        {
            this._description = description;
        }

        public string? getTelephonNumber()
        {
            return this._telephonNumber;
        }
        public void setTelephonNumber(string telephonNumber)
        {
            this._telephonNumber = telephonNumber;
        }
        public string? getContactDate()
        {
            return this._contactDate;
        }
        public void setContactDate(string contactDate)
        {
            this._contactDate = contactDate;
        }

        public void printInfo()
        {
            Console.WriteLine(getName());
            Console.WriteLine(getYear());
            Console.WriteLine(getDescription());
            Console.WriteLine(getTelephonNumber());
            Console.WriteLine(getContactDate());
        }

    }
}
