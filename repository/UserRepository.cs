using Mail.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.repository
{
    class UserRepository : Repository<User>
    {
        public UserRepository()        
        {
            read();
        }

        protected override void read()
        {
            Console.WriteLine(connection);
            this.all = new List<User>();
            string sql = "select * from user";
            this.all = db.LoadData<User, dynamic>(sql, new { }, connection);
        }
        public override void print()
        {
            foreach(User u in all)
                Console.WriteLine(u.ToString());
        }
    }
}
