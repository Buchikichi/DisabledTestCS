namespace DisabledTestApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondPanel = new System.Windows.Forms.Panel();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.ThirdPanel = new DisabledTestApp.Custom.CustomPanel();
            this.ThirdTextBox = new System.Windows.Forms.TextBox();
            this.ThirdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DummyButton = new System.Windows.Forms.Button();
            this.SecondLabel = new DisabledTestApp.Custom.CustomLabel();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPanel)).BeginInit();
            this.ThirdPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(4, 14);
            this.FirstButton.Margin = new System.Windows.Forms.Padding(4);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(112, 32);
            this.FirstButton.TabIndex = 1;
            this.FirstButton.Text = "TopPanel";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ExitButton);
            this.BottomPanel.Controls.Add(this.ThirdButton);
            this.BottomPanel.Controls.Add(this.SecondButton);
            this.BottomPanel.Controls.Add(this.FirstButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 391);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(624, 50);
            this.BottomPanel.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(546, 15);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 32);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ThirdButton
            // 
            this.ThirdButton.Location = new System.Drawing.Point(244, 14);
            this.ThirdButton.Margin = new System.Windows.Forms.Padding(4);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(112, 32);
            this.ThirdButton.TabIndex = 1;
            this.ThirdButton.Text = "ThirdPanel";
            this.ThirdButton.UseVisualStyleBackColor = true;
            this.ThirdButton.Click += new System.EventHandler(this.ThirdButton_Click);
            // 
            // SecondButton
            // 
            this.SecondButton.Location = new System.Drawing.Point(124, 14);
            this.SecondButton.Margin = new System.Windows.Forms.Padding(4);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(112, 32);
            this.SecondButton.TabIndex = 1;
            this.SecondButton.Text = "SecondPanel";
            this.SecondButton.UseVisualStyleBackColor = true;
            this.SecondButton.Click += new System.EventHandler(this.SecondButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.FirstTextBox);
            this.TopPanel.Controls.Add(this.FirstLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(624, 50);
            this.TopPanel.TabIndex = 3;
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Location = new System.Drawing.Point(85, 10);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(294, 23);
            this.FirstTextBox.TabIndex = 1;
            this.FirstTextBox.Text = "こっちは通常";
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.FirstLabel.ForeColor = System.Drawing.Color.White;
            this.FirstLabel.Location = new System.Drawing.Point(4, 9);
            this.FirstLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Padding = new System.Windows.Forms.Padding(4);
            this.FirstLabel.Size = new System.Drawing.Size(78, 24);
            this.FirstLabel.TabIndex = 0;
            this.FirstLabel.Text = "TopPanel";
            // 
            // SecondPanel
            // 
            this.SecondPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondPanel.Controls.Add(this.SecondTextBox);
            this.SecondPanel.Controls.Add(this.SecondLabel);
            this.SecondPanel.Location = new System.Drawing.Point(0, 57);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Size = new System.Drawing.Size(624, 50);
            this.SecondPanel.TabIndex = 4;
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(114, 10);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(294, 23);
            this.SecondTextBox.TabIndex = 1;
            this.SecondTextBox.Text = "←カスタムラベル";
            // 
            // ThirdPanel
            // 
            this.ThirdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThirdPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ThirdPanel.Controls.Add(this.ThirdTextBox);
            this.ThirdPanel.Controls.Add(this.ThirdLabel);
            this.ThirdPanel.Controls.Add(this.panel1);
            this.ThirdPanel.Location = new System.Drawing.Point(0, 113);
            this.ThirdPanel.Name = "ThirdPanel";
            this.ThirdPanel.Size = new System.Drawing.Size(624, 50);
            this.ThirdPanel.TabIndex = 4;
            this.ThirdPanel.TabStop = false;
            // 
            // ThirdTextBox
            // 
            this.ThirdTextBox.Location = new System.Drawing.Point(114, 10);
            this.ThirdTextBox.Name = "ThirdTextBox";
            this.ThirdTextBox.Size = new System.Drawing.Size(294, 23);
            this.ThirdTextBox.TabIndex = 1;
            this.ThirdTextBox.Text = "個別にやる";
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.AutoSize = true;
            this.ThirdLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.ThirdLabel.ForeColor = System.Drawing.Color.White;
            this.ThirdLabel.Location = new System.Drawing.Point(4, 9);
            this.ThirdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Padding = new System.Windows.Forms.Padding(4);
            this.ThirdLabel.Size = new System.Drawing.Size(87, 24);
            this.ThirdLabel.TabIndex = 0;
            this.ThirdLabel.Text = "ThirdPanel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DummyButton);
            this.panel1.Location = new System.Drawing.Point(480, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 44);
            this.panel1.TabIndex = 5;
            // 
            // DummyButton
            // 
            this.DummyButton.Location = new System.Drawing.Point(3, 4);
            this.DummyButton.Name = "DummyButton";
            this.DummyButton.Size = new System.Drawing.Size(75, 32);
            this.DummyButton.TabIndex = 0;
            this.DummyButton.Text = "Dummy";
            this.DummyButton.UseVisualStyleBackColor = true;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.SecondLabel.ForeColor = System.Drawing.Color.White;
            this.SecondLabel.Location = new System.Drawing.Point(4, 9);
            this.SecondLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Padding = new System.Windows.Forms.Padding(4);
            this.SecondLabel.Size = new System.Drawing.Size(103, 24);
            this.SecondLabel.TabIndex = 0;
            this.SecondLabel.Text = "SecondPanel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ThirdPanel);
            this.Controls.Add(this.SecondPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SecondPanel.ResumeLayout(false);
            this.SecondPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPanel)).EndInit();
            this.ThirdPanel.ResumeLayout(false);
            this.ThirdPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel SecondPanel;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.TextBox SecondTextBox;
        private Custom.CustomLabel SecondLabel;
        private Custom.CustomPanel ThirdPanel;
        private System.Windows.Forms.TextBox ThirdTextBox;
        private System.Windows.Forms.Label ThirdLabel;
        private System.Windows.Forms.Button ThirdButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DummyButton;
    }
}

