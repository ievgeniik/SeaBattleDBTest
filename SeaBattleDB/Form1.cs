using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattleDB
{
    public partial class labelUser : Form
    {
        DataAccess dataBase = new DataAccess();
        DataOperational operationalDB;

        public labelUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.setupConnection();
            if (dataBase.Login(textBoxLogin.Text, textBoxPassword.Text))
            {
                //MessageBox.Show("Login succesfull!");
                operationalDB = new DataOperational(dataBase);
                string userData = operationalDB.GetUserData(dataBase.UserID);
                MessageBox.Show(userData);
            }
            
        }
    }
}
