namespace RungeKutta4
{
    partial class FormMy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задатьПараметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormulaSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_a);
            this.groupBox1.Controls.Add(this.textBox_h);
            this.groupBox1.Controls.Add(this.textBox_y0);
            this.groupBox1.Controls.Add(this.textBox_x0);
            this.groupBox1.Controls.Add(this.textBox_b);
            this.groupBox1.Controls.Add(this.textBox_a);
            this.groupBox1.Controls.Add(this.button_solve);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 45);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Функция:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Шаг (h) = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "y_0=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "x_0=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "b]=";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(6, 22);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(22, 13);
            this.label_a.TabIndex = 6;
            this.label_a.Text = "[a ;";
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(296, 22);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 20);
            this.textBox_h.TabIndex = 5;
            // 
            // textBox_y0
            // 
            this.textBox_y0.Location = new System.Drawing.Point(136, 58);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(34, 20);
            this.textBox_y0.TabIndex = 4;
            // 
            // textBox_x0
            // 
            this.textBox_x0.Location = new System.Drawing.Point(50, 58);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(34, 20);
            this.textBox_x0.TabIndex = 3;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(103, 19);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(36, 20);
            this.textBox_b.TabIndex = 2;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(53, 19);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(31, 20);
            this.textBox_a.TabIndex = 1;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(677, 9);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(156, 76);
            this.button_solve.TabIndex = 0;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zedGraph);
            this.groupBox2.Location = new System.Drawing.Point(2, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Решение";
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.Location = new System.Drawing.Point(5, 19);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(828, 387);
            this.zedGraph.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Точность  = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьПараметрыToolStripMenuItem,
            this.сохранитьРезультатыToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задатьПараметрыToolStripMenuItem
            // 
            this.задатьПараметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomSetToolStripMenuItem,
            this.изФайлаToolStripMenuItem,
            this.FormulaSetToolStripMenuItem});
            this.задатьПараметрыToolStripMenuItem.Name = "задатьПараметрыToolStripMenuItem";
            this.задатьПараметрыToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.задатьПараметрыToolStripMenuItem.Text = "Задать параметры";
            // 
            // сохранитьРезультатыToolStripMenuItem
            // 
            this.сохранитьРезультатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToTextToolStripMenuItem,
            this.ToWordToolStripMenuItem});
            this.сохранитьРезультатыToolStripMenuItem.Name = "сохранитьРезультатыToolStripMenuItem";
            this.сохранитьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.сохранитьРезультатыToolStripMenuItem.Text = "Сохранить результаты";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // RandomSetToolStripMenuItem
            // 
            this.RandomSetToolStripMenuItem.Name = "RandomSetToolStripMenuItem";
            this.RandomSetToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.RandomSetToolStripMenuItem.Text = "Случайным образом";
            this.RandomSetToolStripMenuItem.Click += new System.EventHandler(this.RandomSetToolStripMenuItem_Click);
            // 
            // изФайлаToolStripMenuItem
            // 
            this.изФайлаToolStripMenuItem.Name = "изФайлаToolStripMenuItem";
            this.изФайлаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.изФайлаToolStripMenuItem.Text = "Из файла";
            this.изФайлаToolStripMenuItem.Click += new System.EventHandler(this.изФайлаToolStripMenuItem_Click);
            // 
            // FormulaSetToolStripMenuItem
            // 
            this.FormulaSetToolStripMenuItem.Name = "FormulaSetToolStripMenuItem";
            this.FormulaSetToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.FormulaSetToolStripMenuItem.Text = "По формуле";
            this.FormulaSetToolStripMenuItem.Click += new System.EventHandler(this.FormulaSetToolStripMenuItem_Click);
            // 
            // ToTextToolStripMenuItem
            // 
            this.ToTextToolStripMenuItem.Name = "ToTextToolStripMenuItem";
            this.ToTextToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ToTextToolStripMenuItem.Text = "Текстовый файл";
            this.ToTextToolStripMenuItem.Click += new System.EventHandler(this.ToTextToolStripMenuItem_Click);
            // 
            // ToWordToolStripMenuItem
            // 
            this.ToWordToolStripMenuItem.Name = "ToWordToolStripMenuItem";
            this.ToWordToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ToWordToolStripMenuItem.Text = "Файл Word";
            this.ToWordToolStripMenuItem.Click += new System.EventHandler(this.ToWordToolStripMenuItem_Click);
            // 
            // FormMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(845, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(861, 586);
            this.MinimumSize = new System.Drawing.Size(861, 586);
            this.Name = "FormMy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение ДУ методом Рунге-Кутта 4 порядка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_y0;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задатьПараметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormulaSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToWordToolStripMenuItem;
    }
}

