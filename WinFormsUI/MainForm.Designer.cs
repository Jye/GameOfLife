namespace WinFormsUI
{
    partial class MainForm
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
            this.cellsPanel = new WinFormsUI.MainForm.DoubleBufferedPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.autoStepCheckBox = new System.Windows.Forms.CheckBox();
            this.stepButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cellsPanel
            // 
            this.cellsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellsPanel.Location = new System.Drawing.Point(0, 0);
            this.cellsPanel.Name = "cellsPanel";
            this.cellsPanel.Size = new System.Drawing.Size(609, 437);
            this.cellsPanel.TabIndex = 1;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.clearButton);
            this.menuPanel.Controls.Add(this.autoStepCheckBox);
            this.menuPanel.Controls.Add(this.stepButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuPanel.Location = new System.Drawing.Point(609, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(100, 437);
            this.menuPanel.TabIndex = 0;
            // 
            // autoStepCheckBox
            // 
            this.autoStepCheckBox.AutoSize = true;
            this.autoStepCheckBox.Location = new System.Drawing.Point(10, 12);
            this.autoStepCheckBox.Name = "autoStepCheckBox";
            this.autoStepCheckBox.Size = new System.Drawing.Size(71, 17);
            this.autoStepCheckBox.TabIndex = 1;
            this.autoStepCheckBox.Text = "Auto-step";
            this.autoStepCheckBox.UseVisualStyleBackColor = true;
            // 
            // stepButton
            // 
            this.stepButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepButton.Location = new System.Drawing.Point(10, 41);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 0;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(10, 70);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 437);
            this.Controls.Add(this.cellsPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedPanel cellsPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.CheckBox autoStepCheckBox;
        private System.Windows.Forms.Button clearButton;

    }
}

