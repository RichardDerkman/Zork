namespace Zork.Builder
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
            this.components = new System.ComponentModel.Container();
            this.tabControlMainForm = new System.Windows.Forms.TabControl();
            this.Worldtab = new System.Windows.Forms.TabPage();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startingLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eastNeighborControl = new Zork.Builder.NeighborControl();
            this.southNeighborControl = new Zork.Builder.NeighborControl();
            this.westNeighborControl = new Zork.Builder.NeighborControl();
            this.northNeighborControl = new Zork.Builder.NeighborControl();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonWest = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.labelroom = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.startingLocationLabel = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelNametab1 = new System.Windows.Forms.Label();
            this.labelDescriptiontab1 = new System.Windows.Forms.Label();
            this.Gametab = new System.Windows.Forms.TabPage();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.exitMessageLabel = new System.Windows.Forms.Label();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMainForm.SuspendLayout();
            this.Worldtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingLocationBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.Gametab.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainForm
            // 
            this.tabControlMainForm.Controls.Add(this.Worldtab);
            this.tabControlMainForm.Controls.Add(this.Gametab);
            this.tabControlMainForm.Location = new System.Drawing.Point(0, 27);
            this.tabControlMainForm.Name = "tabControlMainForm";
            this.tabControlMainForm.SelectedIndex = 0;
            this.tabControlMainForm.Size = new System.Drawing.Size(650, 493);
            this.tabControlMainForm.TabIndex = 14;
            // 
            // Worldtab
            // 
            this.Worldtab.Controls.Add(this.startingLocationComboBox);
            this.Worldtab.Controls.Add(this.groupBox1);
            this.Worldtab.Controls.Add(this.roomsListBox);
            this.Worldtab.Controls.Add(this.deleteRoomButton);
            this.Worldtab.Controls.Add(this.addRoomButton);
            this.Worldtab.Controls.Add(this.labelroom);
            this.Worldtab.Controls.Add(this.textBoxName);
            this.Worldtab.Controls.Add(this.startingLocationLabel);
            this.Worldtab.Controls.Add(this.textBoxDescription);
            this.Worldtab.Controls.Add(this.labelNametab1);
            this.Worldtab.Controls.Add(this.labelDescriptiontab1);
            this.Worldtab.Location = new System.Drawing.Point(4, 22);
            this.Worldtab.Name = "Worldtab";
            this.Worldtab.Padding = new System.Windows.Forms.Padding(3);
            this.Worldtab.Size = new System.Drawing.Size(642, 467);
            this.Worldtab.TabIndex = 0;
            this.Worldtab.Text = "World";
            this.Worldtab.UseVisualStyleBackColor = true;
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.BackColor = System.Drawing.Color.Wheat;
            this.startingLocationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.startingLocationBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startingLocationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startingLocationComboBox.DataSource = this.startingLocationBindingSource;
            this.startingLocationComboBox.DisplayMember = "Name";
            this.startingLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(9, 30);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(163, 21);
            this.startingLocationComboBox.TabIndex = 27;
            this.startingLocationComboBox.ValueMember = "Name";
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // startingLocationBindingSource
            // 
            this.startingLocationBindingSource.AllowNew = true;
            this.startingLocationBindingSource.DataMember = "Rooms";
            this.startingLocationBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eastNeighborControl);
            this.groupBox1.Controls.Add(this.southNeighborControl);
            this.groupBox1.Controls.Add(this.westNeighborControl);
            this.groupBox1.Controls.Add(this.northNeighborControl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonWest);
            this.groupBox1.Location = new System.Drawing.Point(181, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 248);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neighbors";
            // 
            // eastNeighborControl
            // 
            this.eastNeighborControl.Direction = Zork.Directions.East;
            this.eastNeighborControl.Location = new System.Drawing.Point(262, 100);
            this.eastNeighborControl.Name = "eastNeighborControl";
            this.eastNeighborControl.Room = null;
            this.eastNeighborControl.Size = new System.Drawing.Size(132, 53);
            this.eastNeighborControl.TabIndex = 12;
            // 
            // southNeighborControl
            // 
            this.southNeighborControl.Direction = Zork.Directions.South;
            this.southNeighborControl.Location = new System.Drawing.Point(128, 179);
            this.southNeighborControl.Name = "southNeighborControl";
            this.southNeighborControl.Room = null;
            this.southNeighborControl.Size = new System.Drawing.Size(132, 53);
            this.southNeighborControl.TabIndex = 11;
            // 
            // westNeighborControl
            // 
            this.westNeighborControl.Direction = Zork.Directions.West;
            this.westNeighborControl.Location = new System.Drawing.Point(6, 100);
            this.westNeighborControl.Name = "westNeighborControl";
            this.westNeighborControl.Room = null;
            this.westNeighborControl.Size = new System.Drawing.Size(132, 53);
            this.westNeighborControl.TabIndex = 10;
            // 
            // northNeighborControl
            // 
            this.northNeighborControl.Direction = Zork.Directions.North;
            this.northNeighborControl.Location = new System.Drawing.Point(128, 19);
            this.northNeighborControl.Name = "northNeighborControl";
            this.northNeighborControl.Room = null;
            this.northNeighborControl.Size = new System.Drawing.Size(132, 53);
            this.northNeighborControl.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-72, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "<None>";
            // 
            // buttonWest
            // 
            this.buttonWest.Location = new System.Drawing.Point(-78, 101);
            this.buttonWest.Name = "buttonWest";
            this.buttonWest.Size = new System.Drawing.Size(57, 56);
            this.buttonWest.TabIndex = 3;
            this.buttonWest.Text = "West";
            this.buttonWest.UseVisualStyleBackColor = true;
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(9, 69);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(163, 329);
            this.roomsListBox.TabIndex = 25;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(115, 411);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(57, 26);
            this.deleteRoomButton.TabIndex = 24;
            this.deleteRoomButton.Text = "&Delete...";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(52, 411);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(57, 26);
            this.addRoomButton.TabIndex = 23;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // labelroom
            // 
            this.labelroom.AutoSize = true;
            this.labelroom.Location = new System.Drawing.Point(8, 53);
            this.labelroom.Name = "labelroom";
            this.labelroom.Size = new System.Drawing.Size(40, 13);
            this.labelroom.TabIndex = 19;
            this.labelroom.Text = "Rooms";
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxName.Location = new System.Drawing.Point(181, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(274, 20);
            this.textBoxName.TabIndex = 18;
            // 
            // startingLocationLabel
            // 
            this.startingLocationLabel.AutoSize = true;
            this.startingLocationLabel.Location = new System.Drawing.Point(8, 14);
            this.startingLocationLabel.Name = "startingLocationLabel";
            this.startingLocationLabel.Size = new System.Drawing.Size(87, 13);
            this.startingLocationLabel.TabIndex = 20;
            this.startingLocationLabel.Text = "Starting Location";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDescription.Location = new System.Drawing.Point(181, 102);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(274, 59);
            this.textBoxDescription.TabIndex = 17;
            // 
            // labelNametab1
            // 
            this.labelNametab1.AutoSize = true;
            this.labelNametab1.Location = new System.Drawing.Point(178, 14);
            this.labelNametab1.Name = "labelNametab1";
            this.labelNametab1.Size = new System.Drawing.Size(35, 13);
            this.labelNametab1.TabIndex = 16;
            this.labelNametab1.Text = "Name";
            // 
            // labelDescriptiontab1
            // 
            this.labelDescriptiontab1.AutoSize = true;
            this.labelDescriptiontab1.Location = new System.Drawing.Point(178, 85);
            this.labelDescriptiontab1.Name = "labelDescriptiontab1";
            this.labelDescriptiontab1.Size = new System.Drawing.Size(60, 13);
            this.labelDescriptiontab1.TabIndex = 15;
            this.labelDescriptiontab1.Text = "Description";
            // 
            // Gametab
            // 
            this.Gametab.Controls.Add(this.exitMessageTextBox);
            this.Gametab.Controls.Add(this.exitMessageLabel);
            this.Gametab.Controls.Add(this.welcomeMessageTextBox);
            this.Gametab.Controls.Add(this.filenameTextBox);
            this.Gametab.Controls.Add(this.labelWelcome);
            this.Gametab.Controls.Add(this.filenameLabel);
            this.Gametab.Location = new System.Drawing.Point(4, 22);
            this.Gametab.Name = "Gametab";
            this.Gametab.Padding = new System.Windows.Forms.Padding(3);
            this.Gametab.Size = new System.Drawing.Size(642, 467);
            this.Gametab.TabIndex = 1;
            this.Gametab.Text = "Game";
            this.Gametab.UseVisualStyleBackColor = true;
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "ExitMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exitMessageTextBox.Location = new System.Drawing.Point(6, 181);
            this.exitMessageTextBox.Multiline = true;
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(361, 66);
            this.exitMessageTextBox.TabIndex = 6;
            // 
            // exitMessageLabel
            // 
            this.exitMessageLabel.AutoSize = true;
            this.exitMessageLabel.Location = new System.Drawing.Point(8, 165);
            this.exitMessageLabel.Name = "exitMessageLabel";
            this.exitMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.exitMessageLabel.TabIndex = 5;
            this.exitMessageLabel.Text = "Exit Message";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(4, 79);
            this.welcomeMessageTextBox.Multiline = true;
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(361, 66);
            this.welcomeMessageTextBox.TabIndex = 4;
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FullPath", true));
            this.filenameTextBox.Location = new System.Drawing.Point(4, 28);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(361, 20);
            this.filenameTextBox.TabIndex = 3;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(6, 63);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(98, 13);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome Message";
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(6, 12);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(49, 13);
            this.filenameLabel.TabIndex = 0;
            this.filenameLabel.Text = "Filename";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(650, 24);
            this.mainMenuStrip.TabIndex = 15;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveWorldToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.newGameToolStripMenuItem.Text = "New Game...";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openWorldToolStripMenuItem.Text = "Open Game...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // saveWorldToolStripMenuItem
            // 
            this.saveWorldToolStripMenuItem.Name = "saveWorldToolStripMenuItem";
            this.saveWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveWorldToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveWorldToolStripMenuItem.Text = "Save Game";
            this.saveWorldToolStripMenuItem.Click += new System.EventHandler(this.SaveWorldToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON Files (*.json)|*.json";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files (*.json)|*.json";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 519);
            this.Controls.Add(this.tabControlMainForm);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork Builder";
            this.tabControlMainForm.ResumeLayout(false);
            this.Worldtab.ResumeLayout(false);
            this.Worldtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingLocationBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.Gametab.ResumeLayout(false);
            this.Gametab.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMainForm;
        private System.Windows.Forms.TabPage Worldtab;
        private System.Windows.Forms.TabPage Gametab;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Label labelroom;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonWest;
        private System.Windows.Forms.Label startingLocationLabel;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelNametab1;
        private System.Windows.Forms.Label labelDescriptiontab1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.TextBox exitMessageTextBox;
        private System.Windows.Forms.Label exitMessageLabel;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.BindingSource startingLocationBindingSource;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private NeighborControl northNeighborControl;
        private NeighborControl eastNeighborControl;
        private NeighborControl southNeighborControl;
        private NeighborControl westNeighborControl;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
    }
}

