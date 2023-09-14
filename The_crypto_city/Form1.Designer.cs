namespace The_crypto_city
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.ComboBox();
            this.Alternate_text = new System.Windows.Forms.CheckBox();
            this.Main_input_output = new System.Windows.Forms.TabControl();
            this.Text_tab = new System.Windows.Forms.TabPage();
            this.Encript_button = new System.Windows.Forms.Button();
            this.Clear_plain_text = new System.Windows.Forms.Button();
            this.Shift_text = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Output_text = new System.Windows.Forms.TextBox();
            this.File_tab = new System.Windows.Forms.TabPage();
            this.File_process_details = new System.Windows.Forms.Label();
            this.Generate_output_file = new System.Windows.Forms.Button();
            this.Output_file_path = new System.Windows.Forms.Label();
            this.Input_file_path = new System.Windows.Forms.Label();
            this.File_output_select = new System.Windows.Forms.Button();
            this.File_input_select = new System.Windows.Forms.Button();
            this.Set_key_button = new System.Windows.Forms.Button();
            this.Size_matrix = new System.Windows.Forms.ComboBox();
            this.Generate_key = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.TextBox();
            this.Error_message = new System.Windows.Forms.Label();
            this.Algorithm = new System.Windows.Forms.ComboBox();
            this.Note = new System.Windows.Forms.Label();
            this.Alternate_matrix = new System.Windows.Forms.CheckBox();
            this.Rowxy = new System.Windows.Forms.Label();
            this.Row_x_index = new System.Windows.Forms.ComboBox();
            this.Row_y_index = new System.Windows.Forms.ComboBox();
            this.Columnxy = new System.Windows.Forms.Label();
            this.Column_x_index = new System.Windows.Forms.ComboBox();
            this.Column_y_index = new System.Windows.Forms.ComboBox();
            this.Diagxy = new System.Windows.Forms.Label();
            this.Diag_x_index = new System.Windows.Forms.ComboBox();
            this.Diag_y_index = new System.Windows.Forms.ComboBox();
            this.Alternate_diag_use = new System.Windows.Forms.CheckBox();
            this.Main_input_output.SuspendLayout();
            this.Text_tab.SuspendLayout();
            this.File_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Crypto City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Algorithm:";
            // 
            // Process
            // 
            this.Process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.FormattingEnabled = true;
            this.Process.Items.AddRange(new object[] {
            "Encript",
            "Decript"});
            this.Process.Location = new System.Drawing.Point(478, 76);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(160, 46);
            this.Process.TabIndex = 3;
            this.Process.SelectedIndexChanged += new System.EventHandler(this.Process_SelectedIndexChanged);
            // 
            // Alternate_text
            // 
            this.Alternate_text.AutoSize = true;
            this.Alternate_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alternate_text.Location = new System.Drawing.Point(660, 76);
            this.Alternate_text.Name = "Alternate_text";
            this.Alternate_text.Size = new System.Drawing.Size(98, 24);
            this.Alternate_text.TabIndex = 4;
            this.Alternate_text.Text = "Alter text";
            this.Alternate_text.UseVisualStyleBackColor = true;
            this.Alternate_text.Visible = false;
            // 
            // Main_input_output
            // 
            this.Main_input_output.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Main_input_output.Controls.Add(this.Text_tab);
            this.Main_input_output.Controls.Add(this.File_tab);
            this.Main_input_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_input_output.Location = new System.Drawing.Point(8, 367);
            this.Main_input_output.Name = "Main_input_output";
            this.Main_input_output.SelectedIndex = 0;
            this.Main_input_output.Size = new System.Drawing.Size(824, 264);
            this.Main_input_output.TabIndex = 5;
            // 
            // Text_tab
            // 
            this.Text_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_tab.Controls.Add(this.Encript_button);
            this.Text_tab.Controls.Add(this.Clear_plain_text);
            this.Text_tab.Controls.Add(this.Shift_text);
            this.Text_tab.Controls.Add(this.label4);
            this.Text_tab.Controls.Add(this.Input_text);
            this.Text_tab.Controls.Add(this.label3);
            this.Text_tab.Controls.Add(this.Output_text);
            this.Text_tab.Location = new System.Drawing.Point(4, 32);
            this.Text_tab.Name = "Text_tab";
            this.Text_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Text_tab.Size = new System.Drawing.Size(816, 228);
            this.Text_tab.TabIndex = 0;
            this.Text_tab.Text = "Text";
            this.Text_tab.UseVisualStyleBackColor = true;
            // 
            // Encript_button
            // 
            this.Encript_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encript_button.Location = new System.Drawing.Point(595, 114);
            this.Encript_button.Name = "Encript_button";
            this.Encript_button.Size = new System.Drawing.Size(132, 23);
            this.Encript_button.TabIndex = 11;
            this.Encript_button.Text = "Generate output";
            this.Encript_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Encript_button.UseVisualStyleBackColor = true;
            this.Encript_button.Click += new System.EventHandler(this.Encript_button_Click);
            // 
            // Clear_plain_text
            // 
            this.Clear_plain_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_plain_text.Location = new System.Drawing.Point(733, 3);
            this.Clear_plain_text.Name = "Clear_plain_text";
            this.Clear_plain_text.Size = new System.Drawing.Size(75, 23);
            this.Clear_plain_text.TabIndex = 9;
            this.Clear_plain_text.Text = "Clear";
            this.Clear_plain_text.UseVisualStyleBackColor = true;
            this.Clear_plain_text.Click += new System.EventHandler(this.Clear_input_text_Click);
            // 
            // Shift_text
            // 
            this.Shift_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shift_text.Location = new System.Drawing.Point(733, 114);
            this.Shift_text.Name = "Shift_text";
            this.Shift_text.Size = new System.Drawing.Size(75, 23);
            this.Shift_text.TabIndex = 8;
            this.Shift_text.Text = "Shift";
            this.Shift_text.UseVisualStyleBackColor = true;
            this.Shift_text.Click += new System.EventHandler(this.Shift_text_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Input Text";
            // 
            // Input_text
            // 
            this.Input_text.Location = new System.Drawing.Point(6, 26);
            this.Input_text.Multiline = true;
            this.Input_text.Name = "Input_text";
            this.Input_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Input_text.Size = new System.Drawing.Size(802, 88);
            this.Input_text.TabIndex = 3;
            this.Input_text.TextChanged += new System.EventHandler(this.Input_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Text";
            // 
            // Output_text
            // 
            this.Output_text.Location = new System.Drawing.Point(6, 136);
            this.Output_text.Multiline = true;
            this.Output_text.Name = "Output_text";
            this.Output_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_text.Size = new System.Drawing.Size(802, 88);
            this.Output_text.TabIndex = 1;
            // 
            // File_tab
            // 
            this.File_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.File_tab.Controls.Add(this.File_process_details);
            this.File_tab.Controls.Add(this.Generate_output_file);
            this.File_tab.Controls.Add(this.Output_file_path);
            this.File_tab.Controls.Add(this.Input_file_path);
            this.File_tab.Controls.Add(this.File_output_select);
            this.File_tab.Controls.Add(this.File_input_select);
            this.File_tab.Location = new System.Drawing.Point(4, 32);
            this.File_tab.Name = "File_tab";
            this.File_tab.Padding = new System.Windows.Forms.Padding(3);
            this.File_tab.Size = new System.Drawing.Size(816, 228);
            this.File_tab.TabIndex = 1;
            this.File_tab.Text = "File";
            this.File_tab.UseVisualStyleBackColor = true;
            // 
            // File_process_details
            // 
            this.File_process_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.File_process_details.Location = new System.Drawing.Point(6, 166);
            this.File_process_details.Name = "File_process_details";
            this.File_process_details.Size = new System.Drawing.Size(802, 57);
            this.File_process_details.TabIndex = 5;
            // 
            // Generate_output_file
            // 
            this.Generate_output_file.Location = new System.Drawing.Point(641, 116);
            this.Generate_output_file.Name = "Generate_output_file";
            this.Generate_output_file.Size = new System.Drawing.Size(167, 47);
            this.Generate_output_file.TabIndex = 4;
            this.Generate_output_file.Text = "Generate output file";
            this.Generate_output_file.UseVisualStyleBackColor = true;
            this.Generate_output_file.Click += new System.EventHandler(this.Generate_output_file_Click);
            // 
            // Output_file_path
            // 
            this.Output_file_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output_file_path.Location = new System.Drawing.Point(224, 66);
            this.Output_file_path.Name = "Output_file_path";
            this.Output_file_path.Size = new System.Drawing.Size(584, 48);
            this.Output_file_path.TabIndex = 3;
            // 
            // Input_file_path
            // 
            this.Input_file_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input_file_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Input_file_path.Location = new System.Drawing.Point(224, 13);
            this.Input_file_path.Name = "Input_file_path";
            this.Input_file_path.Size = new System.Drawing.Size(584, 47);
            this.Input_file_path.TabIndex = 2;
            // 
            // File_output_select
            // 
            this.File_output_select.Location = new System.Drawing.Point(6, 66);
            this.File_output_select.Name = "File_output_select";
            this.File_output_select.Size = new System.Drawing.Size(185, 48);
            this.File_output_select.TabIndex = 1;
            this.File_output_select.Text = "Select Output file";
            this.File_output_select.UseVisualStyleBackColor = true;
            this.File_output_select.Click += new System.EventHandler(this.File_output_select_Click);
            // 
            // File_input_select
            // 
            this.File_input_select.Location = new System.Drawing.Point(6, 13);
            this.File_input_select.Name = "File_input_select";
            this.File_input_select.Size = new System.Drawing.Size(185, 47);
            this.File_input_select.TabIndex = 0;
            this.File_input_select.Text = "Select File to read";
            this.File_input_select.UseVisualStyleBackColor = true;
            this.File_input_select.Click += new System.EventHandler(this.File_input_select_Click);
            // 
            // Set_key_button
            // 
            this.Set_key_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set_key_button.Location = new System.Drawing.Point(66, 247);
            this.Set_key_button.Name = "Set_key_button";
            this.Set_key_button.Size = new System.Drawing.Size(75, 23);
            this.Set_key_button.TabIndex = 12;
            this.Set_key_button.Text = "Set";
            this.Set_key_button.UseVisualStyleBackColor = true;
            this.Set_key_button.Click += new System.EventHandler(this.Set_key_button_Click);
            // 
            // Size_matrix
            // 
            this.Size_matrix.DropDownHeight = 90;
            this.Size_matrix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Size_matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size_matrix.FormattingEnabled = true;
            this.Size_matrix.IntegralHeight = false;
            this.Size_matrix.Location = new System.Drawing.Point(672, 246);
            this.Size_matrix.Name = "Size_matrix";
            this.Size_matrix.Size = new System.Drawing.Size(55, 24);
            this.Size_matrix.TabIndex = 10;
            this.Size_matrix.Visible = false;
            // 
            // Generate_key
            // 
            this.Generate_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_key.Location = new System.Drawing.Point(742, 247);
            this.Generate_key.Name = "Generate_key";
            this.Generate_key.Size = new System.Drawing.Size(90, 23);
            this.Generate_key.TabIndex = 7;
            this.Generate_key.Text = "Generate";
            this.Generate_key.UseVisualStyleBackColor = true;
            this.Generate_key.Click += new System.EventHandler(this.Generate_key_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Key";
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(12, 273);
            this.Key.Multiline = true;
            this.Key.Name = "Key";
            this.Key.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Key.Size = new System.Drawing.Size(816, 88);
            this.Key.TabIndex = 5;
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            // 
            // Error_message
            // 
            this.Error_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Error_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_message.Location = new System.Drawing.Point(15, 198);
            this.Error_message.Name = "Error_message";
            this.Error_message.Size = new System.Drawing.Size(820, 45);
            this.Error_message.TabIndex = 0;
            this.Error_message.Text = "Error Message:";
            // 
            // Algorithm
            // 
            this.Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.Items.AddRange(new object[] {
            "Caeser Cipher",
            "Hill Cipher",
            "Vernam Cipher",
            "Vignere Cipher",
            "Rail Fence Cipher",
            "Play Fair Cipher"});
            this.Algorithm.Location = new System.Drawing.Point(167, 76);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(305, 46);
            this.Algorithm.TabIndex = 6;
            this.Algorithm.SelectedIndexChanged += new System.EventHandler(this.Algorithm_SelectedIndexChanged);
            // 
            // Note
            // 
            this.Note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(15, 133);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(819, 48);
            this.Note.TabIndex = 7;
            this.Note.Text = "Note:";
            // 
            // Alternate_matrix
            // 
            this.Alternate_matrix.AutoSize = true;
            this.Alternate_matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alternate_matrix.Location = new System.Drawing.Point(660, 106);
            this.Alternate_matrix.Name = "Alternate_matrix";
            this.Alternate_matrix.Size = new System.Drawing.Size(117, 24);
            this.Alternate_matrix.TabIndex = 8;
            this.Alternate_matrix.Text = "Alter matrix";
            this.Alternate_matrix.UseVisualStyleBackColor = true;
            this.Alternate_matrix.Visible = false;
            // 
            // Rowxy
            // 
            this.Rowxy.AutoSize = true;
            this.Rowxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rowxy.Location = new System.Drawing.Point(644, 43);
            this.Rowxy.Name = "Rowxy";
            this.Rowxy.Size = new System.Drawing.Size(58, 20);
            this.Rowxy.TabIndex = 9;
            this.Rowxy.Text = "Rowxy";
            this.Rowxy.Visible = false;
            // 
            // Row_x_index
            // 
            this.Row_x_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Row_x_index.FormattingEnabled = true;
            this.Row_x_index.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "-1",
            "-2",
            "-3",
            "-4"});
            this.Row_x_index.Location = new System.Drawing.Point(733, 43);
            this.Row_x_index.Name = "Row_x_index";
            this.Row_x_index.Size = new System.Drawing.Size(44, 24);
            this.Row_x_index.TabIndex = 10;
            this.Row_x_index.Visible = false;
            // 
            // Row_y_index
            // 
            this.Row_y_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Row_y_index.FormattingEnabled = true;
            this.Row_y_index.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "-1",
            "-2",
            "-3",
            "-4"});
            this.Row_y_index.Location = new System.Drawing.Point(788, 43);
            this.Row_y_index.Name = "Row_y_index";
            this.Row_y_index.Size = new System.Drawing.Size(44, 24);
            this.Row_y_index.TabIndex = 11;
            this.Row_y_index.Visible = false;
            // 
            // Columnxy
            // 
            this.Columnxy.AutoSize = true;
            this.Columnxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Columnxy.Location = new System.Drawing.Point(645, 76);
            this.Columnxy.Name = "Columnxy";
            this.Columnxy.Size = new System.Drawing.Size(82, 20);
            this.Columnxy.TabIndex = 12;
            this.Columnxy.Text = "Columnxy";
            this.Columnxy.Visible = false;
            // 
            // Column_x_index
            // 
            this.Column_x_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Column_x_index.FormattingEnabled = true;
            this.Column_x_index.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "-1",
            "-2",
            "-3",
            "-4"});
            this.Column_x_index.Location = new System.Drawing.Point(733, 72);
            this.Column_x_index.Name = "Column_x_index";
            this.Column_x_index.Size = new System.Drawing.Size(44, 24);
            this.Column_x_index.TabIndex = 13;
            this.Column_x_index.Visible = false;
            // 
            // Column_y_index
            // 
            this.Column_y_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Column_y_index.FormattingEnabled = true;
            this.Column_y_index.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "-1",
            "-2",
            "-3",
            "-4"});
            this.Column_y_index.Location = new System.Drawing.Point(788, 72);
            this.Column_y_index.Name = "Column_y_index";
            this.Column_y_index.Size = new System.Drawing.Size(44, 24);
            this.Column_y_index.TabIndex = 14;
            this.Column_y_index.Visible = false;
            // 
            // Diagxy
            // 
            this.Diagxy.AutoSize = true;
            this.Diagxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagxy.Location = new System.Drawing.Point(644, 107);
            this.Diagxy.Name = "Diagxy";
            this.Diagxy.Size = new System.Drawing.Size(60, 20);
            this.Diagxy.TabIndex = 15;
            this.Diagxy.Text = "Diagxy";
            this.Diagxy.Visible = false;
            // 
            // Diag_x_index
            // 
            this.Diag_x_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Diag_x_index.FormattingEnabled = true;
            this.Diag_x_index.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "-1",
            "-2",
            "-3",
            "-4"});
            this.Diag_x_index.Location = new System.Drawing.Point(735, 102);
            this.Diag_x_index.Name = "Diag_x_index";
            this.Diag_x_index.Size = new System.Drawing.Size(44, 24);
            this.Diag_x_index.TabIndex = 16;
            this.Diag_x_index.Visible = false;
            // 
            // Diag_y_index
            // 
            this.Diag_y_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Diag_y_index.FormattingEnabled = true;
            this.Diag_y_index.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "-1",
            "-2",
            "-3",
            "-4"});
            this.Diag_y_index.Location = new System.Drawing.Point(788, 103);
            this.Diag_y_index.Name = "Diag_y_index";
            this.Diag_y_index.Size = new System.Drawing.Size(44, 24);
            this.Diag_y_index.TabIndex = 17;
            this.Diag_y_index.Visible = false;
            // 
            // Alternate_diag_use
            // 
            this.Alternate_diag_use.AutoSize = true;
            this.Alternate_diag_use.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alternate_diag_use.Location = new System.Drawing.Point(643, 9);
            this.Alternate_diag_use.Name = "Alternate_diag_use";
            this.Alternate_diag_use.Size = new System.Drawing.Size(157, 24);
            this.Alternate_diag_use.TabIndex = 18;
            this.Alternate_diag_use.Text = "Use Alt Diagonal";
            this.Alternate_diag_use.UseVisualStyleBackColor = true;
            this.Alternate_diag_use.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(842, 633);
            this.Controls.Add(this.Set_key_button);
            this.Controls.Add(this.Size_matrix);
            this.Controls.Add(this.Alternate_diag_use);
            this.Controls.Add(this.Generate_key);
            this.Controls.Add(this.Diag_y_index);
            this.Controls.Add(this.Diag_x_index);
            this.Controls.Add(this.Diagxy);
            this.Controls.Add(this.Error_message);
            this.Controls.Add(this.Column_y_index);
            this.Controls.Add(this.Column_x_index);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Columnxy);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Row_y_index);
            this.Controls.Add(this.Row_x_index);
            this.Controls.Add(this.Rowxy);
            this.Controls.Add(this.Alternate_matrix);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.Main_input_output);
            this.Controls.Add(this.Alternate_text);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(860, 680);
            this.MinimumSize = new System.Drawing.Size(860, 680);
            this.Name = "Form1";
            this.Text = "ML production";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_input_output.ResumeLayout(false);
            this.Text_tab.ResumeLayout(false);
            this.Text_tab.PerformLayout();
            this.File_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Process;
        private System.Windows.Forms.CheckBox Alternate_text;
        private System.Windows.Forms.TabControl Main_input_output;
        private System.Windows.Forms.TabPage Text_tab;
        private System.Windows.Forms.Label Error_message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Input_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Output_text;
        private System.Windows.Forms.ComboBox Algorithm;
        private System.Windows.Forms.Button Generate_key;
        private System.Windows.Forms.Button Shift_text;
        private System.Windows.Forms.Button Clear_plain_text;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.ComboBox Size_matrix;
        private System.Windows.Forms.CheckBox Alternate_matrix;
        private System.Windows.Forms.Button Set_key_button;
        private System.Windows.Forms.Button Encript_button;
        private System.Windows.Forms.Label Rowxy;
        private System.Windows.Forms.ComboBox Row_x_index;
        private System.Windows.Forms.ComboBox Row_y_index;
        private System.Windows.Forms.Label Columnxy;
        private System.Windows.Forms.ComboBox Column_x_index;
        private System.Windows.Forms.ComboBox Column_y_index;
        private System.Windows.Forms.Label Diagxy;
        private System.Windows.Forms.ComboBox Diag_x_index;
        private System.Windows.Forms.ComboBox Diag_y_index;
        private System.Windows.Forms.CheckBox Alternate_diag_use;
        private System.Windows.Forms.TabPage File_tab;
        private System.Windows.Forms.Button Generate_output_file;
        private System.Windows.Forms.Label Output_file_path;
        private System.Windows.Forms.Label Input_file_path;
        private System.Windows.Forms.Button File_output_select;
        private System.Windows.Forms.Button File_input_select;
        private System.Windows.Forms.Label File_process_details;
    }
}

