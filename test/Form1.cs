using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        int selectedAccsCount = 0; //кол-во выбранных акков
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddAccs_Click(object sender, EventArgs e)
        {
            ToLog("Открываем файл");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                ToLog("Читаем файл");
                try
                {
                    int linesCount = 0;
                    while (!reader.EndOfStream)// читаем, пока не будет достигнут конец файла
                    {
                        string line = reader.ReadLine(); // читаем следующую строку
                        string[] accs_data = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                        dGV_Accs.Rows.Add(false, accs_data[0], accs_data[1], accs_data[2], "0/0", "", "");
                        linesCount++; // увеличиваем счетчик
                    }
                    lbl_countAllAccs.Text = Convert.ToString(linesCount);
                    ToLog("Добавлено " + linesCount + " акков");
                }
                catch (Exception ex)
                {
                    ToLog(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        // Добавление текста в лог
        public void ToLog(string text)
        {
            tB_log.AppendText(text+"\n");
        }

        // Доделать
        // Правильное окончание пример: (10, аккаунт, аккаута, аккаунтов) 
        public static string LastLetter(int numb, string first, string second, string third)
        {
            string fin;
            if (numb == 1)
            {
                return fin = Convert.ToString(numb) + " " + first;
            }
            else if(numb > 1 && numb < 5)
            {
                return fin = Convert.ToString(numb) + " " + second;
            }
            else if (numb > 1 && numb < 5)
            {
                return fin = Convert.ToString(numb) + " " + third;
            }
            return "gfddfg";
        }

        // Редактировать аккаунт(Двойной клик по строке)
        private void AccEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dGV_Accs.CurrentRow.Index);
            string login = Convert.ToString(dGV_Accs.CurrentRow.Cells["Col_Login"].Value);
            string pass = Convert.ToString(dGV_Accs.CurrentRow.Cells["Col_pass"].Value);
            string proxy = Convert.ToString(dGV_Accs.CurrentRow.Cells["Col_proxy"].Value);
            FormAccEdit formAccEdit = new FormAccEdit(id, login, pass, proxy);
            formAccEdit.Owner = this;
            formAccEdit.ShowDialog();            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Изменить аккаунт в списке
        public void NewFromAccEdit(int row_id, string login, string pass, string proxy)
        {
            dGV_Accs["Col_Login", row_id].Value = login;
            dGV_Accs["Col_pass", row_id].Value = pass;
            dGV_Accs["Col_proxy", row_id].Value = proxy;
            
        }

        private void dGV_Accs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_saveProj_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddWork_Click(object sender, EventArgs e)
        {
            FormAddWork FormAddWork = new FormAddWork();
            FormAddWork.Owner = this;
            FormAddWork.ShowDialog();
        }

        // Выбраны ли аккаунты?
        private bool isSelAcc()
        {
            if(selectedAccsCount < 1)
            {
                MessageBox.Show("Не выбран ни один аккаунт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
            
        }

        // Считаем выделенные аккаунты
        private void CountSelectedAccs()
        {
            selectedAccsCount = 0;
            for (int i = 0; i < dGV_Accs.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dGV_Accs["Col_Check", i].Value) == true)
                {
                    selectedAccsCount++;
                }
            }
            lbl_selAccs.Text = Convert.ToString(selectedAccsCount);
        }
        // Обработка события "Поставить галочку"
        private void dGV_Accs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CountSelectedAccs();
        }
        private void dGV_Accs_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).IsCurrentCellDirty) ((DataGridView)sender).CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        // Выделить все аккаунты
        private void btn_selAccsAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV_Accs.Rows.Count; i++)
            {
                dGV_Accs["Col_Check", i].Value = true;
            }
            selectedAccsCount = dGV_Accs.Rows.Count;
            lbl_selAccs.Text = Convert.ToString(selectedAccsCount);
        }
        // Снять все выделения
        private void btn_deselAccsAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV_Accs.Rows.Count; i++)
            {
                dGV_Accs["Col_Check", i].Value = false;
            }
            selectedAccsCount = 0;
            lbl_selAccs.Text = "0";
        }
        // Удалить все аккаунты
        private void btn_AccDel_Click(object sender, EventArgs e)
        {
            if (isSelAcc() == true)
            {
                ToLog("Удаляем " + Convert.ToString(selectedAccsCount) + " аккаунтов");
                for (int i = 0; i < dGV_Accs.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dGV_Accs["Col_Check", i].Value) == true)
                    {
                        dGV_Accs.Rows.RemoveAt(i);
                        i--;
                    }
                }
                CountSelectedAccs();
                lbl_countAllAccs.Text = Convert.ToString(dGV_Accs.Rows.Count); 
            }
        }

        // ПОСМОТРЕТЬ ПОВЕДЕНИЕ ПРИ ПОВТОРНОМ ДОБАВЛЕНИИ АККАУНТОВ
    }
}
