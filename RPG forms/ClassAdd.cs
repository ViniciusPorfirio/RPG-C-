using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_forms
{
    public partial class ClassAdd : Form
    {

        public ClassAdd()
        {
            InitializeComponent();
        }

        private void AddClassBtn_Click(object sender, EventArgs e)
        {

            DAOs.ClassBase.DAOclassBase adicionar = new DAOs.ClassBase.DAOclassBase(); 

            adicionar.ClasseNome = TxtBxClassName.Text;
            adicionar.Strengh = Convert.ToInt32(TxtBxClassStr.Text);
            adicionar.Intell = Convert.ToInt32(TxtBxClassIntell.Text);
            adicionar.Charisma = Convert.ToInt32(TxtBxClassChar.Text);
            adicionar.Speed = Convert.ToInt32(TxtBxClassSpeed.Text);
            adicionar.HP = Convert.ToInt32(TxtBxClassHP.Text);

            adicionar.Insert(adicionar);
        }
    }
}
