using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudTable.Properties;

namespace StudTable
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Visible = true;

            lblFolder.Text = Settings.Default.FolderPath;
            lblID.Text = Settings.Default.Id.ToString();
        }

        private void _buttonUpdate_Click(object sender, EventArgs e)
        {
            bool b = _txtBoxName.Text != null && _txtBoxLastName.Text != null && _txtBoxSurname.Text != null &&
                     dtpBirthday != null && _txtBirthPlace.Text != null && _txtMainCountry.Text != null &&
                     _txtSeriya.Text != null && _txtNumber.Text != null && datePass.Text != null &&
                     _txtKemVidan.Text != null && _txtCod.Text != null && _txtSnils.Text != null &&
                     _txtSvedRod.Text != null && _txtPhone.Text != null && comBspecialization.Text != null &&
                     comBFormEd.Text != null && _txtEdDocName.Text != null && comBEdLvl.Text != null &&
                     _txtEdDocGiver.Text != null && dtpEdDocGiveDate.Text != null && comBStudLang.Text != null &&
                     _txtAdressReg.Text != null;
            if (b == true)
            {
                FileCreat();
            }
            else
            {
                MessageBox.Show("Введите значения");
            }
        }

        private void FileCreat()
        {
            string name = _txtBoxSurname.Text + " " + _txtBoxName.Text + " " + _txtBoxLastName.Text;
            var helper = new WordTemplate("zayav.docx", name);

            string sex = null;
            string home = null;
            if (rBtnM.Checked)
            {
                sex = "Муж";
            }
            else if (rBtnF.Checked)
            {
                sex = "Жен";
            }
            else
            {
                MessageBox.Show("Выберите пол");
            }

            if (checkBox1.Checked)
            {
                home = "нуждаюсь";
            }
            else
            {
                home = "не нуждаюсь";
            }

            Dictionary<string, string> items = new Dictionary<string, string>
            {
                {"<ID>", Settings.Default.Id.ToString()},
                {"<_SurName>", _txtBoxSurname.Text},
                {"<_Name>", _txtBoxName.Text},
                {"<_LastName>", _txtBoxLastName.Text},
                {"<sex>", sex},
                {"<_Birthday>", dtpBirthday.Value.ToString("dd.MM.yyyy")},
                {"<_BirthPlace>", _txtBirthPlace.Text},
                {"<_MainCountry>", _txtMainCountry.Text},
                {"<Seriya>", _txtSeriya.Text},
                {"<Number>", _txtNumber.Text},
                {"<datePass>", datePass.Text},
                {"<Kem_Vidan>", _txtKemVidan.Text},
                {"<cod>", _txtCod.Text},
                {"<SNILS>", _txtSnils.Text},
                {"<SvedRod>", _txtSvedRod.Text},
                {"<Phone>", _txtPhone.Text},
                {"<Specialization>", comBspecialization.Text},
                {"<EdForm>", comBFormEd.Text},
                {"<EdFinForm>", lblEdFinForm.Text},
                {"<EdDocName>", _txtEdDocName.Text},
                {"<EdLvl>", comBEdLvl.Text},
                {"<EdDocNumber>", _txtEdDocNum.Text},
                {"<EdDocGiveDate>", dtpEdDocGiveDate.Value.ToString("dd.MM.yyyy")},
                {"<EdDocGiver>", _txtEdDocGiver.Text},
                {"<StudLang>", comBStudLang.Text},
                {"<AdressReg>", _txtAdressReg.Text},
                {"<EdHome>", home},
                {"<NewDate>", DateTime.Today.ToString("dd.MM.yyyy")}
            };

            helper.Process(items);
            lblID.Text = Settings.Default.Id.ToString();
            Settings.Default.Id += 1;
            Settings.Default.Save();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void _buttonAdd_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog())
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.FolderPath = fdb.SelectedPath;
                    lblFolder.Text = Settings.Default.FolderPath;
                }
            }
        }

        private void comBspecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBspecialization.Text == "49.02.01 Физическая культура" ||
                comBspecialization.Text == "44.02.02 Преподавание в начальных")
            {
                lblEdFinForm.Text = "Финансирование: из областного бюджета";
                comBFormEd.Enabled = true;
            }
            else if (comBspecialization.Text == "20.02.02 Защита в чрезвычайных ситуациях" ||
                     comBspecialization.Text == "20.02.04 Пожарная безопасность")
            {
                lblEdFinForm.Text = "Финансирование: по договорам об оказании платных образовательных услуг";
                comBFormEd.Text = "Очная";
                comBFormEd.Enabled = false;
            }
        }

        private void _txtSeriya_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number)) e.Handled = true;
        }

        private void _txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number)) e.Handled = true;
        }

        private void _txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number)) e.Handled = true;
        }

        private void _txtSnils_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number)) e.Handled = true;
        }

        private void _txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void _txtEdDocNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}