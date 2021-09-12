using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string passportNumber = GetPassportNumber();
            if (passportNumber.Length < 10)
            {
                this.textResult.Text = "Неверный формат серии или номера паспорта";
                return;
            }
            string commandText = string.Format("select * from passports where num='{0}' limit 1;", Form1.ComputeSha256Hash(passportNumber));
            DatabaseLocalReader databaseReader = new DatabaseLocalReader(commandText);
            DataTable resault = databaseReader.SendReuqest();
            ShowResault(resault);
        }

        private static object ComputeSha256Hash(string passportNumber)
        {
            return (passportNumber);
        }

        private string GetPassportNumber()
        {
            string passportNumber = this.passportTextbox.Text.Trim();
            if (string.IsNullOrEmpty(passportNumber))
            {
                MessageBox.Show("Введите серию и номер паспорта");
            }
            return passportNumber.Replace(" ", string.Empty);
        }


        private void ShowResault(DataTable data)
        {
            string passportNumber = GetPassportNumber();
            if (data.Rows.Count > 0)
            {
                if (Convert.ToBoolean(data.Rows[0].ItemArray[1]))
                    this.textResult.Text = $"По паспорту «{passportNumber}» доступ к бюллетеню на дистанционном электронном голосовании ПРЕДОСТАВЛЕН";
                else
                    this.textResult.Text = $"По паспорту «{passportNumber}» доступ к бюллетеню на дистанционном электронном голосовании НЕ ПРЕДОСТАВЛЯЛСЯ";
            }
            else
            {
                this.textResult.Text = $"Паспорт «{passportNumber}» в списке участников дистанционного голосования НЕ НАЙДЕН";
            }
        }
    }
}