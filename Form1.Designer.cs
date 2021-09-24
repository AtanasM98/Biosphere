
namespace Biosphere
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tbGridSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genGrid = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.tbFloat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbFloat);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.tbGridSize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.genGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Location = new System.Drawing.Point(691, 8);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tbGridSize
            // 
            this.tbGridSize.Location = new System.Drawing.Point(93, 14);
            this.tbGridSize.Name = "tbGridSize";
            this.tbGridSize.Size = new System.Drawing.Size(100, 20);
            this.tbGridSize.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grid Size:";
            // 
            // genGrid
            // 
            this.genGrid.Location = new System.Drawing.Point(199, 12);
            this.genGrid.Name = "genGrid";
            this.genGrid.Size = new System.Drawing.Size(75, 23);
            this.genGrid.TabIndex = 1;
            this.genGrid.Text = "Create Grid";
            this.genGrid.UseVisualStyleBackColor = true;
            this.genGrid.Click += new System.EventHandler(this.genGrid_Click);
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 100);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(778, 409);
            this.canvas.TabIndex = 1;
            this.canvas.Resize += new System.EventHandler(this.canvas_Resize);
            // 
            // tbFloat
            // 
            this.tbFloat.Location = new System.Drawing.Point(93, 40);
            this.tbFloat.Name = "tbFloat";
            this.tbFloat.Size = new System.Drawing.Size(100, 20);
            this.tbFloat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Float Val:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 509);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.TextBox tbGridSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genGrid;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFloat;
    }
}

