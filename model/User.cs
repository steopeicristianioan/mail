using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.model
{
    class User
    {
        private int id;
        private string email;
        private string password;
        private DateTime created_at;
        private DateTime last_log;

        //getters and setters
        #region
        public int ID { get => this.id; set => this.id = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Password { get => this.password; set => this.password = value; }
        public DateTime Created_At { get => this.created_at; set => this.created_at = value; }
        public DateTime Last_Log { get => this.last_log; set => this.last_log = value; }
        #endregion

        public User() { }
        public User(int id, string email, string password, 
            DateTime created_at, DateTime last_log)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.created_at = created_at;
            this.last_log = last_log;
        }

        public override string ToString()
        {
            return this.email + " | " + this.created_at.ToString("f");
        }
        public override bool Equals(object obj)
        {
            User other = (User)obj;
            return this.id == other.id;
        }
        public override int GetHashCode()
        {
            return this.id;
        }
    }
}
