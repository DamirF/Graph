namespace Graph
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelScale = new System.Windows.Forms.Panel();
            this.ScalePlus = new System.Windows.Forms.Button();
            this.ScaleMinus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelShift = new System.Windows.Forms.Panel();
            this.ShiftRight = new System.Windows.Forms.Button();
            this.ShiftLeft = new System.Windows.Forms.Button();
            this.Field = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelScale.SuspendLayout();
            this.panelShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.panelScale);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.panelShift);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(900, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 900);
            this.panelMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 716);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Масштаб";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelScale
            // 
            this.panelScale.Controls.Add(this.ScalePlus);
            this.panelScale.Controls.Add(this.ScaleMinus);
            this.panelScale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelScale.Location = new System.Drawing.Point(0, 756);
            this.panelScale.Name = "panelScale";
            this.panelScale.Size = new System.Drawing.Size(296, 50);
            this.panelScale.TabIndex = 2;
            // 
            // ScalePlus
            // 
            this.ScalePlus.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScalePlus.Location = new System.Drawing.Point(150, 0);
            this.ScalePlus.Name = "ScalePlus";
            this.ScalePlus.Size = new System.Drawing.Size(146, 50);
            this.ScalePlus.TabIndex = 1;
            this.ScalePlus.Text = "+";
            this.ScalePlus.UseVisualStyleBackColor = true;
            this.ScalePlus.Click += new System.EventHandler(this.ScalePlus_Click);
            // 
            // ScaleMinus
            // 
            this.ScaleMinus.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScaleMinus.Location = new System.Drawing.Point(0, 0);
            this.ScaleMinus.Name = "ScaleMinus";
            this.ScaleMinus.Size = new System.Drawing.Size(146, 50);
            this.ScaleMinus.TabIndex = 0;
            this.ScaleMinus.Text = "-";
            this.ScaleMinus.UseVisualStyleBackColor = true;
            this.ScaleMinus.Click += new System.EventHandler(this.ScaleMinus_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 806);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сдвиг";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelShift
            // 
            this.panelShift.Controls.Add(this.ShiftRight);
            this.panelShift.Controls.Add(this.ShiftLeft);
            this.panelShift.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShift.Location = new System.Drawing.Point(0, 846);
            this.panelShift.Name = "panelShift";
            this.panelShift.Size = new System.Drawing.Size(296, 50);
            this.panelShift.TabIndex = 0;
            // 
            // ShiftRight
            // 
            this.ShiftRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShiftRight.Location = new System.Drawing.Point(150, 0);
            this.ShiftRight.Name = "ShiftRight";
            this.ShiftRight.Size = new System.Drawing.Size(146, 50);
            this.ShiftRight.TabIndex = 1;
            this.ShiftRight.Text = "->";
            this.ShiftRight.UseVisualStyleBackColor = true;
            this.ShiftRight.Click += new System.EventHandler(this.ShiftRight_Click);
            // 
            // ShiftLeft
            // 
            this.ShiftLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShiftLeft.Location = new System.Drawing.Point(0, 0);
            this.ShiftLeft.Name = "ShiftLeft";
            this.ShiftLeft.Size = new System.Drawing.Size(146, 50);
            this.ShiftLeft.TabIndex = 0;
            this.ShiftLeft.Text = "<-";
            this.ShiftLeft.UseVisualStyleBackColor = true;
            this.ShiftLeft.Click += new System.EventHandler(this.ShiftLeft_Click);
            // 
            // Field
            // 
            this.Field.BackColor = System.Drawing.Color.White;
            this.Field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Field.Location = new System.Drawing.Point(0, 0);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(900, 900);
            this.Field.TabIndex = 1;
            this.Field.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1218, 947);
            this.MinimumSize = new System.Drawing.Size(1218, 947);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelScale.ResumeLayout(false);
            this.panelShift.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox Field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelShift;
        private System.Windows.Forms.Button ScalePlus;
        private System.Windows.Forms.Button ScaleMinus;
        private System.Windows.Forms.Button ShiftRight;
        private System.Windows.Forms.Button ShiftLeft;
    }
}
