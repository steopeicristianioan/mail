using DataAccessLibrary.NETFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.repository
{
    class Repository<T>
    {
        protected List<T> all;
        public List<T> All { get => this.all; set => this.all = value; }

        protected MySqlDataAccess db = new MySqlDataAccess();
        protected string connection = UsefulMethods.getConnectionString("Default");

        protected virtual void read() { }
        public virtual void print() { }
    }
}
