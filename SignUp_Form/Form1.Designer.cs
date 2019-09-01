namespace SignUp_Form
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
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_zip_code = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_phone_no = new System.Windows.Forms.Label();
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.txtbox_first_name = new System.Windows.Forms.TextBox();
            this.txtbox_last_name = new System.Windows.Forms.TextBox();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.txtbox_city = new System.Windows.Forms.TextBox();
            this.cmbox_state = new System.Windows.Forms.ComboBox();
            this.cmbox_gender = new System.Windows.Forms.ComboBox();
            this.txtbox_DOB = new System.Windows.Forms.MaskedTextBox();
            this.txtbox_phone_no = new System.Windows.Forms.MaskedTextBox();
            this.txtbox_zip = new System.Windows.Forms.MaskedTextBox();
            this.btn_save_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_name.Location = new System.Drawing.Point(32, 43);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(143, 33);
            this.lbl_first_name.TabIndex = 0;
            this.lbl_first_name.Text = "First Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(32, 178);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(108, 33);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(32, 251);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(64, 33);
            this.lbl_city.TabIndex = 2;
            this.lbl_city.Text = "City";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.Location = new System.Drawing.Point(32, 315);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(75, 33);
            this.lbl_state.TabIndex = 3;
            this.lbl_state.Text = "State";
            // 
            // lbl_zip_code
            // 
            this.lbl_zip_code.AutoSize = true;
            this.lbl_zip_code.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zip_code.Location = new System.Drawing.Point(32, 390);
            this.lbl_zip_code.Name = "lbl_zip_code";
            this.lbl_zip_code.Size = new System.Drawing.Size(121, 33);
            this.lbl_zip_code.TabIndex = 4;
            this.lbl_zip_code.Text = "Zip Code";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(32, 468);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(101, 33);
            this.lbl_gender.TabIndex = 5;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(32, 538);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(175, 33);
            this.lbl_DOB.TabIndex = 6;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_phone_no
            // 
            this.lbl_phone_no.AutoSize = true;
            this.lbl_phone_no.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone_no.Location = new System.Drawing.Point(32, 630);
            this.lbl_phone_no.Name = "lbl_phone_no";
            this.lbl_phone_no.Size = new System.Drawing.Size(193, 33);
            this.lbl_phone_no.TabIndex = 7;
            this.lbl_phone_no.Text = "Phone Number";
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_name.Location = new System.Drawing.Point(32, 114);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(139, 33);
            this.lbl_last_name.TabIndex = 8;
            this.lbl_last_name.Text = "Last Name";
            // 
            // txtbox_first_name
            // 
            this.txtbox_first_name.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_first_name.Location = new System.Drawing.Point(279, 45);
            this.txtbox_first_name.Name = "txtbox_first_name";
            this.txtbox_first_name.Size = new System.Drawing.Size(431, 40);
            this.txtbox_first_name.TabIndex = 9;
            // 
            // txtbox_last_name
            // 
            this.txtbox_last_name.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_last_name.Location = new System.Drawing.Point(279, 114);
            this.txtbox_last_name.Name = "txtbox_last_name";
            this.txtbox_last_name.Size = new System.Drawing.Size(431, 40);
            this.txtbox_last_name.TabIndex = 10;
            // 
            // txtbox_address
            // 
            this.txtbox_address.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_address.Location = new System.Drawing.Point(279, 178);
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(431, 36);
            this.txtbox_address.TabIndex = 11;
            // 
            // txtbox_city
            // 
            this.txtbox_city.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_city.Location = new System.Drawing.Point(279, 251);
            this.txtbox_city.Name = "txtbox_city";
            this.txtbox_city.Size = new System.Drawing.Size(431, 40);
            this.txtbox_city.TabIndex = 12;
            // 
            // cmbox_state
            // 
            this.cmbox_state.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.cmbox_state.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_state.FormattingEnabled = true;
            this.cmbox_state.Location = new System.Drawing.Point(279, 315);
            this.cmbox_state.Name = "cmbox_state";
            this.cmbox_state.Size = new System.Drawing.Size(431, 41);
            this.cmbox_state.TabIndex = 13;
            // 
            // cmbox_gender
            // 
            this.cmbox_gender.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_gender.FormattingEnabled = true;
            this.cmbox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbox_gender.Location = new System.Drawing.Point(279, 468);
            this.cmbox_gender.Name = "cmbox_gender";
            this.cmbox_gender.Size = new System.Drawing.Size(147, 41);
            this.cmbox_gender.TabIndex = 15;
            // 
            // txtbox_DOB
            // 
            this.txtbox_DOB.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_DOB.Location = new System.Drawing.Point(279, 538);
            this.txtbox_DOB.Mask = "00/00/0000";
            this.txtbox_DOB.Name = "txtbox_DOB";
            this.txtbox_DOB.Size = new System.Drawing.Size(431, 40);
            this.txtbox_DOB.TabIndex = 16;
            this.txtbox_DOB.ValidatingType = typeof(System.DateTime);
            // 
            // txtbox_phone_no
            // 
            this.txtbox_phone_no.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_phone_no.Location = new System.Drawing.Point(279, 630);
            this.txtbox_phone_no.Mask = "(999) 000-0000";
            this.txtbox_phone_no.Name = "txtbox_phone_no";
            this.txtbox_phone_no.Size = new System.Drawing.Size(431, 40);
            this.txtbox_phone_no.TabIndex = 17;
            // 
            // txtbox_zip
            // 
            this.txtbox_zip.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_zip.Location = new System.Drawing.Point(279, 400);
            this.txtbox_zip.Mask = "00000";
            this.txtbox_zip.Name = "txtbox_zip";
            this.txtbox_zip.Size = new System.Drawing.Size(301, 40);
            this.txtbox_zip.TabIndex = 14;
            // 
            // btn_save_form
            // 
            this.btn_save_form.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_save_form.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_form.Location = new System.Drawing.Point(279, 701);
            this.btn_save_form.Name = "btn_save_form";
            this.btn_save_form.Size = new System.Drawing.Size(220, 48);
            this.btn_save_form.TabIndex = 18;
            this.btn_save_form.Text = "Save From";
            this.btn_save_form.UseVisualStyleBackColor = false;
            this.btn_save_form.Click += new System.EventHandler(this.Btn_save_form_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 772);
            this.Controls.Add(this.btn_save_form);
            this.Controls.Add(this.txtbox_zip);
            this.Controls.Add(this.txtbox_phone_no);
            this.Controls.Add(this.txtbox_DOB);
            this.Controls.Add(this.cmbox_gender);
            this.Controls.Add(this.cmbox_state);
            this.Controls.Add(this.txtbox_city);
            this.Controls.Add(this.txtbox_address);
            this.Controls.Add(this.txtbox_last_name);
            this.Controls.Add(this.txtbox_first_name);
            this.Controls.Add(this.lbl_last_name);
            this.Controls.Add(this.lbl_phone_no);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_zip_code);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_first_name);
            this.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ENTRY FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label lbl_zip_code;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_phone_no;
        private System.Windows.Forms.Label lbl_last_name;
        private System.Windows.Forms.TextBox txtbox_first_name;
        private System.Windows.Forms.TextBox txtbox_last_name;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.Windows.Forms.TextBox txtbox_city;
        private System.Windows.Forms.ComboBox cmbox_state;
        private System.Windows.Forms.ComboBox cmbox_gender;
        private System.Windows.Forms.MaskedTextBox txtbox_DOB;
        private System.Windows.Forms.MaskedTextBox txtbox_phone_no;
        private System.Windows.Forms.MaskedTextBox txtbox_zip;
        private System.Windows.Forms.Button btn_save_form;
    }
}

