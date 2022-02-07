namespace List
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
            this.btnFillList = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.dataGridDaylist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillList
            // 
            this.btnFillList.Location = new System.Drawing.Point(253, 129);
            this.btnFillList.Name = "btnFillList";
            this.btnFillList.Size = new System.Drawing.Size(136, 23);
            this.btnFillList.TabIndex = 0;
            this.btnFillList.Text = "Fill List";
            this.btnFillList.UseVisualStyleBackColor = true;
            this.btnFillList.Click += new System.EventHandler(this.btnFillList_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(262, 178);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(127, 175);
            this.txtNumber.TabIndex = 1;
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(507, 28);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 24);
            this.cmbDays.TabIndex = 2;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // dataGridDaylist
            // 
            this.dataGridDaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDaylist.Location = new System.Drawing.Point(420, 178);
            this.dataGridDaylist.Name = "dataGridDaylist";
            this.dataGridDaylist.RowHeadersWidth = 51;
            this.dataGridDaylist.RowTemplate.Height = 24;
            this.dataGridDaylist.Size = new System.Drawing.Size(327, 124);
            this.dataGridDaylist.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDaylist);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnFillList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFillList;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.DataGridView dataGridDaylist;
    }
}

