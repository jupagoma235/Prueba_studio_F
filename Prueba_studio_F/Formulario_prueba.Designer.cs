namespace Prueba_studio_F
{
    partial class Formulario_prueba
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_bsc = new System.Windows.Forms.Button();
            this.bt_rpt = new System.Windows.Forms.Button();
            this.bt_des = new System.Windows.Forms.Button();
            this.bt_asc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.bt_bsc);
            this.groupBox1.Controls.Add(this.bt_rpt);
            this.groupBox1.Controls.Add(this.bt_des);
            this.groupBox1.Controls.Add(this.bt_asc);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejercicio de trabajo con listas";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(22, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adiciona número";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(219, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 254);
            this.listBox1.TabIndex = 6;
            // 
            // bt_bsc
            // 
            this.bt_bsc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_bsc.Location = new System.Drawing.Point(22, 209);
            this.bt_bsc.Name = "bt_bsc";
            this.bt_bsc.Size = new System.Drawing.Size(158, 31);
            this.bt_bsc.TabIndex = 5;
            this.bt_bsc.Text = "Buscar elemento";
            this.bt_bsc.UseVisualStyleBackColor = true;
            this.bt_bsc.Click += new System.EventHandler(this.bt_bsc_Click);
            // 
            // bt_rpt
            // 
            this.bt_rpt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_rpt.Location = new System.Drawing.Point(22, 321);
            this.bt_rpt.Name = "bt_rpt";
            this.bt_rpt.Size = new System.Drawing.Size(158, 31);
            this.bt_rpt.TabIndex = 4;
            this.bt_rpt.Text = "Repetidos";
            this.bt_rpt.UseVisualStyleBackColor = true;
            this.bt_rpt.Click += new System.EventHandler(this.bt_rpt_Click);
            // 
            // bt_des
            // 
            this.bt_des.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_des.Location = new System.Drawing.Point(22, 284);
            this.bt_des.Name = "bt_des";
            this.bt_des.Size = new System.Drawing.Size(158, 31);
            this.bt_des.TabIndex = 3;
            this.bt_des.Text = "Orden descendente";
            this.bt_des.UseVisualStyleBackColor = true;
            this.bt_des.Click += new System.EventHandler(this.bt_des_Click);
            // 
            // bt_asc
            // 
            this.bt_asc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_asc.Location = new System.Drawing.Point(22, 247);
            this.bt_asc.Name = "bt_asc";
            this.bt_asc.Size = new System.Drawing.Size(158, 31);
            this.bt_asc.TabIndex = 2;
            this.bt_asc.Text = "Orden ascendente";
            this.bt_asc.UseVisualStyleBackColor = true;
            this.bt_asc.Click += new System.EventHandler(this.bt_asc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 31);
            this.textBox1.TabIndex = 0;
            // 
            // Formulario_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formulario_prueba";
            this.Text = "Prueba Studio F";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_asc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bt_des;
        private System.Windows.Forms.Button bt_bsc;
        private System.Windows.Forms.Button bt_rpt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

