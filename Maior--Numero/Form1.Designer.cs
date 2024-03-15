namespace Maior__Numero
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
            lbResultado = new Label();
            btnMaior = new Button();
            txtVal03 = new TextBox();
            txtVal02 = new TextBox();
            txtVal01 = new TextBox();
            lb01 = new Label();
            SuspendLayout();
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(253, 109);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(108, 25);
            lbResultado.TabIndex = 11;
            lbResultado.Text = "                        ";
            lbResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMaior
            // 
            btnMaior.BackColor = Color.Green;
            btnMaior.Cursor = Cursors.Hand;
            btnMaior.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaior.ForeColor = Color.White;
            btnMaior.Location = new Point(249, 54);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(112, 52);
            btnMaior.TabIndex = 10;
            btnMaior.Text = "Clique";
            btnMaior.UseVisualStyleBackColor = false;
            btnMaior.Click += btnMaior_Click;
            // 
            // txtVal03
            // 
            txtVal03.Location = new Point(143, 112);
            txtVal03.Name = "txtVal03";
            txtVal03.Size = new Size(100, 23);
            txtVal03.TabIndex = 9;
            // 
            // txtVal02
            // 
            txtVal02.Location = new Point(143, 83);
            txtVal02.Name = "txtVal02";
            txtVal02.Size = new Size(100, 23);
            txtVal02.TabIndex = 8;
            // 
            // txtVal01
            // 
            txtVal01.Location = new Point(143, 54);
            txtVal01.Name = "txtVal01";
            txtVal01.Size = new Size(100, 23);
            txtVal01.TabIndex = 7;
            // 
            // lb01
            // 
            lb01.AutoSize = true;
            lb01.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb01.Location = new Point(170, 15);
            lb01.Name = "lb01";
            lb01.Size = new Size(150, 36);
            lb01.TabIndex = 6;
            lb01.Text = "Digite 3 valores";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btnMaior);
            Controls.Add(txtVal03);
            Controls.Add(txtVal02);
            Controls.Add(txtVal01);
            Controls.Add(lb01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultado;
        private Button btnMaior;
        private TextBox txtVal03;
        private TextBox txtVal02;
        private TextBox txtVal01;
        private Label lb01;
    }
}
