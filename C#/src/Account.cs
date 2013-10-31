using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_project_Admin_Interface
{
    class Account
    {
        private int ID;
        private float balance;

        public Account(int ID, float balance)
        {
            this.ID = ID;
            this.balance = balance;
        }

        public void setID(int ID) { this.ID = ID; }
        public void setBalance(float balance) { this.balance = balance; }

        public int getID() { return this.ID; }
        public float getBalance() { return this.balance; }
    }
}
