namespace StrategyPattern
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstrategias = new System.Windows.Forms.ComboBox();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.cmdShoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapon";
            // 
            // cboEstrategias
            // 
            this.cboEstrategias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstrategias.FormattingEnabled = true;
            this.cboEstrategias.Location = new System.Drawing.Point(89, 231);
            this.cboEstrategias.Name = "cboEstrategias";
            this.cboEstrategias.Size = new System.Drawing.Size(370, 24);
            this.cboEstrategias.TabIndex = 1;
            // 
            // cmdSelect
            // 
            this.cmdSelect.Location = new System.Drawing.Point(89, 274);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(140, 23);
            this.cmdSelect.TabIndex = 2;
            this.cmdSelect.Text = "Select Weapon";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(86, 66);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(46, 17);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "label3";
            // 
            // cmdShoot
            // 
            this.cmdShoot.Location = new System.Drawing.Point(89, 103);
            this.cmdShoot.Name = "cmdShoot";
            this.cmdShoot.Size = new System.Drawing.Size(75, 23);
            this.cmdShoot.TabIndex = 5;
            this.cmdShoot.Text = "Shoot";
            this.cmdShoot.UseVisualStyleBackColor = true;
            this.cmdShoot.Click += new System.EventHandler(this.cmdShoot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdShoot);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.cboEstrategias);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstrategias;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button cmdShoot;
    }
}

