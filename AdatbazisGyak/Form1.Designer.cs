
namespace AdatbazisGyak
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnTorol = new System.Windows.Forms.Button();
            this.txtTorol = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(255, 116);
            this.dataGridView1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(27, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Adatok";
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(30, 229);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 2;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // txtTorol
            // 
            this.txtTorol.Location = new System.Drawing.Point(30, 203);
            this.txtTorol.Name = "txtTorol";
            this.txtTorol.Size = new System.Drawing.Size(100, 20);
            this.txtTorol.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(30, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTorol);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.TextBox txtTorol;
        private System.Windows.Forms.Button btnReset;
    }
}

