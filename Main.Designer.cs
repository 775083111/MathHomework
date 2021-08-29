
namespace MathHomework
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLenght = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.comboBoxNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxFixNegative = new System.Windows.Forms.CheckBox();
            this.checkBoxOutAnswer = new System.Windows.Forms.CheckBox();
            this.printPageSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "数值长度";
            // 
            // comboBoxLenght
            // 
            this.comboBoxLenght.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLenght.FormattingEnabled = true;
            this.comboBoxLenght.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxLenght.Items.AddRange(new object[] {
            "1-10",
            "1-100",
            "1-300",
            "1-999"});
            this.comboBoxLenght.Location = new System.Drawing.Point(112, 24);
            this.comboBoxLenght.Name = "comboBoxLenght";
            this.comboBoxLenght.Size = new System.Drawing.Size(90, 25);
            this.comboBoxLenght.TabIndex = 1;
            this.comboBoxLenght.SelectedIndexChanged += new System.EventHandler(this.comboBoxLenght_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "运算方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "符号数量";
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "加法",
            "减法",
            "乘法",
            "除法",
            "混合"});
            this.comboBoxOperator.Location = new System.Drawing.Point(112, 69);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(90, 25);
            this.comboBoxOperator.TabIndex = 4;
            this.comboBoxOperator.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperator_SelectedIndexChanged);
            // 
            // comboBoxNum
            // 
            this.comboBoxNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNum.Enabled = false;
            this.comboBoxNum.FormattingEnabled = true;
            this.comboBoxNum.Items.AddRange(new object[] {
            "1"});
            this.comboBoxNum.Location = new System.Drawing.Point(112, 111);
            this.comboBoxNum.Name = "comboBoxNum";
            this.comboBoxNum.Size = new System.Drawing.Size(90, 25);
            this.comboBoxNum.TabIndex = 5;
            this.comboBoxNum.SelectedIndexChanged += new System.EventHandler(this.comboBoxNum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(36, 236);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(166, 36);
            this.btnBuild.TabIndex = 7;
            this.btnBuild.Text = "生成一组";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(112, 153);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(90, 23);
            this.txtSavePath.TabIndex = 9;
            this.txtSavePath.Text = "程序目录";
            this.txtSavePath.Click += new System.EventHandler(this.txtSavePath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "保存位置";
            // 
            // checkBoxFixNegative
            // 
            this.checkBoxFixNegative.AutoSize = true;
            this.checkBoxFixNegative.Checked = true;
            this.checkBoxFixNegative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFixNegative.Location = new System.Drawing.Point(36, 288);
            this.checkBoxFixNegative.Name = "checkBoxFixNegative";
            this.checkBoxFixNegative.Size = new System.Drawing.Size(75, 21);
            this.checkBoxFixNegative.TabIndex = 10;
            this.checkBoxFixNegative.Text = "避免负数";
            this.checkBoxFixNegative.UseVisualStyleBackColor = true;
            // 
            // checkBoxOutAnswer
            // 
            this.checkBoxOutAnswer.AutoSize = true;
            this.checkBoxOutAnswer.Checked = true;
            this.checkBoxOutAnswer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOutAnswer.Location = new System.Drawing.Point(127, 288);
            this.checkBoxOutAnswer.Name = "checkBoxOutAnswer";
            this.checkBoxOutAnswer.Size = new System.Drawing.Size(75, 21);
            this.checkBoxOutAnswer.TabIndex = 11;
            this.checkBoxOutAnswer.Text = "输出答案";
            this.checkBoxOutAnswer.UseVisualStyleBackColor = true;
            // 
            // printPageSize
            // 
            this.printPageSize.Location = new System.Drawing.Point(112, 193);
            this.printPageSize.Name = "printPageSize";
            this.printPageSize.Size = new System.Drawing.Size(90, 23);
            this.printPageSize.TabIndex = 12;
            this.printPageSize.Text = "30";
            this.printPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.printPageSize_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "每组数量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(36, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "* 打印字号使用(宋体_小三)";
            // 
            // BuildX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 344);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.printPageSize);
            this.Controls.Add(this.checkBoxOutAnswer);
            this.Controls.Add(this.checkBoxFixNegative);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNum);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLenght);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildX";
            this.ShowIcon = false;
            this.Text = "数学题生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLenght;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.ComboBox comboBoxNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxFixNegative;
        private System.Windows.Forms.CheckBox checkBoxOutAnswer;
        private System.Windows.Forms.TextBox printPageSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

