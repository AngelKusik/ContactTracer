﻿
namespace lab4_ContactTracer
{
    partial class FormContactTracer
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
            this.components = new System.ComponentModel.Container();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBoxContacted = new System.Windows.Forms.CheckBox();
            this.listViewCustomersEntered = new System.Windows.Forms.ListView();
            this.columnHeaderContacted = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLastName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEmail = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(325, 50);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(119, 52);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(465, 58);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(350, 35);
            this.textBoxFirstName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxFirstName, "Please enter customer\'s first name.");
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(325, 108);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(119, 52);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(465, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 35);
            this.textBox2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox2, "Please enter customer\'s last name.");
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.Location = new System.Drawing.Point(284, 166);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(170, 52);
            this.labelEmailAddress.TabIndex = 4;
            this.labelEmailAddress.Text = "Email Address:";
            this.labelEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(465, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(350, 35);
            this.textBox3.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox3, "Please enter customer\'s email address.");
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Location = new System.Drawing.Point(284, 215);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(160, 52);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "Phone Number:";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(465, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(350, 35);
            this.textBox4.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox4, "Please enter customer\'s phone number.");
            // 
            // checkBoxContacted
            // 
            this.checkBoxContacted.AutoSize = true;
            this.checkBoxContacted.Location = new System.Drawing.Point(465, 290);
            this.checkBoxContacted.Name = "checkBoxContacted";
            this.checkBoxContacted.Size = new System.Drawing.Size(154, 34);
            this.checkBoxContacted.TabIndex = 8;
            this.checkBoxContacted.Text = "Contacted? :";
            this.checkBoxContacted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.checkBoxContacted, "Click to check if customer has been contacted.");
            this.checkBoxContacted.UseVisualStyleBackColor = true;
            // 
            // listViewCustomersEntered
            // 
            this.listViewCustomersEntered.CheckBoxes = true;
            this.listViewCustomersEntered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderContacted,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderDate,
            this.columnHeaderEmail,
            this.columnHeaderPhoneNumber});
            this.listViewCustomersEntered.FullRowSelect = true;
            this.listViewCustomersEntered.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCustomersEntered.HideSelection = false;
            this.listViewCustomersEntered.Location = new System.Drawing.Point(41, 347);
            this.listViewCustomersEntered.MultiSelect = false;
            this.listViewCustomersEntered.Name = "listViewCustomersEntered";
            this.listViewCustomersEntered.Size = new System.Drawing.Size(1005, 476);
            this.listViewCustomersEntered.TabIndex = 9;
            this.toolTip1.SetToolTip(this.listViewCustomersEntered, "Displays the entered customers information.");
            this.listViewCustomersEntered.UseCompatibleStateImageBehavior = false;
            this.listViewCustomersEntered.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderContacted
            // 
            this.columnHeaderContacted.Text = "Contacted";
            this.columnHeaderContacted.Width = 120;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            this.columnHeaderFirstName.Width = 150;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            this.columnHeaderLastName.Width = 150;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 120;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email Address";
            this.columnHeaderEmail.Width = 250;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "Phone Number";
            this.columnHeaderPhoneNumber.Width = 200;
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(41, 848);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(1005, 182);
            this.labelOutput.TabIndex = 10;
            this.toolTip1.SetToolTip(this.labelOutput, "Displays output and error messages.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(608, 1060);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(131, 40);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Click to enter customer\'s information.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(764, 1060);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(131, 40);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Click to reset the form.\r\n");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(915, 1060);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 40);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Click to exit application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // FormContactTracer
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(1086, 1128);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.listViewCustomersEntered);
            this.Controls.Add(this.checkBoxContacted);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContactTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBoxContacted;
        private System.Windows.Forms.ListView listViewCustomersEntered;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ColumnHeader columnHeaderContacted;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

