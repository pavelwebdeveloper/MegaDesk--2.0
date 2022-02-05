namespace MegaDesk_Christensen
{
    partial class ViewAllQuotes
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentRushComboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDepthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDrawersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desktopMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalForQuoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(329, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.rushOrderDataGridViewTextBoxColumn,
            this.currentRushComboDataGridViewTextBoxColumn,
            this.deskWidthDataGridViewTextBoxColumn,
            this.deskDepthDataGridViewTextBoxColumn,
            this.numberOfDrawersDataGridViewTextBoxColumn,
            this.desktopMaterialDataGridViewTextBoxColumn,
            this.deskDataGridViewTextBoxColumn,
            this.quoteDateDataGridViewTextBoxColumn,
            this.totalForQuoteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deskQuoteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 312);
            this.dataGridView1.TabIndex = 2;
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(MegaDesk_Christensen.DeskQuote);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // rushOrderDataGridViewTextBoxColumn
            // 
            this.rushOrderDataGridViewTextBoxColumn.DataPropertyName = "RushOrder";
            this.rushOrderDataGridViewTextBoxColumn.HeaderText = "RushOrder";
            this.rushOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rushOrderDataGridViewTextBoxColumn.Name = "rushOrderDataGridViewTextBoxColumn";
            this.rushOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentRushComboDataGridViewTextBoxColumn
            // 
            this.currentRushComboDataGridViewTextBoxColumn.DataPropertyName = "CurrentRushCombo";
            this.currentRushComboDataGridViewTextBoxColumn.HeaderText = "CurrentRushCombo";
            this.currentRushComboDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentRushComboDataGridViewTextBoxColumn.Name = "currentRushComboDataGridViewTextBoxColumn";
            this.currentRushComboDataGridViewTextBoxColumn.Width = 125;
            // 
            // deskWidthDataGridViewTextBoxColumn
            // 
            this.deskWidthDataGridViewTextBoxColumn.DataPropertyName = "DeskWidth";
            this.deskWidthDataGridViewTextBoxColumn.HeaderText = "DeskWidth";
            this.deskWidthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskWidthDataGridViewTextBoxColumn.Name = "deskWidthDataGridViewTextBoxColumn";
            this.deskWidthDataGridViewTextBoxColumn.Width = 125;
            // 
            // deskDepthDataGridViewTextBoxColumn
            // 
            this.deskDepthDataGridViewTextBoxColumn.DataPropertyName = "DeskDepth";
            this.deskDepthDataGridViewTextBoxColumn.HeaderText = "DeskDepth";
            this.deskDepthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskDepthDataGridViewTextBoxColumn.Name = "deskDepthDataGridViewTextBoxColumn";
            this.deskDepthDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfDrawersDataGridViewTextBoxColumn
            // 
            this.numberOfDrawersDataGridViewTextBoxColumn.DataPropertyName = "Number_Of_Drawers";
            this.numberOfDrawersDataGridViewTextBoxColumn.HeaderText = "Number_Of_Drawers";
            this.numberOfDrawersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfDrawersDataGridViewTextBoxColumn.Name = "numberOfDrawersDataGridViewTextBoxColumn";
            this.numberOfDrawersDataGridViewTextBoxColumn.Width = 125;
            // 
            // desktopMaterialDataGridViewTextBoxColumn
            // 
            this.desktopMaterialDataGridViewTextBoxColumn.DataPropertyName = "Desktop_Material";
            this.desktopMaterialDataGridViewTextBoxColumn.HeaderText = "Desktop_Material";
            this.desktopMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.desktopMaterialDataGridViewTextBoxColumn.Name = "desktopMaterialDataGridViewTextBoxColumn";
            this.desktopMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // deskDataGridViewTextBoxColumn
            // 
            this.deskDataGridViewTextBoxColumn.DataPropertyName = "Desk";
            this.deskDataGridViewTextBoxColumn.HeaderText = "Desk";
            this.deskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskDataGridViewTextBoxColumn.Name = "deskDataGridViewTextBoxColumn";
            this.deskDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoteDateDataGridViewTextBoxColumn
            // 
            this.quoteDateDataGridViewTextBoxColumn.DataPropertyName = "Quote_Date";
            this.quoteDateDataGridViewTextBoxColumn.HeaderText = "Quote_Date";
            this.quoteDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoteDateDataGridViewTextBoxColumn.Name = "quoteDateDataGridViewTextBoxColumn";
            this.quoteDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalForQuoteDataGridViewTextBoxColumn
            // 
            this.totalForQuoteDataGridViewTextBoxColumn.DataPropertyName = "Total_For_Quote";
            this.totalForQuoteDataGridViewTextBoxColumn.HeaderText = "Total_For_Quote";
            this.totalForQuoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalForQuoteDataGridViewTextBoxColumn.Name = "totalForQuoteDataGridViewTextBoxColumn";
            this.totalForQuoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentRushComboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDepthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDrawersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desktopMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalForQuoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
    }
}