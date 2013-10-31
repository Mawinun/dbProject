using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_project_Admin_Interface
{
    public partial class mainGUI : Form
    {
        const string serverIP = "194.47.129.139";
        const string dbName = "dv1454_ht13_5";
        const string dbpw = "pvdqVUv9";
        SqlConnection sqlConn = null;
        SqlCommand command = null;

        private List<AccountHolder> accountHolder = null;
        private List<Account> account = null;
        private ACA aca = null;

        int nrOfAHs = 0;
        int nrOfAccounts = 0;

        public mainGUI()
        {
            InitializeComponent();
            retrieveDBInfo();
            tab1_initLists();
        }


        public void retrieveDBInfo()
        {
            int iResult = 0;
            sqlConn = new SqlConnection("Data Source=" + serverIP + ";Initial Catalog=" + dbName + ";User ID=" + dbName + ";Password=" + dbpw);
            SqlParameter result = null;
            SqlParameter paraID = null;
            command = new SqlCommand();
            command.Connection = sqlConn;
            command.CommandType = CommandType.StoredProcedure;

            MessageBox.Show("Admin interface is launching.\nAfter you press OK, information will be downloaded from the database.\nPlease be patient.");

            try
            {
                sqlConn.Open();

                command.CommandText = "getAHCount";
                result = new SqlParameter("@result", SqlDbType.Int);
                result.Direction = ParameterDirection.Output;
                command.Parameters.Add(result);
                command.ExecuteNonQuery();
                iResult = (int)result.Value;
                this.nrOfAHs = iResult;
                accountHolder = new List<AccountHolder>();
                paraID = new SqlParameter();

                String ahName = null;
                String ahEmail = null;
                int ahIDnr = 0;
                int ahBirthdate = 0;
                string ahTelephone = null;
                int ahPin = 0;

                for (int i = 1; i <= iResult; i++)
                {
                    command.CommandText = "getAHid";
                    paraID.ParameterName = "@index";
                    paraID.SqlDbType = SqlDbType.Int;
                    paraID.Value = i;
                    result.SqlDbType = SqlDbType.Int;
                    command.Parameters.Clear();
                    command.Parameters.Add(paraID);
                    command.Parameters.Add(result);
                    command.ExecuteNonQuery();
                    ahIDnr = (int)result.Value;

                    command.CommandText = "getAHName";
                    paraID.ParameterName = "@AHid";
                    paraID.SqlDbType = SqlDbType.Int;
                    paraID.Value = ahIDnr;
                    result.SqlDbType = SqlDbType.VarChar;
                    result.Size = 80;
                    command.Parameters.Clear();
                    command.Parameters.Add(paraID);
                    command.Parameters.Add(result);
                    command.ExecuteNonQuery();
                    ahName = (string)result.Value;

                    command.CommandText = "getAHEmail";
                    result.Size = 225;
                    command.ExecuteNonQuery();
                    ahEmail = (string)result.Value;

                    command.CommandText = "getAHBirthdate";
                    result.SqlDbType = SqlDbType.Int;
                    command.ExecuteNonQuery();
                    ahBirthdate = (int)result.Value;

                    command.CommandText = "getAHTelephone";
                    result.SqlDbType = SqlDbType.VarChar;
                    result.Size = 80;
                    command.ExecuteNonQuery();
                    ahTelephone = (string)result.Value;

                    command.CommandText = "getAHPin";
                    result.SqlDbType = SqlDbType.Int;
                    command.ExecuteNonQuery();
                    ahPin = (int)result.Value;

                    accountHolder.Add(new AccountHolder(ahIDnr, ahName, ahBirthdate, ahTelephone, ahEmail, ahPin));
                }

                command.CommandText = "getACount";
                command.Parameters.Clear();
                command.Parameters.Add(result);
                command.ExecuteNonQuery();
                iResult = (int)result.Value;
                this.nrOfAccounts = iResult;
                account = new List<Account>();
                int aBalance = 0;
                int aIDnr = 0;

                for (int i = 1; i <= iResult; i++)
                {
                    command.CommandText = "getAid";
                    paraID.ParameterName = "@index";
                    paraID.SqlDbType = SqlDbType.Int;
                    paraID.Value = i;
                    result.SqlDbType = SqlDbType.Int;
                    command.Parameters.Clear();
                    command.Parameters.Add(paraID);
                    command.Parameters.Add(result);
                    command.ExecuteNonQuery();
                    aIDnr = (int)result.Value;

                    command.CommandText = "getABalance";
                    command.Parameters.Clear();
                    paraID.ParameterName = "@Aid";
                    paraID.Value = aIDnr;
                    command.Parameters.Add(paraID);
                    command.Parameters.Add(result);
                    command.ExecuteNonQuery();
                    aBalance = (int)result.Value;

                    account.Add(new Account(aIDnr, aBalance));
                }

                command.CommandText = "getAHACount";
                command.Parameters.Clear();
                command.Parameters.Add(result);
                command.ExecuteNonQuery();
                iResult = (int)result.Value;

                aca = new ACA();
                int ahID = 0;
                int aID = 0;

                for (int i = 1; i <= iResult; i++)
                {
                    command.CommandText = "getAHAAHid";
                    command.Parameters.Clear();
                    paraID.ParameterName = "@index";
                    paraID.Value = i;
                    command.Parameters.Add(paraID);
                    command.Parameters.Add(result);
                    command.ExecuteNonQuery();
                    ahID = (int)result.Value;

                    command.CommandText = "getAHAAid";
                    command.ExecuteNonQuery();
                    aID = (int)result.Value;

                    aca.addRelation(ahID, aID);
                }

            }
            finally
            {
                if (sqlConn != null)
                    sqlConn.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                tab1_initLists();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                tab2_initLists();
            }   
        }

        private void tab1_initLists()
        {
            page1AHLB.Items.Clear();
            for (int i = 0; i < accountHolder.Count; i++)
                page1AHLB.Items.Add(accountHolder[i].getID());
            page1AHLB.SetSelected(0,true);
        }

        private void tab2_initLists()
        {
            page2AccountLB.Items.Clear();
            for (int i = 0; i < account.Count; i++)
                page2AccountLB.Items.Add(account[i].getID());
            page2AccountLB.SetSelected(0, true);
        }

        private void page1AHLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = int.Parse(page1AHLB.GetItemText(page1AHLB.SelectedItem));
            List<int> temp = aca.findRelatedAccounts(selectedIndex);
            page1AccountLB.Items.Clear();
            if (temp.Count > 0)
            {
                for (int i = 0; i < temp.Count; i++)
                    page1AccountLB.Items.Add(temp[i]);
            }
            nameTB.Text = accountHolder[page1AHLB.SelectedIndex].getName();
            emailTB.Text = accountHolder[page1AHLB.SelectedIndex].getEmail();
            telephoneTB.Text = accountHolder[page1AHLB.SelectedIndex].getTelephone().ToString();
            birthdateTB.Text = accountHolder[page1AHLB.SelectedIndex].getBirthDate().ToString();
            pinTB.Text = accountHolder[page1AHLB.SelectedIndex].getPin().ToString();
        }

        private void page2AccountLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = int.Parse(page2AccountLB.GetItemText(page2AccountLB.SelectedItem));
            List<int> temp = aca.findRelatedAccountHolders(selectedIndex);
            page2AHLB.Items.Clear();
            if (temp.Count > 0)
            {
                for (int i = 0; i < temp.Count; i++)
                    page2AHLB.Items.Add(temp[i]);
            }
            balanceTB.Text = account[page2AccountLB.SelectedIndex].getBalance().ToString();
        }

        private void page2ClearButton_Click(object sender, EventArgs e)
        {
            balanceTB.Clear();
            AHlinkTB.Clear();
        }

        private void page1ClearButton_Click(object sender, EventArgs e)
        {
            nameTB.Clear();
            emailTB.Clear();
            telephoneTB.Clear();
            pinTB.Clear();
            birthdateTB.Clear();
        }

        private void addAHButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTB.Text) || String.IsNullOrEmpty(birthdateTB.Text) || String.IsNullOrEmpty(emailTB.Text)
                || String.IsNullOrEmpty(pinTB.Text) || String.IsNullOrEmpty(telephoneTB.Text))
            {
                MessageBox.Show("You cannot leave blank text fields!");
            }
            else
            {
                sqlConn = new SqlConnection("Data Source=" + serverIP + ";Initial Catalog=" + dbName + ";User ID=" + dbName + ";Password=" + dbpw);
                SqlParameter paraName = new SqlParameter("@name", SqlDbType.VarChar, 80);
                paraName.Value = nameTB.Text;
                SqlParameter paraBirthdate = new SqlParameter("@birthdate", SqlDbType.Int);
                paraBirthdate.Value = int.Parse(birthdateTB.Text);
                SqlParameter paraTelephone = new SqlParameter("@telephone", SqlDbType.VarChar, 20);
                paraTelephone.Value = telephoneTB.Text;
                SqlParameter paraEmail = new SqlParameter("@email", SqlDbType.VarChar, 225);
                paraEmail.Value = emailTB.Text;
                SqlParameter paraPin = new SqlParameter("@pin", SqlDbType.Int);
                paraPin.Value = int.Parse(pinTB.Text);
                command = new SqlCommand();
                command.Connection = sqlConn;
                command.CommandText = "addAccountHolder";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(paraName);
                command.Parameters.Add(paraBirthdate);
                command.Parameters.Add(paraTelephone);
                command.Parameters.Add(paraEmail);
                command.Parameters.Add(paraPin);
                
                try
                {
                    sqlConn.Open();
                    command.ExecuteNonQuery();
                    AccountHolder temp = new AccountHolder(nrOfAHs+1,nameTB.Text,int.Parse(birthdateTB.Text),telephoneTB.Text,emailTB.Text,int.Parse(pinTB.Text));
                    accountHolder.Add(temp);
                    nrOfAHs++;
                    MessageBox.Show("Account Holder has been added!");
                    tab1_initLists();
                }
                finally
                {
                    if (sqlConn != null)
                        sqlConn.Close();
                }
            }
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(balanceTB.Text) || String.IsNullOrEmpty(AHlinkTB.Text))
            {
                MessageBox.Show("You cannot leave blank text fields!");
            }
            else
            {
                int ahIDnr = int.Parse(AHlinkTB.Text);
                int ahBalance = int.Parse(balanceTB.Text);
                bool exists = false;
                for (int i = 0; i < accountHolder.Count && !exists; i++)
                    if (accountHolder[i].getID() == ahIDnr)
                        exists = true;
                if (!exists)
                {
                    MessageBox.Show("Account Holder could not be found!");
                }
                else
                {
                    sqlConn = new SqlConnection("Data Source=" + serverIP + ";Initial Catalog=" + dbName + ";User ID=" + dbName + ";Password=" + dbpw);
                    SqlParameter paraAHid = new SqlParameter("@ahID", SqlDbType.Int);
                    paraAHid.Value = ahIDnr;
                    SqlParameter paraBalance = new SqlParameter("@balance", SqlDbType.Int);
                    paraBalance.Value = ahBalance;
                    command = new SqlCommand();
                    command.Connection = sqlConn;
                    command.CommandText = "openAccount";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(paraAHid);
                    command.Parameters.Add(paraBalance);

                    try
                    {
                        sqlConn.Open();
                        command.ExecuteNonQuery();
                        Account temp = new Account(nrOfAccounts+1,ahBalance);
                        account.Add(temp);
                        aca.addRelation(ahIDnr,nrOfAccounts+1);
                        nrOfAccounts++;
                        MessageBox.Show("Account has been added!");
                        tab2_initLists();
                    }
                    finally
                    {
                        if (sqlConn != null)
                            sqlConn.Close();
                    }
                }
            }
        }

        private void linkAccountButton_Click(object sender, EventArgs e)
        {
            int AHid = -1;
            bool found = false;
            for(int i=0;i<accountHolder.Count && !found;i++)
            {
                if(accountHolder[i].getID().Equals(int.Parse(AHlinkTB.Text)))
                {
                    found = true;
                    AHid = int.Parse(AHlinkTB.Text);
                }
            }
            if (String.IsNullOrEmpty(balanceTB.Text) || String.IsNullOrEmpty(AHlinkTB.Text))
            {
                MessageBox.Show("Fill in the Account Handler box!");
            }
            else if (AHid == -1)
            {
                MessageBox.Show("Account Holder does not exist.");
            }
            else
            {
                int ahIDnr = int.Parse(AHlinkTB.Text);
                int aIDnr = int.Parse(page2AccountLB.GetItemText(page2AccountLB.SelectedItem));
                bool exists = false;
                for (int i = 0; i < accountHolder.Count && !exists; i++)
                    if (accountHolder[i].getID() == ahIDnr)
                        exists = true;
                if (!exists)
                {
                    MessageBox.Show("Account Holder could not be found!");
                }
                else if(aca.alreadyExists(ahIDnr,aIDnr))
                {
                    MessageBox.Show("An already existing relation has been detected.");
                }
                else
                {
                    sqlConn = new SqlConnection("Data Source=" + serverIP + ";Initial Catalog=" + dbName + ";User ID=" + dbName + ";Password=" + dbpw);
                    SqlParameter paraAHid = new SqlParameter("@lAHid", SqlDbType.Int);
                    paraAHid.Value = ahIDnr;
                    SqlParameter paraAid = new SqlParameter("@lAid", SqlDbType.Int);
                    paraAid.Value = aIDnr;
                    command = new SqlCommand();
                    command.Connection = sqlConn;
                    command.CommandText = "linkAccount";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(paraAHid);
                    command.Parameters.Add(paraAid);

                    try
                    {
                        sqlConn.Open();
                        command.ExecuteNonQuery();
                        aca.addRelation(ahIDnr, aIDnr);
                        MessageBox.Show("Account has been linked!");
                        tab2_initLists();
                    }
                    finally
                    {
                        if (sqlConn != null)
                            sqlConn.Close();
                    }
                }
            }
        }

        private void calcInterestButton_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            sqlConn = new SqlConnection("Data Source=" + serverIP + ";Initial Catalog=" + dbName + ";User ID=" + dbName + ";Password=" + dbpw);
            SqlParameter paraAid = new SqlParameter("@aID", SqlDbType.Int);
            SqlParameter result = new SqlParameter("@return", SqlDbType.Int);
            result.Value = 0;
            result.Direction = ParameterDirection.Output;
            command = new SqlCommand();
            command.Connection = sqlConn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "calculateInterests";

            try
            {
                sqlConn.Open();

                command.ExecuteNonQuery();

                command.CommandText = "cI";
                command.Parameters.Add(paraAid);
                command.Parameters.Add(result);

                for (int i = 0; i < account.Count; i++)
                {
                    paraAid.Value = account[i].getID();
                    command.ExecuteNonQuery();
                    iResult = (int)result.Value;
                    account[i].setBalance(iResult);
                }
                MessageBox.Show("Interest has been added to all accounts.");
                tab2_initLists();
            }
            finally
            {
                if (sqlConn != null)
                    sqlConn.Close();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            retrieveDBInfo();
            tab2_initLists();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fromTB.Text) || String.IsNullOrEmpty(toTB.Text) || String.IsNullOrEmpty(amountTB.Text))
            {
                MessageBox.Show("One or more more text boxes are empty.");
            }
            else
            {
                int iFrom = int.Parse(fromTB.Text);
                int iTo = int.Parse(toTB.Text);
                int commonAHid = aca.commonAccountHolder(iFrom, iTo);
                float iAmount = float.Parse(amountTB.Text);

                if (iFrom == iTo)
                {
                    MessageBox.Show("Cannot transfer to the same account!");
                }
                else if (commonAHid == -1)
                {
                    MessageBox.Show("No common account holder was found.");
                }
                else
                {
                    sqlConn = new SqlConnection("Data Source=" + serverIP + ";Initial Catalog=" + dbName + ";User ID=" + dbName + ";Password=" + dbpw);
                    SqlParameter paraAidFrom = new SqlParameter("@AidFrom", SqlDbType.Int);
                    SqlParameter paraAidTo = new SqlParameter("@AidTo", SqlDbType.Int);
                    SqlParameter paraAmount = new SqlParameter("@amount", SqlDbType.Float);
                    paraAidFrom.Value = iFrom;
                    paraAidTo.Value = iTo;
                    paraAmount.Value = iAmount;
                    command = new SqlCommand();
                    command.Connection = sqlConn;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "transferMoney";

                    command.Parameters.Add(paraAidFrom);
                    command.Parameters.Add(paraAidTo);
                    command.Parameters.Add(paraAmount);

                    try
                    {
                        sqlConn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Money has been transferred. ");
                        fromTB.Text = "";
                        toTB.Text = "";
                        amountTB.Text = "";
                    }
                    finally
                    {
                        if (sqlConn != null)
                            sqlConn.Close();
                    }
                }
            }
        }

    }
}
