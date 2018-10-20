namespace Blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnComecar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMonte = new System.Windows.Forms.Button();
            this.pbMao2 = new System.Windows.Forms.PictureBox();
            this.pbMao1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMao1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(55, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "MONTE";
            // 
            // btnComecar
            // 
            this.btnComecar.BackColor = System.Drawing.Color.DarkRed;
            this.btnComecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComecar.ForeColor = System.Drawing.Color.White;
            this.btnComecar.Location = new System.Drawing.Point(47, 514);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(148, 35);
            this.btnComecar.TabIndex = 11;
            this.btnComecar.Text = "COMEÇAR JOGO";
            this.btnComecar.UseVisualStyleBackColor = false;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNumero.Location = new System.Drawing.Point(461, 294);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(75, 39);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "0";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultado.Location = new System.Drawing.Point(55, 54);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(286, 132);
            this.lblResultado.TabIndex = 14;
            // 
            // pbResultado
            // 
            this.pbResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResultado.Location = new System.Drawing.Point(614, 54);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(205, 132);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResultado.TabIndex = 15;
            this.pbResultado.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(461, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnMonte
            // 
            this.btnMonte.BackgroundImage = global::Blackjack.Properties.Resources.monteBJ;
            this.btnMonte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonte.Location = new System.Drawing.Point(62, 301);
            this.btnMonte.Name = "btnMonte";
            this.btnMonte.Size = new System.Drawing.Size(75, 108);
            this.btnMonte.TabIndex = 8;
            this.btnMonte.UseVisualStyleBackColor = true;
            // 
            // pbMao2
            // 
            this.pbMao2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMao2.Location = new System.Drawing.Point(511, 441);
            this.pbMao2.Name = "pbMao2";
            this.pbMao2.Size = new System.Drawing.Size(75, 108);
            this.pbMao2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMao2.TabIndex = 1;
            this.pbMao2.TabStop = false;
            // 
            // pbMao1
            // 
            this.pbMao1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMao1.Location = new System.Drawing.Point(415, 441);
            this.pbMao1.Name = "pbMao1";
            this.pbMao1.Size = new System.Drawing.Size(75, 108);
            this.pbMao1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMao1.TabIndex = 0;
            this.pbMao1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(848, 574);
            this.Controls.Add(this.pbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMonte);
            this.Controls.Add(this.pbMao2);
            this.Controls.Add(this.pbMao1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Real BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMao1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMao1;
        private System.Windows.Forms.PictureBox pbMao2;
        private System.Windows.Forms.Button btnMonte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pbResultado;
    }
}

