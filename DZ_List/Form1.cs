using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            bool flag = true;
            bool flag2 = true;
           
            if (FunctionSelect.SelectedItem.ToString() == "Отсутствует")
            {



                for (int i = 0; i < StudentsList.Items.Count; i++)
                {

                    if (StudentsList.GetItemChecked(i))
                    {
                        {
                            for (int j = 0; j < listFalse.Items.Count; j++)
                            {
                                flag = StudentsList.Items[i] != listFalse.Items[j];
                            }
                            for (int j = 0; j < ListTrue.Items.Count; j++)
                            {
                                flag2 = StudentsList.Items[i] != ListTrue.Items[j];
                            }
                        }
                        if (flag2 && flag)
                            listFalse.Items.Add(StudentsList.Items[i].ToString());
                    }

                } 
                    
                
            }
            if (FunctionSelect.SelectedItem.ToString() == "Присутствует")
            {


                for (int i = 0; i < StudentsList.Items.Count; i++)
                {

                    if (StudentsList.GetItemChecked(i))
                    {
                        {
                            for (int j = 0; j < listFalse.Items.Count; j++)
                            {
                                flag = StudentsList.Items[i] != listFalse.Items[j];
                            }
                            for (int j = 0; j < ListTrue.Items.Count; j++)
                            {
                                flag2 = StudentsList.Items[i] != ListTrue.Items[j];
                            }
                        }
                        if (flag2 && flag)
                            ListTrue.Items.Add(StudentsList.Items[i].ToString());
                    }

                }


            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Вы действительно хотите выйте?", "Завершение работы", MessageBoxButtons.YesNo);
            if(rez == DialogResult.Yes)
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
