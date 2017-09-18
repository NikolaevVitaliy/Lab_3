using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;



namespace View
{
    public partial class ModifyForm : Form
    {


        private ObjectControl modifyPersonControl = new ObjectControl();

        public ISalary modifyPerson;
        public ModifyForm()
        {
            InitializeComponent();


            modifyPersonControl.Parent = groupBoxModifyPerson;
            modifyPersonControl.Location = new Point(12, 14);
            modifyPersonControl.ReadOnly = false;
            modifyPersonControl.Size = new Size(906, 364);
            
             
        }

        public ModifyForm(int numRow, PersonList list)
        {
            InitializeComponent();

            modifyPersonControl.Parent = groupBoxModifyPerson;
            modifyPersonControl.Location = new Point(12, 14);
            modifyPersonControl.ReadOnly = false;
            modifyPersonControl.Size = new Size(738, 341);
            modifyPersonControl.Person = list.listPerson[numRow];
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            modifyPerson = null;
            Close();
        }

        private void buttonОК_Click(object sender, EventArgs e)
        {
            if (modifyPersonControl.ExitCondition)
            {
                modifyPerson = modifyPersonControl.Person;
                Close();
            }
        }

       

        private void buttonCalculateSalary_Click(object sender, EventArgs e)
        {
            modifyPerson = modifyPersonControl.Person;
            modifyPerson.GetSalary();
            modifyPersonControl.Person = modifyPerson;
           
        }


























    }
}
