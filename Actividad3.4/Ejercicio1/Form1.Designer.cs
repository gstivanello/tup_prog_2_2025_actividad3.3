namespace Ejercicio1
{
    partial class Form1
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
            lbMostrar = new ListBox();
            btnAgregar = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbMostrar
            // 
            lbMostrar.FormattingEnabled = true;
            lbMostrar.ItemHeight = 15;
            lbMostrar.Location = new Point(30, 159);
            lbMostrar.Name = "lbMostrar";
            lbMostrar.Size = new Size(291, 154);
            lbMostrar.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(122, 38);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Crear Figura";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ortoedro";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cilindro";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(30, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 113);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(337, 159);
            button1.Name = "button1";
            button1.Size = new Size(91, 58);
            button1.TabIndex = 5;
            button1.Text = "Actualizar Listado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(337, 254);
            button2.Name = "button2";
            button2.Size = new Size(91, 59);
            button2.TabIndex = 6;
            button2.Text = "Mostrar mas datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(481, 226);
            label1.Name = "label1";
            label1.Size = new Size(255, 87);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(576, 53);
            button3.Name = "button3";
            button3.Size = new Size(107, 57);
            button3.TabIndex = 8;
            button3.Text = "Comparar Figuras";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(lbMostrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbMostrar;
        private Button btnAgregar;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}
