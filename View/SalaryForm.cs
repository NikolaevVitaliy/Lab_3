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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

namespace View
{
    public partial class SalaryForm : Form
    {

        private ObjectControl mainPersonControl = new ObjectControl();
        public PersonList list = new PersonList();


        public SalaryForm()
        {
            InitializeComponent();
            mainPersonControl.Parent = groupBoxInformationperson;
            mainPersonControl.Location = new System.Drawing.Point(7, 15);
            mainPersonControl.ReadOnly = true;
            mainPersonControl.Size = new System.Drawing.Size(738, 341);

            if (list.listPerson.Count != 0)
            {
                mainPersonControl.Person = list.listPerson[dataGridViewPerson.SelectedCells[0].RowIndex];
            }

        }

        JsonSerializer serializer = new JsonSerializer()
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include
        };




        //Кнопка добавления строки с данными о человеке в список через форму создания
        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            ModifyForm AddForma1 = new ModifyForm();
            AddForma1.ShowDialog();


            var person = AddForma1.modifyPerson;
            if (person == null)
            {
                return;
            }
            dataGridViewPerson.Rows.Add(person.FirstName, person.LastName, person.DateOfReceipt, person.GetSalary());
            list.listPerson.Add(person);
            mainPersonControl.Person = list.listPerson[dataGridViewPerson.SelectedCells[0].RowIndex];


        }

        //Кнопка удаления строки с данными о человеке из списка 
        private void buttonRemovePerson_Click(object sender, EventArgs e)
        {

            if (dataGridViewPerson.Rows.Count == 0)
            {
                MessageBox.Show("Список пуст!");
            }

            int removeIndex = dataGridViewPerson.CurrentCell.RowIndex;
            dataGridViewPerson.Rows.RemoveAt(removeIndex);
            list.listPerson.RemoveAt(removeIndex);


        }


        //Кнопка изменения данных в строке списка через форму создания фигуры
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewPerson.Rows.Count == 0)
            {
                MessageBox.Show("Список пуст!");
            }
            else
            {

                int modIndex = dataGridViewPerson.CurrentCell.RowIndex;
                ModifyForm AddModify = new ModifyForm();
                AddModify.modifyPerson = list.listPerson[modIndex];
                AddModify.ShowDialog();
                var newPerson = AddModify.modifyPerson;
                list.listPerson.Insert(dataGridViewPerson.SelectedCells[0].RowIndex, newPerson);
                list.listPerson.RemoveAt(dataGridViewPerson.SelectedCells[0].RowIndex + 1);
                dataGridViewPerson.Rows.Clear();
                foreach (var data in list.listPerson)
                {
                    dataGridViewPerson.Rows.Add(data.FirstName, data.LastName, data.DateOfReceipt, data.GetSalary());
                }

            }

        }


        //Поиск данных по фамилия человека
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridViewPerson.Rows.Count; i++)
            {
                dataGridViewPerson.ClearSelection();
                dataGridViewPerson.Rows[i].Visible = false;
                if (dataGridViewPerson[1, i].Value.ToString() == textBoxSearch.Text)
                {
                    dataGridViewPerson.Rows[i].Visible = true;
                }
            }
        }

        //Сериализация списка
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (list.listPerson.Count == 0)
            {
                MessageBox.Show("Список фигур пуст.");
            }

            saveFile.Filter = "Списки фигур (.db)|*.db";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, list.listPerson);
                }
                MessageBox.Show("Список сохранен.");
            }
        }

        //Десериализация списка
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Списки фигур (.db)|*.db";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFile.FileName))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    list.listPerson = (List<ISalary>) serializer.Deserialize(reader, typeof(List<ISalary>));
                    dataGridViewPerson.Rows.Clear();
                    foreach (var data in list.listPerson)
                    {
                        dataGridViewPerson.Rows.Add(data.FirstName, data.LastName, data.DateOfReceipt,
                            data.GetSalary());
                    }
                }
            }
        }

        private void dataGridViewPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridViewPerson.CurrentCell;
            int index = cell.RowIndex;
            mainPersonControl.Person = list.listPerson[index];

        }

       

       

      


    }

}