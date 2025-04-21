namespace WinFormsApp1
{
    partial class Calculator
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
            btnOk = new Button();
            button2 = new Button();
            cmbxAct = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCh1 = new TextBox();
            txtRez = new TextBox();
            txtCh2 = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(221, 168);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Обчислити";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // button2
            // 
            button2.Location = new Point(393, 168);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Вихід";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbxAct
            // 
            cmbxAct.FormattingEnabled = true;
            cmbxAct.Location = new Point(156, 59);
            cmbxAct.Name = "cmbxAct";
            cmbxAct.Size = new Size(121, 23);
            cmbxAct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Число 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 41);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Виберіть дію";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 41);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Число 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 62);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 6;
            label4.Text = "=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 41);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Результат";
            // 
            // txtCh1
            // 
            txtCh1.Location = new Point(40, 59);
            txtCh1.Name = "txtCh1";
            txtCh1.Size = new Size(100, 23);
            txtCh1.TabIndex = 8;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(474, 59);
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(100, 23);
            txtRez.TabIndex = 9;
            // 
            // txtCh2
            // 
            txtCh2.Location = new Point(300, 59);
            txtCh2.Name = "txtCh2";
            txtCh2.Size = new Size(100, 23);
            txtCh2.TabIndex = 10;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCh2);
            Controls.Add(txtRez);
            Controls.Add(txtCh1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbxAct);
            Controls.Add(button2);
            Controls.Add(btnOk);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            Click += Calculator_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button button2;
        private ComboBox cmbxAct;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCh1;
        private TextBox txtRez;
        private TextBox txtCh2;
    }
}