using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Beb_site
    {
        private string? _name;
        private string? _path;
        private string? _description;
        private string? _ip;

        public Beb_site(string name, string path, string description, string ip)
        {
            setName(name);
            setPath(path);
            setDescription(description);
            setIp(ip);
        }
        public string? getName()
        {
            return this._name;
        }
        public void setName(string name)
        {
           this._name = name;
        }
        public string? getPath()
        {
            return this._path;
        }
        public void setPath(string path)
        {
            this._path = path;
        }
        public string? getDescription()
        {
            return this._description;
        }
        public void setDescription(string description)
        {
            this._description=description;
        }
        public string? getIp()
        {
            return this._ip;
        }
        public void setIp(string ip)
        {
            this._ip = ip;
        }

        public void printInfo()
        {
            Console.WriteLine(getName());
            Console.WriteLine(getPath());
            Console.WriteLine(getDescription());
            Console.WriteLine(getIp());
        }
    }
}
