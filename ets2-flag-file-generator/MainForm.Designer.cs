namespace Ets2FlagFileGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StepOneLabel = new System.Windows.Forms.Label();
            this.StepOneSubtext = new System.Windows.Forms.Label();
            this.TruckIdBox = new System.Windows.Forms.ListBox();
            this.TruckIdAdd = new System.Windows.Forms.Button();
            this.TruckIdRemove = new System.Windows.Forms.Button();
            this.StepTwoLabel = new System.Windows.Forms.Label();
            this.StepTwoSubtext = new System.Windows.Forms.Label();
            this.FlagsDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.StepThreeText = new System.Windows.Forms.Label();
            this.StepThreeSubtext = new System.Windows.Forms.Label();
            this.ChosenFolderTextbox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FlagId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextureNameRightSide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UiTextureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FlagsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StepOneLabel
            // 
            this.StepOneLabel.AutoSize = true;
            this.StepOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepOneLabel.Location = new System.Drawing.Point(12, 9);
            this.StepOneLabel.Name = "StepOneLabel";
            this.StepOneLabel.Size = new System.Drawing.Size(257, 25);
            this.StepOneLabel.TabIndex = 0;
            this.StepOneLabel.Text = "Step 1: Enter Truck IDs";
            // 
            // StepOneSubtext
            // 
            this.StepOneSubtext.AutoSize = true;
            this.StepOneSubtext.Location = new System.Drawing.Point(17, 38);
            this.StepOneSubtext.Name = "StepOneSubtext";
            this.StepOneSubtext.Size = new System.Drawing.Size(327, 13);
            this.StepOneSubtext.TabIndex = 1;
            this.StepOneSubtext.Text = "Only include mod trucks; official trucks will be automatically included";
            // 
            // TruckIdBox
            // 
            this.TruckIdBox.FormattingEnabled = true;
            this.TruckIdBox.Location = new System.Drawing.Point(17, 64);
            this.TruckIdBox.Name = "TruckIdBox";
            this.TruckIdBox.Size = new System.Drawing.Size(452, 95);
            this.TruckIdBox.TabIndex = 2;
            // 
            // TruckIdAdd
            // 
            this.TruckIdAdd.Location = new System.Drawing.Point(475, 64);
            this.TruckIdAdd.Name = "TruckIdAdd";
            this.TruckIdAdd.Size = new System.Drawing.Size(110, 45);
            this.TruckIdAdd.TabIndex = 3;
            this.TruckIdAdd.Text = "Add";
            this.TruckIdAdd.UseVisualStyleBackColor = true;
            this.TruckIdAdd.Click += new System.EventHandler(this.TruckIdAdd_Click);
            // 
            // TruckIdRemove
            // 
            this.TruckIdRemove.Location = new System.Drawing.Point(475, 114);
            this.TruckIdRemove.Name = "TruckIdRemove";
            this.TruckIdRemove.Size = new System.Drawing.Size(110, 45);
            this.TruckIdRemove.TabIndex = 4;
            this.TruckIdRemove.Text = "Remove";
            this.TruckIdRemove.UseVisualStyleBackColor = true;
            this.TruckIdRemove.Click += new System.EventHandler(this.TruckIdRemove_Click);
            // 
            // StepTwoLabel
            // 
            this.StepTwoLabel.AutoSize = true;
            this.StepTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepTwoLabel.Location = new System.Drawing.Point(12, 175);
            this.StepTwoLabel.Name = "StepTwoLabel";
            this.StepTwoLabel.Size = new System.Drawing.Size(516, 25);
            this.StepTwoLabel.TabIndex = 5;
            this.StepTwoLabel.Text = "Step 2: Enter Texture Names and Flag Direction";
            // 
            // StepTwoSubtext
            // 
            this.StepTwoSubtext.AutoSize = true;
            this.StepTwoSubtext.Location = new System.Drawing.Point(17, 200);
            this.StepTwoSubtext.Name = "StepTwoSubtext";
            this.StepTwoSubtext.Size = new System.Drawing.Size(712, 52);
            this.StepTwoSubtext.TabIndex = 6;
            this.StepTwoSubtext.Text = resources.GetString("StepTwoSubtext.Text");
            // 
            // FlagsDataGrid
            // 
            this.FlagsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlagsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlagId,
            this.DisplayName,
            this.TextureName,
            this.TextureNameRightSide,
            this.UiTextureName});
            this.FlagsDataGrid.Location = new System.Drawing.Point(17, 265);
            this.FlagsDataGrid.Name = "FlagsDataGrid";
            this.FlagsDataGrid.Size = new System.Drawing.Size(703, 150);
            this.FlagsDataGrid.TabIndex = 7;
            this.FlagsDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StepThreeText
            // 
            this.StepThreeText.AutoSize = true;
            this.StepThreeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepThreeText.Location = new System.Drawing.Point(15, 427);
            this.StepThreeText.Name = "StepThreeText";
            this.StepThreeText.Size = new System.Drawing.Size(308, 25);
            this.StepThreeText.TabIndex = 9;
            this.StepThreeText.Text = "Step 3: Set Output Directory";
            // 
            // StepThreeSubtext
            // 
            this.StepThreeSubtext.AutoSize = true;
            this.StepThreeSubtext.Location = new System.Drawing.Point(17, 452);
            this.StepThreeSubtext.Name = "StepThreeSubtext";
            this.StepThreeSubtext.Size = new System.Drawing.Size(244, 13);
            this.StepThreeSubtext.TabIndex = 10;
            this.StepThreeSubtext.Text = "Decide where the generated files should be stored";
            // 
            // ChosenFolderTextbox
            // 
            this.ChosenFolderTextbox.Location = new System.Drawing.Point(20, 469);
            this.ChosenFolderTextbox.Name = "ChosenFolderTextbox";
            this.ChosenFolderTextbox.ReadOnly = true;
            this.ChosenFolderTextbox.Size = new System.Drawing.Size(475, 20);
            this.ChosenFolderTextbox.TabIndex = 11;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(502, 469);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(83, 20);
            this.BrowseButton.TabIndex = 12;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FlagId
            // 
            this.FlagId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FlagId.HeaderText = "Flag ID";
            this.FlagId.Name = "FlagId";
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DisplayName.HeaderText = "Display Name";
            this.DisplayName.Name = "DisplayName";
            // 
            // TextureName
            // 
            this.TextureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TextureName.HeaderText = "Texture Filename (L)";
            this.TextureName.Name = "TextureName";
            // 
            // TextureNameRightSide
            // 
            this.TextureNameRightSide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TextureNameRightSide.HeaderText = "Texture Filename (R)";
            this.TextureNameRightSide.Name = "TextureNameRightSide";
            // 
            // UiTextureName
            // 
            this.UiTextureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UiTextureName.HeaderText = "UI Texture Filename";
            this.UiTextureName.Name = "UiTextureName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 612);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ChosenFolderTextbox);
            this.Controls.Add(this.StepThreeSubtext);
            this.Controls.Add(this.StepThreeText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FlagsDataGrid);
            this.Controls.Add(this.StepTwoSubtext);
            this.Controls.Add(this.StepTwoLabel);
            this.Controls.Add(this.TruckIdRemove);
            this.Controls.Add(this.TruckIdAdd);
            this.Controls.Add(this.TruckIdBox);
            this.Controls.Add(this.StepOneSubtext);
            this.Controls.Add(this.StepOneLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlagsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StepOneLabel;
        private System.Windows.Forms.Label StepOneSubtext;
        private System.Windows.Forms.ListBox TruckIdBox;
        private System.Windows.Forms.Button TruckIdAdd;
        private System.Windows.Forms.Button TruckIdRemove;
        private System.Windows.Forms.Label StepTwoLabel;
        private System.Windows.Forms.Label StepTwoSubtext;
        private System.Windows.Forms.DataGridView FlagsDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label StepThreeText;
        private System.Windows.Forms.Label StepThreeSubtext;
        private System.Windows.Forms.TextBox ChosenFolderTextbox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlagId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextureNameRightSide;
        private System.Windows.Forms.DataGridViewTextBoxColumn UiTextureName;
    }
}