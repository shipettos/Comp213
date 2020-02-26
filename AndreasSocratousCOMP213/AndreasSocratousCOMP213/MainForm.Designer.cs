namespace AndreasSocratousCOMP213
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialySummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBSpec = new System.Windows.Forms.GroupBox();
            this.RBFirstSelected = new System.Windows.Forms.RadioButton();
            this.CBBluray = new System.Windows.Forms.CheckBox();
            this.CBFan = new System.Windows.Forms.CheckBox();
            this.CBCmera = new System.Windows.Forms.CheckBox();
            this.RBQuad28 = new System.Windows.Forms.RadioButton();
            this.RBQuad24 = new System.Windows.Forms.RadioButton();
            this.RBDuo30 = new System.Windows.Forms.RadioButton();
            this.GBInfo = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalBeforeDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumOfComps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdBuy = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.GBSpec.SuspendLayout();
            this.GBInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialySummaryToolStripMenuItem,
            this.resetSummaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // dialySummaryToolStripMenuItem
            // 
            this.dialySummaryToolStripMenuItem.Name = "dialySummaryToolStripMenuItem";
            this.dialySummaryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dialySummaryToolStripMenuItem.Text = "&Dialy Summary";
            this.dialySummaryToolStripMenuItem.Click += new System.EventHandler(this.dialySummaryToolStripMenuItem_Click);
            // 
            // resetSummaryToolStripMenuItem
            // 
            this.resetSummaryToolStripMenuItem.Name = "resetSummaryToolStripMenuItem";
            this.resetSummaryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.resetSummaryToolStripMenuItem.Text = "&Reset Summary";
            this.resetSummaryToolStripMenuItem.Click += new System.EventHandler(this.resetSummaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.changeFontToolStripMenuItem.Text = "Change Font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "&Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // GBSpec
            // 
            this.GBSpec.Controls.Add(this.RBFirstSelected);
            this.GBSpec.Controls.Add(this.CBBluray);
            this.GBSpec.Controls.Add(this.CBFan);
            this.GBSpec.Controls.Add(this.CBCmera);
            this.GBSpec.Controls.Add(this.RBQuad28);
            this.GBSpec.Controls.Add(this.RBQuad24);
            this.GBSpec.Controls.Add(this.RBDuo30);
            this.GBSpec.Location = new System.Drawing.Point(12, 27);
            this.GBSpec.Name = "GBSpec";
            this.GBSpec.Size = new System.Drawing.Size(347, 119);
            this.GBSpec.TabIndex = 1;
            this.GBSpec.TabStop = false;
            this.GBSpec.Text = "Computer Specification";
            // 
            // RBFirstSelected
            // 
            this.RBFirstSelected.AutoSize = true;
            this.RBFirstSelected.Location = new System.Drawing.Point(7, 8);
            this.RBFirstSelected.Name = "RBFirstSelected";
            this.RBFirstSelected.Size = new System.Drawing.Size(85, 17);
            this.RBFirstSelected.TabIndex = 6;
            this.RBFirstSelected.TabStop = true;
            this.RBFirstSelected.Text = "radioButton1";
            this.RBFirstSelected.UseVisualStyleBackColor = true;
            this.RBFirstSelected.Visible = false;
            // 
            // CBBluray
            // 
            this.CBBluray.AutoSize = true;
            this.CBBluray.Location = new System.Drawing.Point(215, 79);
            this.CBBluray.Name = "CBBluray";
            this.CBBluray.Size = new System.Drawing.Size(93, 17);
            this.CBBluray.TabIndex = 5;
            this.CBBluray.Text = "BluRay ($180)";
            this.toolTip1.SetToolTip(this.CBBluray, "bluray addon");
            this.CBBluray.UseVisualStyleBackColor = true;
            // 
            // CBFan
            // 
            this.CBFan.AutoSize = true;
            this.CBFan.Location = new System.Drawing.Point(215, 55);
            this.CBFan.Name = "CBFan";
            this.CBFan.Size = new System.Drawing.Size(104, 17);
            this.CBFan.TabIndex = 4;
            this.CBFan.Text = "Quiet Fans ($50)";
            this.toolTip1.SetToolTip(this.CBFan, "quiet fan addon");
            this.CBFan.UseVisualStyleBackColor = true;
            // 
            // CBCmera
            // 
            this.CBCmera.AutoSize = true;
            this.CBCmera.Location = new System.Drawing.Point(215, 31);
            this.CBCmera.Name = "CBCmera";
            this.CBCmera.Size = new System.Drawing.Size(115, 17);
            this.CBCmera.TabIndex = 3;
            this.CBCmera.Text = "Web Camera ($30)";
            this.toolTip1.SetToolTip(this.CBCmera, "web camera addon");
            this.CBCmera.UseVisualStyleBackColor = true;
            // 
            // RBQuad28
            // 
            this.RBQuad28.AutoSize = true;
            this.RBQuad28.Location = new System.Drawing.Point(7, 79);
            this.RBQuad28.Name = "RBQuad28";
            this.RBQuad28.Size = new System.Drawing.Size(138, 17);
            this.RBQuad28.TabIndex = 2;
            this.RBQuad28.TabStop = true;
            this.RBQuad28.Text = "C2Quad 2.8GHZ ($950)";
            this.RBQuad28.UseVisualStyleBackColor = true;
            // 
            // RBQuad24
            // 
            this.RBQuad24.AutoSize = true;
            this.RBQuad24.Location = new System.Drawing.Point(7, 55);
            this.RBQuad24.Name = "RBQuad24";
            this.RBQuad24.Size = new System.Drawing.Size(136, 17);
            this.RBQuad24.TabIndex = 1;
            this.RBQuad24.TabStop = true;
            this.RBQuad24.Text = "C2Quad 2.4GHz ($800)";
            this.RBQuad24.UseVisualStyleBackColor = true;
            // 
            // RBDuo30
            // 
            this.RBDuo30.AutoSize = true;
            this.RBDuo30.Location = new System.Drawing.Point(7, 31);
            this.RBDuo30.Name = "RBDuo30";
            this.RBDuo30.Size = new System.Drawing.Size(133, 17);
            this.RBDuo30.TabIndex = 0;
            this.RBDuo30.TabStop = true;
            this.RBDuo30.Text = "C2Duo 3.0 GHz ($350)";
            this.RBDuo30.UseVisualStyleBackColor = true;
            // 
            // GBInfo
            // 
            this.GBInfo.Controls.Add(this.txtTotal);
            this.GBInfo.Controls.Add(this.label4);
            this.GBInfo.Controls.Add(this.txtTotalBeforeDiscount);
            this.GBInfo.Controls.Add(this.label3);
            this.GBInfo.Controls.Add(this.txtDiscountCode);
            this.GBInfo.Controls.Add(this.label2);
            this.GBInfo.Controls.Add(this.txtNumOfComps);
            this.GBInfo.Controls.Add(this.label1);
            this.GBInfo.Location = new System.Drawing.Point(12, 152);
            this.GBInfo.Name = "GBInfo";
            this.GBInfo.Size = new System.Drawing.Size(347, 109);
            this.GBInfo.TabIndex = 2;
            this.GBInfo.TabStop = false;
            this.GBInfo.Text = "Order Info";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(279, 75);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(61, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total :";
            // 
            // txtTotalBeforeDiscount
            // 
            this.txtTotalBeforeDiscount.Enabled = false;
            this.txtTotalBeforeDiscount.Location = new System.Drawing.Point(279, 48);
            this.txtTotalBeforeDiscount.Name = "txtTotalBeforeDiscount";
            this.txtTotalBeforeDiscount.Size = new System.Drawing.Size(61, 20);
            this.txtTotalBeforeDiscount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Before Dsc";
            // 
            // txtDiscountCode
            // 
            this.txtDiscountCode.Location = new System.Drawing.Point(279, 17);
            this.txtDiscountCode.Name = "txtDiscountCode";
            this.txtDiscountCode.Size = new System.Drawing.Size(61, 20);
            this.txtDiscountCode.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtDiscountCode, "the discount code if you have");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount Code :";
            // 
            // txtNumOfComps
            // 
            this.txtNumOfComps.Location = new System.Drawing.Point(10, 48);
            this.txtNumOfComps.Name = "txtNumOfComps";
            this.txtNumOfComps.Size = new System.Drawing.Size(123, 20);
            this.txtNumOfComps.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNumOfComps, "how many computers you want to buy");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Computers";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(29, 290);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "&Clear";
            this.toolTip1.SetToolTip(this.cmdClear, "clearing the gui");
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(119, 290);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 4;
            this.cmdCalculate.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.cmdCalculate, "calculate the total before you buy it");
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdBuy
            // 
            this.cmdBuy.Enabled = false;
            this.cmdBuy.Location = new System.Drawing.Point(227, 290);
            this.cmdBuy.Name = "cmdBuy";
            this.cmdBuy.Size = new System.Drawing.Size(75, 23);
            this.cmdBuy.TabIndex = 5;
            this.cmdBuy.Text = "Buy";
            this.toolTip1.SetToolTip(this.cmdBuy, "making the purchase");
            this.cmdBuy.UseVisualStyleBackColor = true;
            this.cmdBuy.Click += new System.EventHandler(this.cmdBuy_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.cmdCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 334);
            this.Controls.Add(this.cmdBuy);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.GBInfo);
            this.Controls.Add(this.GBSpec);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Computer Store";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBSpec.ResumeLayout(false);
            this.GBSpec.PerformLayout();
            this.GBInfo.ResumeLayout(false);
            this.GBInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialySummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBSpec;
        private System.Windows.Forms.CheckBox CBBluray;
        private System.Windows.Forms.CheckBox CBFan;
        private System.Windows.Forms.CheckBox CBCmera;
        private System.Windows.Forms.RadioButton RBQuad28;
        private System.Windows.Forms.RadioButton RBQuad24;
        private System.Windows.Forms.RadioButton RBDuo30;
        private System.Windows.Forms.GroupBox GBInfo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalBeforeDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscountCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumOfComps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdBuy;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RadioButton RBFirstSelected;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

