namespace Fates_Conversation_Helper
{
    partial class FatesHelperUI
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
            this.FatesLogoPB = new System.Windows.Forms.PictureBox();
            this.ChooseSideLabel = new System.Windows.Forms.Label();
            this.SidesComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseCharLabel = new System.Windows.Forms.Label();
            this.CharsComboBox = new System.Windows.Forms.ComboBox();
            this.PortraitSideLabel = new System.Windows.Forms.Label();
            this.NoPortraitChoiceBtn = new System.Windows.Forms.RadioButton();
            this.LeftChoiceBtn = new System.Windows.Forms.RadioButton();
            this.RightChoiceBtn = new System.Windows.Forms.RadioButton();
            this.EmotionLabel = new System.Windows.Forms.Label();
            this.EmotionsComboBox = new System.Windows.Forms.ComboBox();
            this.BlushCheckbox = new System.Windows.Forms.CheckBox();
            this.SweatDropCheckbox = new System.Windows.Forms.CheckBox();
            this.EnterDialogueLabel = new System.Windows.Forms.Label();
            this.DialogueTextBox = new System.Windows.Forms.TextBox();
            this.NewlineBtn = new System.Windows.Forms.Button();
            this.ScrollNextBtn = new System.Windows.Forms.Button();
            this.AddAvatarBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.PreviewTextBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FatesLogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // FatesLogoPB
            // 
            this.FatesLogoPB.Image = global::Fates_Conversation_Helper.Properties.Resources.FatesLogo;
            this.FatesLogoPB.Location = new System.Drawing.Point(104, 12);
            this.FatesLogoPB.Name = "FatesLogoPB";
            this.FatesLogoPB.Size = new System.Drawing.Size(576, 107);
            this.FatesLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FatesLogoPB.TabIndex = 0;
            this.FatesLogoPB.TabStop = false;
            // 
            // ChooseSideLabel
            // 
            this.ChooseSideLabel.AutoSize = true;
            this.ChooseSideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseSideLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChooseSideLabel.Location = new System.Drawing.Point(12, 155);
            this.ChooseSideLabel.Name = "ChooseSideLabel";
            this.ChooseSideLabel.Size = new System.Drawing.Size(152, 20);
            this.ChooseSideLabel.TabIndex = 1;
            this.ChooseSideLabel.Text = "Choose your side:";
            // 
            // SidesComboBox
            // 
            this.SidesComboBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SidesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SidesComboBox.DropDownWidth = 155;
            this.SidesComboBox.FormattingEnabled = true;
            this.SidesComboBox.Location = new System.Drawing.Point(180, 153);
            this.SidesComboBox.Name = "SidesComboBox";
            this.SidesComboBox.Size = new System.Drawing.Size(160, 23);
            this.SidesComboBox.TabIndex = 2;
            this.SidesComboBox.SelectedIndexChanged += new System.EventHandler(this.SidesComboBox_SelectedIndexChanged);
            // 
            // ChooseCharLabel
            // 
            this.ChooseCharLabel.AutoSize = true;
            this.ChooseCharLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCharLabel.Location = new System.Drawing.Point(403, 155);
            this.ChooseCharLabel.Name = "ChooseCharLabel";
            this.ChooseCharLabel.Size = new System.Drawing.Size(195, 20);
            this.ChooseCharLabel.TabIndex = 3;
            this.ChooseCharLabel.Text = "Choose your character:";
            // 
            // CharsComboBox
            // 
            this.CharsComboBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CharsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharsComboBox.Enabled = false;
            this.CharsComboBox.FormattingEnabled = true;
            this.CharsComboBox.Location = new System.Drawing.Point(614, 153);
            this.CharsComboBox.Name = "CharsComboBox";
            this.CharsComboBox.Size = new System.Drawing.Size(155, 23);
            this.CharsComboBox.TabIndex = 4;
            this.CharsComboBox.SelectedIndexChanged += new System.EventHandler(this.CharsComboBox_SelectedIndexChanged);
            // 
            // PortraitSideLabel
            // 
            this.PortraitSideLabel.AutoSize = true;
            this.PortraitSideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortraitSideLabel.Location = new System.Drawing.Point(12, 285);
            this.PortraitSideLabel.Name = "PortraitSideLabel";
            this.PortraitSideLabel.Size = new System.Drawing.Size(114, 20);
            this.PortraitSideLabel.TabIndex = 5;
            this.PortraitSideLabel.Text = "Portrait Side:";
            // 
            // NoPortraitChoiceBtn
            // 
            this.NoPortraitChoiceBtn.AutoSize = true;
            this.NoPortraitChoiceBtn.Enabled = false;
            this.NoPortraitChoiceBtn.Location = new System.Drawing.Point(132, 286);
            this.NoPortraitChoiceBtn.Name = "NoPortraitChoiceBtn";
            this.NoPortraitChoiceBtn.Size = new System.Drawing.Size(83, 19);
            this.NoPortraitChoiceBtn.TabIndex = 6;
            this.NoPortraitChoiceBtn.TabStop = true;
            this.NoPortraitChoiceBtn.Text = "Off-Screen";
            this.NoPortraitChoiceBtn.UseVisualStyleBackColor = true;
            // 
            // LeftChoiceBtn
            // 
            this.LeftChoiceBtn.AutoSize = true;
            this.LeftChoiceBtn.Enabled = false;
            this.LeftChoiceBtn.Location = new System.Drawing.Point(221, 286);
            this.LeftChoiceBtn.Name = "LeftChoiceBtn";
            this.LeftChoiceBtn.Size = new System.Drawing.Size(45, 19);
            this.LeftChoiceBtn.TabIndex = 7;
            this.LeftChoiceBtn.TabStop = true;
            this.LeftChoiceBtn.Text = "Left";
            this.LeftChoiceBtn.UseVisualStyleBackColor = true;
            // 
            // RightChoiceBtn
            // 
            this.RightChoiceBtn.AutoSize = true;
            this.RightChoiceBtn.Enabled = false;
            this.RightChoiceBtn.Location = new System.Drawing.Point(273, 286);
            this.RightChoiceBtn.Name = "RightChoiceBtn";
            this.RightChoiceBtn.Size = new System.Drawing.Size(54, 19);
            this.RightChoiceBtn.TabIndex = 8;
            this.RightChoiceBtn.TabStop = true;
            this.RightChoiceBtn.Text = "Right";
            this.RightChoiceBtn.UseVisualStyleBackColor = true;
            // 
            // EmotionLabel
            // 
            this.EmotionLabel.AutoSize = true;
            this.EmotionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmotionLabel.Location = new System.Drawing.Point(12, 220);
            this.EmotionLabel.Name = "EmotionLabel";
            this.EmotionLabel.Size = new System.Drawing.Size(177, 20);
            this.EmotionLabel.TabIndex = 9;
            this.EmotionLabel.Text = "Character\'s Emotion:";
            // 
            // EmotionsComboBox
            // 
            this.EmotionsComboBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmotionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmotionsComboBox.Enabled = false;
            this.EmotionsComboBox.FormattingEnabled = true;
            this.EmotionsComboBox.Location = new System.Drawing.Point(195, 218);
            this.EmotionsComboBox.Name = "EmotionsComboBox";
            this.EmotionsComboBox.Size = new System.Drawing.Size(145, 23);
            this.EmotionsComboBox.TabIndex = 10;
            this.EmotionsComboBox.SelectedIndexChanged += new System.EventHandler(this.EmotionsComboBox_SelectedIndexChanged);
            // 
            // BlushCheckbox
            // 
            this.BlushCheckbox.AutoSize = true;
            this.BlushCheckbox.Enabled = false;
            this.BlushCheckbox.Location = new System.Drawing.Point(407, 222);
            this.BlushCheckbox.Name = "BlushCheckbox";
            this.BlushCheckbox.Size = new System.Drawing.Size(57, 19);
            this.BlushCheckbox.TabIndex = 11;
            this.BlushCheckbox.Text = "Blush";
            this.BlushCheckbox.UseVisualStyleBackColor = true;
            // 
            // SweatDropCheckbox
            // 
            this.SweatDropCheckbox.AutoSize = true;
            this.SweatDropCheckbox.Enabled = false;
            this.SweatDropCheckbox.Location = new System.Drawing.Point(507, 222);
            this.SweatDropCheckbox.Name = "SweatDropCheckbox";
            this.SweatDropCheckbox.Size = new System.Drawing.Size(90, 19);
            this.SweatDropCheckbox.TabIndex = 12;
            this.SweatDropCheckbox.Text = "Sweat Drop";
            this.SweatDropCheckbox.UseVisualStyleBackColor = true;
            // 
            // EnterDialogueLabel
            // 
            this.EnterDialogueLabel.AutoSize = true;
            this.EnterDialogueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDialogueLabel.Location = new System.Drawing.Point(12, 350);
            this.EnterDialogueLabel.Name = "EnterDialogueLabel";
            this.EnterDialogueLabel.Size = new System.Drawing.Size(178, 20);
            this.EnterDialogueLabel.TabIndex = 13;
            this.EnterDialogueLabel.Text = "Enter Dialogue Here:";
            // 
            // DialogueTextBox
            // 
            this.DialogueTextBox.Enabled = false;
            this.DialogueTextBox.Location = new System.Drawing.Point(196, 350);
            this.DialogueTextBox.Multiline = true;
            this.DialogueTextBox.Name = "DialogueTextBox";
            this.DialogueTextBox.Size = new System.Drawing.Size(573, 22);
            this.DialogueTextBox.TabIndex = 14;
            // 
            // NewlineBtn
            // 
            this.NewlineBtn.Enabled = false;
            this.NewlineBtn.Location = new System.Drawing.Point(195, 385);
            this.NewlineBtn.Name = "NewlineBtn";
            this.NewlineBtn.Size = new System.Drawing.Size(100, 23);
            this.NewlineBtn.TabIndex = 15;
            this.NewlineBtn.Text = "Add New Line";
            this.NewlineBtn.UseVisualStyleBackColor = true;
            this.NewlineBtn.Click += new System.EventHandler(this.NewlineBtn_Click);
            // 
            // ScrollNextBtn
            // 
            this.ScrollNextBtn.Enabled = false;
            this.ScrollNextBtn.Location = new System.Drawing.Point(315, 385);
            this.ScrollNextBtn.Name = "ScrollNextBtn";
            this.ScrollNextBtn.Size = new System.Drawing.Size(110, 23);
            this.ScrollNextBtn.TabIndex = 16;
            this.ScrollNextBtn.Text = "Scroll Next Line";
            this.ScrollNextBtn.UseVisualStyleBackColor = true;
            this.ScrollNextBtn.Click += new System.EventHandler(this.ScrollNextBtn_Click);
            // 
            // AddAvatarBtn
            // 
            this.AddAvatarBtn.Enabled = false;
            this.AddAvatarBtn.Location = new System.Drawing.Point(445, 385);
            this.AddAvatarBtn.Name = "AddAvatarBtn";
            this.AddAvatarBtn.Size = new System.Drawing.Size(130, 23);
            this.AddAvatarBtn.TabIndex = 17;
            this.AddAvatarBtn.Text = "Add Avatar\'s Name";
            this.AddAvatarBtn.UseVisualStyleBackColor = true;
            this.AddAvatarBtn.Click += new System.EventHandler(this.AddAvatarBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Enabled = false;
            this.EndBtn.Location = new System.Drawing.Point(595, 385);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(70, 23);
            this.EndBtn.TabIndex = 18;
            this.EndBtn.Text = "End";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewLabel.Location = new System.Drawing.Point(12, 450);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(75, 20);
            this.PreviewLabel.TabIndex = 19;
            this.PreviewLabel.Text = "Preview:";
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.Enabled = false;
            this.PreviewTextBox.Location = new System.Drawing.Point(12, 480);
            this.PreviewTextBox.Multiline = true;
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.ReadOnly = true;
            this.PreviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PreviewTextBox.Size = new System.Drawing.Size(750, 120);
            this.PreviewTextBox.TabIndex = 20;
            this.PreviewTextBox.Text = "Hello!";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(685, 610);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 21;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // FatesHelperUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PreviewTextBox);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.AddAvatarBtn);
            this.Controls.Add(this.ScrollNextBtn);
            this.Controls.Add(this.NewlineBtn);
            this.Controls.Add(this.DialogueTextBox);
            this.Controls.Add(this.EnterDialogueLabel);
            this.Controls.Add(this.SweatDropCheckbox);
            this.Controls.Add(this.BlushCheckbox);
            this.Controls.Add(this.EmotionsComboBox);
            this.Controls.Add(this.EmotionLabel);
            this.Controls.Add(this.RightChoiceBtn);
            this.Controls.Add(this.LeftChoiceBtn);
            this.Controls.Add(this.NoPortraitChoiceBtn);
            this.Controls.Add(this.PortraitSideLabel);
            this.Controls.Add(this.CharsComboBox);
            this.Controls.Add(this.ChooseCharLabel);
            this.Controls.Add(this.SidesComboBox);
            this.Controls.Add(this.ChooseSideLabel);
            this.Controls.Add(this.FatesLogoPB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FatesHelperUI";
            this.Text = "Fire Emblem Fates Text Simulator Helper";
            this.Load += new System.EventHandler(this.FatesHelperUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FatesLogoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FatesLogoPB;
        private System.Windows.Forms.Label ChooseSideLabel;
        private System.Windows.Forms.ComboBox SidesComboBox;
        private System.Windows.Forms.Label ChooseCharLabel;
        private System.Windows.Forms.ComboBox CharsComboBox;
        private System.Windows.Forms.Label PortraitSideLabel;
        private System.Windows.Forms.RadioButton NoPortraitChoiceBtn;
        private System.Windows.Forms.RadioButton LeftChoiceBtn;
        private System.Windows.Forms.RadioButton RightChoiceBtn;
        private System.Windows.Forms.Label EmotionLabel;
        private System.Windows.Forms.ComboBox EmotionsComboBox;
        private System.Windows.Forms.CheckBox BlushCheckbox;
        private System.Windows.Forms.CheckBox SweatDropCheckbox;
        private System.Windows.Forms.Label EnterDialogueLabel;
        private System.Windows.Forms.TextBox DialogueTextBox;
        private System.Windows.Forms.Button NewlineBtn;
        private System.Windows.Forms.Button ScrollNextBtn;
        private System.Windows.Forms.Button AddAvatarBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.TextBox PreviewTextBox;
        private System.Windows.Forms.Button ClearBtn;
    }
}