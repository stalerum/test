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
        FormAccEdit FormAccEdit;

        public Form1()
        {
            InitializeComponent();
        }

        private void dGV_Accs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AddAccs_Click(object sender, EventArgs e)
        {
            ToLog("Открываем файл");
            //openFileDialog1.ShowDialog();
            FileStream file = new FileStream("C:/Users/Антон/Desktop/test/accs.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            ToLog("Читаем файл");
            //Читаем и добавляем в таблицу
            try
            {
                int linesCount = 0;
                while (!reader.EndOfStream)// читаем, пока не будет достигнут конец файла
                {
                    string line = reader.ReadLine(); // читаем следующую строку
                    string[] accs_data = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    dGV_Accs.Rows.Add(accs_data[0], accs_data[1], accs_data[2], "10/500", "Работает");
                    linesCount++; // увеличиваем счетчик
                }
                ToLog("Добавлено "+ linesCount + " акков");
            }
            catch (Exception ex)
            {

                ToLog(ex.Message);
            }
            finally
            {
                reader.Close();
            }
            //
            string test = Convert.ToString(dGV_Accs.CurrentRow.Cells[1].Value);
            ToLog(test);
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
            string login = Convert.ToString(dGV_Accs.CurrentRow.Cells[0].Value);
            string pass = Convert.ToString(dGV_Accs.CurrentRow.Cells[1].Value);
            string proxy = Convert.ToString(dGV_Accs.CurrentRow.Cells[2].Value);
            FormAccEdit FormAccEdit = new FormAccEdit(login, pass, proxy);
            FormAccEdit.Show();

            /*
            if (FormAccEdit.DialogResult == DialogResult.OK)
            {
                ToLog("gfdgf");
            }else
            {
                ToLog("нет данных");
            }
                ToLog(FormAccEdit.ReturnData());
                */
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToLog(FormAccEdit.ReturnData());
        }
    }
}
