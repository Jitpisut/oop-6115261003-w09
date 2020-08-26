namespace oop_6115261003_w09
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.taxCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 28);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(49, 17);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "น้ำหนัก";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 82);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(44, 17);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "ส่วนสูง";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(12, 156);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(76, 17);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "ดัชนีมวลกาย";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(106, 25);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(106, 79);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(268, 153);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "คำนวณ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(15, 238);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(23, 17);
            this.name.TabIndex = 6;
            this.name.Text = "ชื่อ";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(15, 287);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(55, 17);
            this.salary.TabIndex = 7;
            this.salary.Text = "เงินเดือน";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Location = new System.Drawing.Point(15, 354);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(31, 17);
            this.lbltax.TabIndex = 8;
            this.lbltax.Text = "ภาษี";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 235);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(106, 284);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 10;
            // 
            // taxCalculate
            // 
            this.taxCalculate.Location = new System.Drawing.Point(268, 351);
            this.taxCalculate.Name = "taxCalculate";
            this.taxCalculate.Size = new System.Drawing.Size(100, 23);
            this.taxCalculate.TabIndex = 11;
            this.taxCalculate.Text = "คำนวณภาษี";
            this.taxCalculate.UseVisualStyleBackColor = true;
            this.taxCalculate.Click += new System.EventHandler(this.taxCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.taxCalculate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button taxCalculate;
    }
}

