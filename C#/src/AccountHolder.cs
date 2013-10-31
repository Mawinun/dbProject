using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_project_Admin_Interface
{
    public class AccountHolder
    {
        private int ID;
        private int birthdate;
        private string telephone;
        private int pin;
        private string name;
        private string email;

        public AccountHolder(int ID, string name, int birthdate, string telephone, string email, int pin)
        {
            this.ID = ID;
            this.birthdate = birthdate;
            this.telephone = telephone;
            this.pin = pin;
            this.name = name;
            this.email = email;
        }

        public void setID(int ID){this.ID = ID;}
        public void setBirthDate(int birthDate) {this.birthdate = birthDate;}
        public void setTelephone(string telephone) { this.telephone = telephone; }
        public void setPin(int pin){this.pin = pin;}
        public void setName(string name){this.name = name;}
        public void setEmail(string email) { this.email = email; }

        public int getID(){return this.ID;}
        public int getBirthDate(){return this.birthdate;}
        public string getTelephone(){return this.telephone;}
        public int getPin(){return this.pin;}
        public string getName(){return this.name;}
        public string getEmail() { return this.email; }
    }
}
