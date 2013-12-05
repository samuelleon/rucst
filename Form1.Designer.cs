namespace PoS_small
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
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.qty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.btnFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(12, 13);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(165, 21);
            this.cbItems.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(102, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 22);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Location = new System.Drawing.Point(12, 47);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(23, 13);
            this.qty.TabIndex = 8;
            this.qty.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(41, 44);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 20);
            this.txtQty.TabIndex = 1;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDue
            // 
            this.txtDue.BackColor = System.Drawing.Color.White;
            this.txtDue.Location = new System.Drawing.Point(446, 13);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 3;
            this.txtDue.TabStop = false;
            this.txtDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.White;
            this.txtPaid.Location = new System.Drawing.Point(446, 39);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(100, 20);
            this.txtPaid.TabIndex = 4;
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.White;
            this.txtChange.Location = new System.Drawing.Point(446, 65);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 5;
            this.txtChange.TabStop = false;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Location = new System.Drawing.Point(396, 16);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(27, 13);
            this.lblDue.TabIndex = 9;
            this.lblDue.Text = "Due";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(396, 42);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(28, 13);
            this.lblPaid.TabIndex = 10;
            this.lblPaid.Text = "Paid";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(396, 68);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(44, 13);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = "Change";
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Location = new System.Drawing.Point(15, 91);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.Size = new System.Drawing.Size(534, 171);
            this.dgvSale.TabIndex = 6;
            this.dgvSale.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(552, 251);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 31);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 294);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbItems);
            this.Name = "Form1";
            this.Text = "Point of Sale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnFinish;
    }
}

