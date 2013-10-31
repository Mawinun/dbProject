namespace SQL_project_Admin_Interface
{
    partial class mainGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.page1ClearButton = new System.Windows.Forms.Button();
            this.tab1AccountIDLabel = new System.Windows.Forms.Label();
            this.tab1AHIDLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.pinTB = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telephoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.birthdateTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.page1AccountLB = new System.Windows.Forms.ListBox();
            this.addAHButton = new System.Windows.Forms.Button();
            this.page1AHLB = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.calcInterestButton = new System.Windows.Forms.Button();
            this.linkToLabel = new System.Windows.Forms.Label();
            this.AHlinkTB = new System.Windows.Forms.TextBox();
            this.page2ClearButton = new System.Windows.Forms.Button();
            this.tab2AHIDLabel = new System.Windows.Forms.Label();
            this.tab2AccountIDLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.linkAccountButton = new System.Windows.Forms.Button();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.page2AccountLB = new System.Windows.Forms.ListBox();
            this.page2AHLB = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.amountLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.toTB = new System.Windows.Forms.TextBox();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.transferButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 547);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.page1ClearButton);
            this.tabPage1.Controls.Add(this.tab1AccountIDLabel);
            this.tabPage1.Controls.Add(this.tab1AHIDLabel);
            this.tabPage1.Controls.Add(this.pinLabel);
            this.tabPage1.Controls.Add(this.pinTB);
            this.tabPage1.Controls.Add(this.telephoneLabel);
            this.tabPage1.Controls.Add(this.emailLabel);
            this.tabPage1.Controls.Add(this.telephoneTB);
            this.tabPage1.Controls.Add(this.emailTB);
            this.tabPage1.Controls.Add(this.birthdateLabel);
            this.tabPage1.Controls.Add(this.birthdateTB);
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Controls.Add(this.nameTB);
            this.tabPage1.Controls.Add(this.page1AccountLB);
            this.tabPage1.Controls.Add(this.addAHButton);
            this.tabPage1.Controls.Add(this.page1AHLB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Handle Account Holders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // page1ClearButton
            // 
            this.page1ClearButton.Location = new System.Drawing.Point(149, 446);
            this.page1ClearButton.Name = "page1ClearButton";
            this.page1ClearButton.Size = new System.Drawing.Size(149, 45);
            this.page1ClearButton.TabIndex = 15;
            this.page1ClearButton.Text = "Clear Fields";
            this.page1ClearButton.UseVisualStyleBackColor = true;
            this.page1ClearButton.Click += new System.EventHandler(this.page1ClearButton_Click);
            // 
            // tab1AccountIDLabel
            // 
            this.tab1AccountIDLabel.AutoSize = true;
            this.tab1AccountIDLabel.Location = new System.Drawing.Point(329, 15);
            this.tab1AccountIDLabel.Name = "tab1AccountIDLabel";
            this.tab1AccountIDLabel.Size = new System.Drawing.Size(61, 13);
            this.tab1AccountIDLabel.TabIndex = 14;
            this.tab1AccountIDLabel.Text = "Account ID";
            // 
            // tab1AHIDLabel
            // 
            this.tab1AHIDLabel.AutoSize = true;
            this.tab1AHIDLabel.Location = new System.Drawing.Point(51, 15);
            this.tab1AHIDLabel.Name = "tab1AHIDLabel";
            this.tab1AHIDLabel.Size = new System.Drawing.Size(95, 13);
            this.tab1AHIDLabel.TabIndex = 13;
            this.tab1AHIDLabel.Text = "Account Holder ID";
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(319, 388);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(22, 13);
            this.pinLabel.TabIndex = 12;
            this.pinLabel.Text = "Pin";
            // 
            // pinTB
            // 
            this.pinTB.Location = new System.Drawing.Point(315, 405);
            this.pinTB.MaxLength = 4;
            this.pinTB.Name = "pinTB";
            this.pinTB.Size = new System.Drawing.Size(258, 20);
            this.pinTB.TabIndex = 11;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(316, 342);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(58, 13);
            this.telephoneLabel.TabIndex = 10;
            this.telephoneLabel.Text = "Telephone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(316, 296);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            // 
            // telephoneTB
            // 
            this.telephoneTB.Location = new System.Drawing.Point(315, 358);
            this.telephoneTB.Name = "telephoneTB";
            this.telephoneTB.Size = new System.Drawing.Size(258, 20);
            this.telephoneTB.TabIndex = 8;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(316, 310);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(257, 20);
            this.emailTB.TabIndex = 7;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(48, 344);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(49, 13);
            this.birthdateLabel.TabIndex = 6;
            this.birthdateLabel.Text = "Birthdate";
            // 
            // birthdateTB
            // 
            this.birthdateTB.Location = new System.Drawing.Point(43, 358);
            this.birthdateTB.MaxLength = 8;
            this.birthdateTB.Name = "birthdateTB";
            this.birthdateTB.Size = new System.Drawing.Size(254, 20);
            this.birthdateTB.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(46, 296);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(43, 310);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(255, 20);
            this.nameTB.TabIndex = 3;
            // 
            // page1AccountLB
            // 
            this.page1AccountLB.FormattingEnabled = true;
            this.page1AccountLB.Location = new System.Drawing.Point(316, 32);
            this.page1AccountLB.Name = "page1AccountLB";
            this.page1AccountLB.Size = new System.Drawing.Size(255, 251);
            this.page1AccountLB.TabIndex = 2;
            // 
            // addAHButton
            // 
            this.addAHButton.Location = new System.Drawing.Point(315, 446);
            this.addAHButton.Name = "addAHButton";
            this.addAHButton.Size = new System.Drawing.Size(150, 45);
            this.addAHButton.TabIndex = 1;
            this.addAHButton.Text = "Add new AH";
            this.addAHButton.UseVisualStyleBackColor = true;
            this.addAHButton.Click += new System.EventHandler(this.addAHButton_Click);
            // 
            // page1AHLB
            // 
            this.page1AHLB.FormattingEnabled = true;
            this.page1AHLB.Location = new System.Drawing.Point(41, 32);
            this.page1AHLB.Name = "page1AHLB";
            this.page1AHLB.Size = new System.Drawing.Size(255, 251);
            this.page1AHLB.TabIndex = 0;
            this.page1AHLB.SelectedIndexChanged += new System.EventHandler(this.page1AHLB_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.refreshButton);
            this.tabPage2.Controls.Add(this.calcInterestButton);
            this.tabPage2.Controls.Add(this.linkToLabel);
            this.tabPage2.Controls.Add(this.AHlinkTB);
            this.tabPage2.Controls.Add(this.page2ClearButton);
            this.tabPage2.Controls.Add(this.tab2AHIDLabel);
            this.tabPage2.Controls.Add(this.tab2AccountIDLabel);
            this.tabPage2.Controls.Add(this.balanceLabel);
            this.tabPage2.Controls.Add(this.balanceTB);
            this.tabPage2.Controls.Add(this.linkAccountButton);
            this.tabPage2.Controls.Add(this.newAccountButton);
            this.tabPage2.Controls.Add(this.page2AccountLB);
            this.tabPage2.Controls.Add(this.page2AHLB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Handle Accounts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(386, 437);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 44);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // calcInterestButton
            // 
            this.calcInterestButton.Location = new System.Drawing.Point(230, 437);
            this.calcInterestButton.Name = "calcInterestButton";
            this.calcInterestButton.Size = new System.Drawing.Size(150, 44);
            this.calcInterestButton.TabIndex = 14;
            this.calcInterestButton.Text = "Apply Interest to Accounts";
            this.calcInterestButton.UseVisualStyleBackColor = true;
            this.calcInterestButton.Click += new System.EventHandler(this.calcInterestButton_Click);
            // 
            // linkToLabel
            // 
            this.linkToLabel.AutoSize = true;
            this.linkToLabel.Location = new System.Drawing.Point(322, 300);
            this.linkToLabel.Name = "linkToLabel";
            this.linkToLabel.Size = new System.Drawing.Size(153, 13);
            this.linkToLabel.TabIndex = 13;
            this.linkToLabel.Text = "Account Holder ID to be linked";
            // 
            // AHlinkTB
            // 
            this.AHlinkTB.Location = new System.Drawing.Point(316, 316);
            this.AHlinkTB.Name = "AHlinkTB";
            this.AHlinkTB.Size = new System.Drawing.Size(240, 20);
            this.AHlinkTB.TabIndex = 12;
            // 
            // page2ClearButton
            // 
            this.page2ClearButton.Location = new System.Drawing.Point(74, 377);
            this.page2ClearButton.Name = "page2ClearButton";
            this.page2ClearButton.Size = new System.Drawing.Size(150, 44);
            this.page2ClearButton.TabIndex = 11;
            this.page2ClearButton.Text = "Clear Fields";
            this.page2ClearButton.UseVisualStyleBackColor = true;
            this.page2ClearButton.Click += new System.EventHandler(this.page2ClearButton_Click);
            // 
            // tab2AHIDLabel
            // 
            this.tab2AHIDLabel.AutoSize = true;
            this.tab2AHIDLabel.Location = new System.Drawing.Point(322, 15);
            this.tab2AHIDLabel.Name = "tab2AHIDLabel";
            this.tab2AHIDLabel.Size = new System.Drawing.Size(95, 13);
            this.tab2AHIDLabel.TabIndex = 10;
            this.tab2AHIDLabel.Text = "Account Holder ID";
            // 
            // tab2AccountIDLabel
            // 
            this.tab2AccountIDLabel.AutoSize = true;
            this.tab2AccountIDLabel.Location = new System.Drawing.Point(48, 17);
            this.tab2AccountIDLabel.Name = "tab2AccountIDLabel";
            this.tab2AccountIDLabel.Size = new System.Drawing.Size(61, 13);
            this.tab2AccountIDLabel.TabIndex = 9;
            this.tab2AccountIDLabel.Text = "Account ID";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(48, 300);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(46, 13);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "Balance";
            // 
            // balanceTB
            // 
            this.balanceTB.Location = new System.Drawing.Point(41, 316);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.Size = new System.Drawing.Size(255, 20);
            this.balanceTB.TabIndex = 7;
            // 
            // linkAccountButton
            // 
            this.linkAccountButton.Location = new System.Drawing.Point(386, 376);
            this.linkAccountButton.Name = "linkAccountButton";
            this.linkAccountButton.Size = new System.Drawing.Size(150, 45);
            this.linkAccountButton.TabIndex = 6;
            this.linkAccountButton.Text = "Link to Account Holder";
            this.linkAccountButton.UseVisualStyleBackColor = true;
            this.linkAccountButton.Click += new System.EventHandler(this.linkAccountButton_Click);
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(230, 376);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(150, 45);
            this.newAccountButton.TabIndex = 5;
            this.newAccountButton.Text = "Add new account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // page2AccountLB
            // 
            this.page2AccountLB.FormattingEnabled = true;
            this.page2AccountLB.Location = new System.Drawing.Point(41, 32);
            this.page2AccountLB.Name = "page2AccountLB";
            this.page2AccountLB.Size = new System.Drawing.Size(255, 251);
            this.page2AccountLB.TabIndex = 4;
            this.page2AccountLB.SelectedIndexChanged += new System.EventHandler(this.page2AccountLB_SelectedIndexChanged);
            // 
            // page2AHLB
            // 
            this.page2AHLB.FormattingEnabled = true;
            this.page2AHLB.Location = new System.Drawing.Point(316, 32);
            this.page2AHLB.Name = "page2AHLB";
            this.page2AHLB.Size = new System.Drawing.Size(255, 251);
            this.page2AHLB.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.transferButton);
            this.tabPage3.Controls.Add(this.amountLabel);
            this.tabPage3.Controls.Add(this.toLabel);
            this.tabPage3.Controls.Add(this.fromLabel);
            this.tabPage3.Controls.Add(this.amountTB);
            this.tabPage3.Controls.Add(this.toTB);
            this.tabPage3.Controls.Add(this.fromTB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(610, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transfer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(96, 167);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(96, 109);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(63, 13);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To Account";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(96, 57);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(73, 13);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "From Account";
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(86, 183);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(285, 20);
            this.amountTB.TabIndex = 0;
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(86, 125);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(285, 20);
            this.toTB.TabIndex = 0;
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(86, 76);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(285, 20);
            this.fromTB.TabIndex = 0;
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(86, 244);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(133, 59);
            this.transferButton.TabIndex = 2;
            this.transferButton.Text = "Transfer money";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // mainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 550);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainGUI";
            this.Text = "Administrator Interface";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox page1AHLB;
        private System.Windows.Forms.Button addAHButton;
        private System.Windows.Forms.ListBox page1AccountLB;
        private System.Windows.Forms.Button linkAccountButton;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.ListBox page2AccountLB;
        private System.Windows.Forms.ListBox page2AHLB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox telephoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.TextBox birthdateTB;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.TextBox pinTB;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.Label tab1AccountIDLabel;
        private System.Windows.Forms.Label tab1AHIDLabel;
        private System.Windows.Forms.Label tab2AHIDLabel;
        private System.Windows.Forms.Label tab2AccountIDLabel;
        private System.Windows.Forms.Button page1ClearButton;
        private System.Windows.Forms.Button page2ClearButton;
        private System.Windows.Forms.Label linkToLabel;
        private System.Windows.Forms.TextBox AHlinkTB;
        private System.Windows.Forms.Button calcInterestButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.Button transferButton;

    }
}

