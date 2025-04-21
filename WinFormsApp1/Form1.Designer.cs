namespace WinFormsApp1
{
    partial class MyBD
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
            TableDB = new ToolStripMenuItem();
            OpenTableOsoba = new ToolStripMenuItem();
            OpenTableKatalog = new ToolStripMenuItem();
            OpenTableFormuliar = new ToolStripMenuItem();
            адмініструванняToolStripMenuItem = new ToolStripMenuItem();
            калькуляторToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TableDB
            // 
            TableDB.DropDownItems.AddRange(new ToolStripItem[] { OpenTableOsoba, OpenTableKatalog, OpenTableFormuliar });
            TableDB.Name = "TableDB";
            TableDB.Size = new Size(81, 20);
            TableDB.Text = "Таблиці БД";
            // 
            // OpenTableOsoba
            // 
            OpenTableOsoba.Image = Properties.Resources.Знімок_екрана_2025_04_02_062537;
            OpenTableOsoba.Name = "OpenTableOsoba";
            OpenTableOsoba.ShortcutKeys = Keys.Control | Keys.F1;
            OpenTableOsoba.Size = new Size(178, 22);
            OpenTableOsoba.Text = "Читачі";
            OpenTableOsoba.Click += OpenTableOsoba_Click;
            // 
            // OpenTableKatalog
            // 
            OpenTableKatalog.Image = Properties.Resources.книга;
            OpenTableKatalog.Name = "OpenTableKatalog";
            OpenTableKatalog.ShortcutKeys = Keys.Control | Keys.F2;
            OpenTableKatalog.Size = new Size(178, 22);
            OpenTableKatalog.Text = "Каталог";
            OpenTableKatalog.Click += OpenTableKatalog_Click;
            // 
            // OpenTableFormuliar
            // 
            OpenTableFormuliar.Image = Properties.Resources.Знімок_екрана_2025_04_02_062341;
            OpenTableFormuliar.Name = "OpenTableFormuliar";
            OpenTableFormuliar.ShortcutKeys = Keys.Control | Keys.F3;
            OpenTableFormuliar.Size = new Size(178, 22);
            OpenTableFormuliar.Text = "Формуляр";
            OpenTableFormuliar.Click += OpenTableFormuliar_Click;
            // 
            // адмініструванняToolStripMenuItem
            // 
            адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            адмініструванняToolStripMenuItem.Size = new Size(111, 20);
            адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // калькуляторToolStripMenuItem
            // 
            калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            калькуляторToolStripMenuItem.Size = new Size(89, 20);
            калькуляторToolStripMenuItem.Text = "Калькулятор";
            калькуляторToolStripMenuItem.Click += калькуляторToolStripMenuItem_Click;
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(99, 20);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(47, 20);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TableDB, адмініструванняToolStripMenuItem, калькуляторToolStripMenuItem, проПрограмуToolStripMenuItem, вихідToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // MyBD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MyBD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бібліотека";
            FormClosed += MyBD_FormClosed;
            Load += MyBD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem TableDB;
        private ToolStripMenuItem OpenTableOsoba;
        private ToolStripMenuItem OpenTableKatalog;
        private ToolStripMenuItem OpenTableFormuliar;
        private ToolStripMenuItem адмініструванняToolStripMenuItem;
        private ToolStripMenuItem калькуляторToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
