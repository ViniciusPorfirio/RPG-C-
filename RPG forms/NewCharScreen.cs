using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace RPG_forms
{

    public partial class NewCharScreen : Form
    {


        DAOs.ClassBase.DAOclassBase Search = new DAOs.ClassBase.DAOclassBase();

        public NewCharScreen()
        {
            InitializeComponent();
        }




        private void LoadPicBtt_Click(object sender, EventArgs e)
        {


        }



        private void NewCharScreen_Load(object sender, EventArgs e)
        {
            //Data Grid Test
            DataTable dt = Search.Search();
            dataGridClassTest.DataSource = dt;

            //Combo Box Classe
            string filter = "ClasseNome";
            DataTable dt2 = Search.FillCombox(filter);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                SelClassCombox.Items.Add(dt2.Rows[i][filter]);
            }
        }

        private void SelClassCombox_SelectedValueChanged(object sender, EventArgs e)
        {
            string classe;
            classe = SelClassCombox.SelectedItem.ToString();

            DataTable dt = Search.ClassSelection(classe);

            labelStr.Text = dt.Rows[0].Field<int>(2).ToString();
            labelIntell.Text = dt.Rows[0].Field<int>(3).ToString();
            labelChar.Text = dt.Rows[0].Field<int>(4).ToString();
            labelSpd.Text = dt.Rows[0].Field<int>(5).ToString();
            labelHP.Text = dt.Rows[0].Field<int>(6).ToString();
        }
    }
}
