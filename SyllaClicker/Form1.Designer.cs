namespace SyllaClicker
{
    partial class Form1
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
            hotkeyLabel = new Label();
            hotkeyButton = new Button();
            hotkey = new Label();
            minCps = new Label();
            maxCps = new Label();
            minCpsBox = new TextBox();
            maxCpsBox = new TextBox();
            githubLink = new Label();
            SuspendLayout();
            // 
            // hotkeyLabel
            // 
            hotkeyLabel.AutoSize = true;
            hotkeyLabel.Location = new Point(12, 9);
            hotkeyLabel.Name = "hotkeyLabel";
            hotkeyLabel.Size = new Size(48, 15);
            hotkeyLabel.TabIndex = 0;
            hotkeyLabel.Text = "Hotkey:";
            // 
            // hotkeyButton
            // 
            hotkeyButton.Cursor = Cursors.Hand;
            hotkeyButton.Location = new Point(12, 39);
            hotkeyButton.Name = "hotkeyButton";
            hotkeyButton.Size = new Size(98, 23);
            hotkeyButton.TabIndex = 1;
            hotkeyButton.Text = "Change Hotkey";
            hotkeyButton.UseVisualStyleBackColor = true;
            // 
            // hotkey
            // 
            hotkey.AutoSize = true;
            hotkey.Location = new Point(79, 9);
            hotkey.Name = "hotkey";
            hotkey.Size = new Size(19, 15);
            hotkey.TabIndex = 2;
            hotkey.Text = "F5";
            // 
            // minCps
            // 
            minCps.AutoSize = true;
            minCps.Location = new Point(123, 9);
            minCps.Name = "minCps";
            minCps.Size = new Size(55, 15);
            minCps.TabIndex = 3;
            minCps.Text = "Min CPS:";
            // 
            // maxCps
            // 
            maxCps.AutoSize = true;
            maxCps.Location = new Point(216, 9);
            maxCps.Name = "maxCps";
            maxCps.Size = new Size(56, 15);
            maxCps.TabIndex = 4;
            maxCps.Text = "Max CPS:";
            // 
            // minCpsBox
            // 
            minCpsBox.Location = new Point(184, 6);
            minCpsBox.MaxLength = 3;
            minCpsBox.Name = "minCpsBox";
            minCpsBox.Size = new Size(26, 23);
            minCpsBox.TabIndex = 5;
            minCpsBox.Text = "0";
            minCpsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // maxCpsBox
            // 
            maxCpsBox.Location = new Point(278, 6);
            maxCpsBox.MaxLength = 3;
            maxCpsBox.Name = "maxCpsBox";
            maxCpsBox.Size = new Size(26, 23);
            maxCpsBox.TabIndex = 6;
            maxCpsBox.Text = "10";
            maxCpsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // githubLink
            // 
            githubLink.AutoSize = true;
            githubLink.Cursor = Cursors.Hand;
            githubLink.Location = new Point(259, 47);
            githubLink.Name = "githubLink";
            githubLink.Size = new Size(45, 15);
            githubLink.TabIndex = 7;
            githubLink.Text = "GitHub";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 74);
            Controls.Add(githubLink);
            Controls.Add(maxCpsBox);
            Controls.Add(minCpsBox);
            Controls.Add(maxCps);
            Controls.Add(minCps);
            Controls.Add(hotkey);
            Controls.Add(hotkeyButton);
            Controls.Add(hotkeyLabel);
            KeyPreview = true;
            Name = "Form1";
            Text = "SyllaClicker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hotkeyLabel;
        private Button hotkeyButton;
        private Label hotkey;
        private Label minCps;
        private Label maxCps;
        private TextBox minCpsBox;
        private TextBox maxCpsBox;
        private Label githubLink;
    }
}
