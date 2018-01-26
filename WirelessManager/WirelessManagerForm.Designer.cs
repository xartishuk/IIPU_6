namespace WirelessManager
{
    partial class WirelessManagerForm
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
            this.NetworksGridView = new System.Windows.Forms.DataGridView();
            this.NameColumt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityColumt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthenticationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NetworksGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NetworksGridView
            // 
            this.NetworksGridView.AllowUserToAddRows = false;
            this.NetworksGridView.AllowUserToDeleteRows = false;
            this.NetworksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NetworksGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.NetworksGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetworksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NetworksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumt,
            this.QualityColumt,
            this.AuthenticationColumn,
            this.MACColumn});
            this.NetworksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetworksGridView.Location = new System.Drawing.Point(3, 3);
            this.NetworksGridView.Name = "NetworksGridView";
            this.NetworksGridView.ReadOnly = true;
            this.NetworksGridView.Size = new System.Drawing.Size(653, 271);
            this.NetworksGridView.TabIndex = 0;
            this.NetworksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NetworksGridView_CellContentClick);
            // 
            // NameColumt
            // 
            this.NameColumt.HeaderText = "Name";
            this.NameColumt.Name = "NameColumt";
            this.NameColumt.ReadOnly = true;
            // 
            // QualityColumt
            // 
            this.QualityColumt.HeaderText = "Quality";
            this.QualityColumt.Name = "QualityColumt";
            this.QualityColumt.ReadOnly = true;
            // 
            // AuthenticationColumn
            // 
            this.AuthenticationColumn.HeaderText = "Authentication";
            this.AuthenticationColumn.Name = "AuthenticationColumn";
            this.AuthenticationColumn.ReadOnly = true;
            // 
            // MACColumn
            // 
            this.MACColumn.HeaderText = "MAC";
            this.MACColumn.Name = "MACColumn";
            this.MACColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.355F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NetworksGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 410);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.connectedLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 280);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(653, 127);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.passwordTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.passwordLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.connectButton, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(320, 121);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(3, 39);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(314, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(3, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(314, 36);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectButton
            // 
            this.connectButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectButton.Location = new System.Drawing.Point(122, 67);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedLabel.Location = new System.Drawing.Point(329, 0);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(321, 127);
            this.connectedLabel.TabIndex = 1;
            this.connectedLabel.Text = "...";
            this.connectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WirelessManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WirelessManagerForm";
            this.Text = "Wireless Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WirelessManagerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NetworksGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NetworksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityColumt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthenticationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label connectedLabel;
    }
}

