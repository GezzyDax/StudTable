using System.ComponentModel;

namespace StudTable
{
    partial class MainForm
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///     Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rBtnF = new System.Windows.Forms.RadioButton();
            this.rBtnM = new System.Windows.Forms.RadioButton();
            this.lblID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtBoxLastName = new System.Windows.Forms.TextBox();
            this._buttonUpdate = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._txtBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this._txtMainCountry = new System.Windows.Forms.TextBox();
            this._txtBirthPlace = new System.Windows.Forms.TextBox();
            this._txtSeriya = new System.Windows.Forms.TextBox();
            this.datePass = new System.Windows.Forms.DateTimePicker();
            this._txtKemVidan = new System.Windows.Forms.TextBox();
            this._txtSnils = new System.Windows.Forms.TextBox();
            this._txtSvedRod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtNumber = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this._txtCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtPhone = new System.Windows.Forms.TextBox();
            this.comBspecialization = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEdFinForm = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comBFormEd = new System.Windows.Forms.ComboBox();
            this._txtEdDocName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comBEdLvl = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comBStudLang = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this._txtEdDocNum = new System.Windows.Forms.TextBox();
            this.dtpEdDocGiveDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this._txtEdDocGiver = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this._txtAdressReg = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rBtnF
            // 
            this.rBtnF.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.rBtnF.Location = new System.Drawing.Point(165, 103);
            this.rBtnF.Name = "rBtnF";
            this.rBtnF.Size = new System.Drawing.Size(51, 32);
            this.rBtnF.TabIndex = 5;
            this.rBtnF.TabStop = true;
            this.rBtnF.Text = "Ж";
            this.rBtnF.UseVisualStyleBackColor = true;
            // 
            // rBtnM
            // 
            this.rBtnM.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.rBtnM.Location = new System.Drawing.Point(108, 103);
            this.rBtnM.Name = "rBtnM";
            this.rBtnM.Size = new System.Drawing.Size(51, 32);
            this.rBtnM.TabIndex = 4;
            this.rBtnM.TabStop = true;
            this.rBtnM.Text = "М";
            this.rBtnM.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(5, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Дата выдачи";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 381);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 65);
            this.label14.TabIndex = 32;
            this.label14.Text = "Свидетельво о рождении\r\n\r\n\r\nНомер\r\nКем выдан\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Серия";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(57, 361);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "СНИЛС";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Место рождения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Код подразделения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Дата рождения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Кем выдан";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Гражданство";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Отчество";
            // 
            // _txtBoxLastName
            // 
            this._txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtBoxLastName.Location = new System.Drawing.Point(108, 73);
            this._txtBoxLastName.Name = "_txtBoxLastName";
            this._txtBoxLastName.Size = new System.Drawing.Size(250, 24);
            this._txtBoxLastName.TabIndex = 3;
            // 
            // _buttonUpdate
            // 
            this._buttonUpdate.Location = new System.Drawing.Point(7, 607);
            this._buttonUpdate.Name = "_buttonUpdate";
            this._buttonUpdate.Size = new System.Drawing.Size(100, 27);
            this._buttonUpdate.TabIndex = 16;
            this._buttonUpdate.Text = "Сохранить";
            this._buttonUpdate.UseVisualStyleBackColor = true;
            this._buttonUpdate.Click += new System.EventHandler(this._buttonUpdate_Click);
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(7, 574);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(100, 27);
            this._buttonAdd.TabIndex = 17;
            this._buttonAdd.Text = "Изменить путь";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this._buttonAdd_Click);
            // 
            // _txtBoxName
            // 
            this._txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtBoxName.Location = new System.Drawing.Point(108, 43);
            this._txtBoxName.Name = "_txtBoxName";
            this._txtBoxName.Size = new System.Drawing.Size(250, 24);
            this._txtBoxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фамилия";
            // 
            // _txtBoxSurname
            // 
            this._txtBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtBoxSurname.Location = new System.Drawing.Point(108, 13);
            this._txtBoxSurname.Name = "_txtBoxSurname";
            this._txtBoxSurname.Size = new System.Drawing.Size(250, 24);
            this._txtBoxSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(108, 176);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(250, 20);
            this.dtpBirthday.TabIndex = 7;
            // 
            // _txtMainCountry
            // 
            this._txtMainCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtMainCountry.Location = new System.Drawing.Point(108, 141);
            this._txtMainCountry.Name = "_txtMainCountry";
            this._txtMainCountry.Size = new System.Drawing.Size(250, 24);
            this._txtMainCountry.TabIndex = 6;
            // 
            // _txtBirthPlace
            // 
            this._txtBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtBirthPlace.Location = new System.Drawing.Point(108, 202);
            this._txtBirthPlace.Name = "_txtBirthPlace";
            this._txtBirthPlace.Size = new System.Drawing.Size(250, 24);
            this._txtBirthPlace.TabIndex = 8;
            // 
            // _txtSeriya
            // 
            this._txtSeriya.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtSeriya.Location = new System.Drawing.Point(108, 232);
            this._txtSeriya.Name = "_txtSeriya";
            this._txtSeriya.Size = new System.Drawing.Size(60, 24);
            this._txtSeriya.TabIndex = 9;
            this._txtSeriya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtSeriya_KeyPress);
            // 
            // datePass
            // 
            this.datePass.Location = new System.Drawing.Point(108, 268);
            this.datePass.Name = "datePass";
            this.datePass.Size = new System.Drawing.Size(250, 20);
            this.datePass.TabIndex = 11;
            // 
            // _txtKemVidan
            // 
            this._txtKemVidan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtKemVidan.Location = new System.Drawing.Point(108, 294);
            this._txtKemVidan.Name = "_txtKemVidan";
            this._txtKemVidan.Size = new System.Drawing.Size(250, 24);
            this._txtKemVidan.TabIndex = 12;
            // 
            // _txtSnils
            // 
            this._txtSnils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtSnils.Location = new System.Drawing.Point(108, 354);
            this._txtSnils.Name = "_txtSnils";
            this._txtSnils.Size = new System.Drawing.Size(250, 24);
            this._txtSnils.TabIndex = 14;
            this._txtSnils.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtSnils_KeyPress_1);
            // 
            // _txtSvedRod
            // 
            this._txtSvedRod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtSvedRod.Location = new System.Drawing.Point(108, 396);
            this._txtSvedRod.Multiline = true;
            this._txtSvedRod.Name = "_txtSvedRod";
            this._txtSvedRod.Size = new System.Drawing.Size(250, 79);
            this._txtSvedRod.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Номер";
            // 
            // _txtNumber
            // 
            this._txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtNumber.Location = new System.Drawing.Point(222, 232);
            this._txtNumber.Name = "_txtNumber";
            this._txtNumber.Size = new System.Drawing.Size(136, 24);
            this._txtNumber.TabIndex = 10;
            this._txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtNumber_KeyPress);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(118, 581);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(0, 13);
            this.lblFolder.TabIndex = 32;
            // 
            // _txtCod
            // 
            this._txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtCod.Location = new System.Drawing.Point(108, 322);
            this._txtCod.Name = "_txtCod";
            this._txtCod.Size = new System.Drawing.Size(250, 24);
            this._txtCod.TabIndex = 13;
            this._txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtCod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Номер телефона";
            // 
            // _txtPhone
            // 
            this._txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtPhone.Location = new System.Drawing.Point(108, 481);
            this._txtPhone.Name = "_txtPhone";
            this._txtPhone.Size = new System.Drawing.Size(250, 24);
            this._txtPhone.TabIndex = 16;
            this._txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPhone_KeyPress);
           
            // 
            // comBspecialization
            // 
            this.comBspecialization.FormattingEnabled = true;
            this.comBspecialization.Items.AddRange(new object[] {"49.02.01 Физическая культура", "44.02.02 Преподавание в начальных", "20.02.02 Защита в чрезвычайных ситуациях", "20.02.04 Пожарная безопасность"});
            this.comBspecialization.Location = new System.Drawing.Point(108, 511);
            this.comBspecialization.Name = "comBspecialization";
            this.comBspecialization.Size = new System.Drawing.Size(250, 21);
            this.comBspecialization.TabIndex = 17;
            this.comBspecialization.SelectedIndexChanged += new System.EventHandler(this.comBspecialization_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Специальность";
            // 
            // lblEdFinForm
            // 
            this.lblEdFinForm.AutoSize = true;
            this.lblEdFinForm.Location = new System.Drawing.Point(364, 511);
            this.lblEdFinForm.Name = "lblEdFinForm";
            this.lblEdFinForm.Size = new System.Drawing.Size(0, 13);
            this.lblEdFinForm.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"49.02.01 Физическая культура", "44.02.02 Преподавание в начальных", "20.02.02 Защита в чрезвычайных ситуациях", "20.02.04 Пожарная безопасность"});
            this.comboBox1.Location = new System.Drawing.Point(404, 975);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // comBFormEd
            // 
            this.comBFormEd.FormattingEnabled = true;
            this.comBFormEd.Items.AddRange(new object[] {"Заочная", "Очная"});
            this.comBFormEd.Location = new System.Drawing.Point(108, 538);
            this.comBFormEd.Name = "comBFormEd";
            this.comBFormEd.Size = new System.Drawing.Size(250, 21);
            this.comBFormEd.TabIndex = 18;
            this.comBFormEd.Text = "Очная";
            // 
            // _txtEdDocName
            // 
            this._txtEdDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtEdDocName.Location = new System.Drawing.Point(509, 20);
            this._txtEdDocName.Name = "_txtEdDocName";
            this._txtEdDocName.Size = new System.Drawing.Size(198, 24);
            this._txtEdDocName.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 26);
            this.label15.TabIndex = 15;
            this.label15.Text = "Название документа \r\nоб оброзовании";
            // 
            // comBEdLvl
            // 
            this.comBEdLvl.FormattingEnabled = true;
            this.comBEdLvl.Items.AddRange(new object[] {"СРЕДНЕЕ  ОБЩЕЕ", "ОСНОВНОЕ ОБЩЕЕ        "});
            this.comBEdLvl.Location = new System.Drawing.Point(509, 50);
            this.comBEdLvl.Name = "comBEdLvl";
            this.comBEdLvl.Size = new System.Drawing.Size(198, 21);
            this.comBEdLvl.TabIndex = 20;
            this.comBEdLvl.SelectedIndexChanged += new System.EventHandler(this.comBspecialization_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(383, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Уровень образование";
            // 
            // comBStudLang
            // 
            this.comBStudLang.FormattingEnabled = true;
            this.comBStudLang.Items.AddRange(new object[] {"Английский", "Немецкий", "Французский", "Китайский"});
            this.comBStudLang.Location = new System.Drawing.Point(509, 199);
            this.comBStudLang.Name = "comBStudLang";
            this.comBStudLang.Size = new System.Drawing.Size(198, 21);
            this.comBStudLang.TabIndex = 24;
            this.comBStudLang.SelectedIndexChanged += new System.EventHandler(this.comBspecialization_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(409, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Изучаемый язык";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(392, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Адресс регистрации";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(405, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Номер документа";
            // 
            // _txtEdDocNum
            // 
            this._txtEdDocNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtEdDocNum.Location = new System.Drawing.Point(509, 77);
            this._txtEdDocNum.Name = "_txtEdDocNum";
            this._txtEdDocNum.Size = new System.Drawing.Size(198, 24);
            this._txtEdDocNum.TabIndex = 21;
            this._txtEdDocNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEdDocNum_KeyPress);
            // 
            // dtpEdDocGiveDate
            // 
            this.dtpEdDocGiveDate.Location = new System.Drawing.Point(509, 107);
            this.dtpEdDocGiveDate.Name = "dtpEdDocGiveDate";
            this.dtpEdDocGiveDate.Size = new System.Drawing.Size(198, 20);
            this.dtpEdDocGiveDate.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(430, 113);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "Дата выдачи";
            // 
            // _txtEdDocGiver
            // 
            this._txtEdDocGiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtEdDocGiver.Location = new System.Drawing.Point(509, 133);
            this._txtEdDocGiver.Multiline = true;
            this._txtEdDocGiver.Name = "_txtEdDocGiver";
            this._txtEdDocGiver.Size = new System.Drawing.Size(198, 60);
            this._txtEdDocGiver.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(440, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "Кем выдан";
            // 
            // _txtAdressReg
            // 
            this._txtAdressReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._txtAdressReg.Location = new System.Drawing.Point(509, 226);
            this._txtAdressReg.Multiline = true;
            this._txtAdressReg.Name = "_txtAdressReg";
            this._txtAdressReg.Size = new System.Drawing.Size(198, 140);
            this._txtAdressReg.TabIndex = 25;
            this._txtAdressReg.Text = "почтовый индекс, область, район, населенный пункт, улица, дом, квартира";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(509, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 26);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Нуждаюсь в общежитие";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(921, 642);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comBFormEd);
            this.Controls.Add(this.comBStudLang);
            this.Controls.Add(this.comBEdLvl);
            this.Controls.Add(this.comBspecialization);
            this.Controls.Add(this._txtEdDocGiver);
            this.Controls.Add(this._txtEdDocNum);
            this.Controls.Add(this._txtNumber);
            this.Controls.Add(this._txtSeriya);
            this.Controls.Add(this._txtAdressReg);
            this.Controls.Add(this._txtSvedRod);
            this.Controls.Add(this._txtSnils);
            this.Controls.Add(this._txtCod);
            this.Controls.Add(this._txtPhone);
            this.Controls.Add(this._txtKemVidan);
            this.Controls.Add(this._txtBirthPlace);
            this.Controls.Add(this._txtMainCountry);
            this.Controls.Add(this.datePass);
            this.Controls.Add(this.dtpEdDocGiveDate);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.rBtnF);
            this.Controls.Add(this.rBtnM);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtBoxLastName);
            this.Controls.Add(this._buttonUpdate);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._txtBoxName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEdFinForm);
            this.Controls.Add(this._txtEdDocName);
            this.Controls.Add(this._txtBoxSurname);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBox1;

        // private System.Windows.Forms.Button btnParrentForm;
        private System.Windows.Forms.ComboBox comBEdLvl;
        private System.Windows.Forms.TextBox _txtEdDocNum;
        private System.Windows.Forms.TextBox _txtAdressReg;
        private System.Windows.Forms.ComboBox comBStudLang;
        private System.Windows.Forms.TextBox _txtEdDocGiver;
        private System.Windows.Forms.DateTimePicker dtpEdDocGiveDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox _txtEdDocName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comBFormEd;
        private System.Windows.Forms.Label lblEdFinForm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comBspecialization;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtPhone;
        private System.Windows.Forms.TextBox _txtCod;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox _txtNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtKemVidan;
        private System.Windows.Forms.TextBox _txtSvedRod;
        private System.Windows.Forms.DateTimePicker datePass;
        private System.Windows.Forms.TextBox _txtSeriya;
        private System.Windows.Forms.TextBox _txtSnils;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox _txtBirthPlace;
        private System.Windows.Forms.TextBox _txtMainCountry;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox _txtBoxLastName;
        private System.Windows.Forms.RadioButton rBtnM;
        private System.Windows.Forms.RadioButton rBtnF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _buttonUpdate;
        private System.Windows.Forms.Button _buttonAdd;
        public System.Windows.Forms.TextBox _txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtBoxSurname;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}