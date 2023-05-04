namespace TelephonePart2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstBox = new TextBox();
            PhoneBox = new TextBox();
            LastBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            EmailBox = new TextBox();
            NewButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            listView1 = new ListView();
            column_id = new ColumnHeader();
            column_name = new ColumnHeader();
            column_surname = new ColumnHeader();
            column_phone = new ColumnHeader();
            column_type = new ColumnHeader();
            column_email = new ColumnHeader();
            label8 = new Label();
            idBox = new TextBox();
            DisplayButton = new Button();
            editButton = new Button();
            SuspendLayout();
            // 
            // FirstBox
            // 
            FirstBox.Location = new Point(108, 46);
            FirstBox.Name = "FirstBox";
            FirstBox.Size = new Size(233, 23);
            FirstBox.TabIndex = 2;
            FirstBox.Tag = "1";
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(108, 101);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(233, 23);
            PhoneBox.TabIndex = 4;
            PhoneBox.Tag = "3";
            // 
            // LastBox
            // 
            LastBox.Location = new Point(108, 75);
            LastBox.Name = "LastBox";
            LastBox.Size = new Size(233, 23);
            LastBox.TabIndex = 3;
            LastBox.Tag = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 75);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 101);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 170);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("RomanT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Home Phone", "Cell Phone", "Work Phone " });
            comboBox1.Location = new Point(108, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 26);
            comboBox1.TabIndex = 5;
            comboBox1.Tag = "5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 131);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 248);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Contacts:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 170);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 12;
            label7.Text = "Email";
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(108, 167);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(233, 23);
            EmailBox.TabIndex = 6;
            EmailBox.Tag = "5";
            // 
            // NewButton
            // 
            NewButton.Font = new Font("Romantic", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            NewButton.Location = new Point(493, 43);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(76, 27);
            NewButton.TabIndex = 7;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Romantic", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(493, 89);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(76, 27);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Romantic", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(493, 143);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(76, 27);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { column_id, column_name, column_surname, column_phone, column_type, column_email });
            listView1.GridLines = true;
            listView1.HideSelection = true;
            listView1.Location = new Point(39, 266);
            listView1.Name = "listView1";
            listView1.Size = new Size(493, 140);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // column_id
            // 
            column_id.Text = "ID";
            column_id.Width = 50;
            // 
            // column_name
            // 
            column_name.Text = "First Name";
            column_name.Width = 100;
            // 
            // column_surname
            // 
            column_surname.Text = "Last Name";
            column_surname.Width = 100;
            // 
            // column_phone
            // 
            column_phone.Text = "Phone";
            column_phone.Width = 100;
            // 
            // column_type
            // 
            column_type.Text = "Type";
            column_type.Width = 100;
            // 
            // column_email
            // 
            column_email.Text = "Email";
            column_email.Width = 100;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 24);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 18;
            label8.Text = "id";
            // 
            // idBox
            // 
            idBox.Location = new Point(108, 16);
            idBox.Name = "idBox";
            idBox.Size = new Size(45, 23);
            idBox.TabIndex = 1;
            idBox.Tag = "1";
            // 
            // DisplayButton
            // 
            DisplayButton.Font = new Font("Romantic", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayButton.Location = new Point(579, 313);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(143, 27);
            DisplayButton.TabIndex = 10;
            DisplayButton.Text = "Display Contacts";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += button1_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Romantic", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.Location = new Point(608, 346);
            editButton.Name = "editButton";
            editButton.Size = new Size(76, 27);
            editButton.TabIndex = 11;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editButton);
            Controls.Add(DisplayButton);
            Controls.Add(idBox);
            Controls.Add(label8);
            Controls.Add(listView1);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(NewButton);
            Controls.Add(EmailBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LastBox);
            Controls.Add(PhoneBox);
            Controls.Add(FirstBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstBox;
        private TextBox PhoneBox;
        private TextBox LastBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox EmailBox;
        private Button NewButton;
        private Button SaveButton;
        private Button DeleteButton;
        private ListView listView1;
        private ColumnHeader column_id;
        private ColumnHeader column_name;
        private ColumnHeader column_surname;
        private ColumnHeader column_phone;
        private ColumnHeader column_type;
        private ColumnHeader column_email;
        private Label label8;
        private TextBox idBox;
        private Button DisplayButton;
        private Button editButton;
    }
}