namespace Zork.Builder.Forms
{
    partial class AddRoomForm
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
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddDescription = new System.Windows.Forms.TextBox();
            this.labelNameAdd = new System.Windows.Forms.Label();
            this.labelDescriptionAdd = new System.Windows.Forms.Label();
            this.cancelRoomButton = new System.Windows.Forms.Button();
            this.okRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(12, 19);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(274, 20);
            this.textBoxAddName.TabIndex = 1;
            this.textBoxAddName.TextChanged += new System.EventHandler(this.textBoxAddName_TextChanged);
            // 
            // textBoxAddDescription
            // 
            this.textBoxAddDescription.Location = new System.Drawing.Point(12, 58);
            this.textBoxAddDescription.Multiline = true;
            this.textBoxAddDescription.Name = "textBoxAddDescription";
            this.textBoxAddDescription.Size = new System.Drawing.Size(274, 59);
            this.textBoxAddDescription.TabIndex = 3;
            // 
            // labelNameAdd
            // 
            this.labelNameAdd.AutoSize = true;
            this.labelNameAdd.Location = new System.Drawing.Point(9, 3);
            this.labelNameAdd.Name = "labelNameAdd";
            this.labelNameAdd.Size = new System.Drawing.Size(35, 13);
            this.labelNameAdd.TabIndex = 0;
            this.labelNameAdd.Text = "Name";
            // 
            // labelDescriptionAdd
            // 
            this.labelDescriptionAdd.AutoSize = true;
            this.labelDescriptionAdd.Location = new System.Drawing.Point(9, 41);
            this.labelDescriptionAdd.Name = "labelDescriptionAdd";
            this.labelDescriptionAdd.Size = new System.Drawing.Size(60, 13);
            this.labelDescriptionAdd.TabIndex = 2;
            this.labelDescriptionAdd.Text = "Description";
            // 
            // cancelRoomButton
            // 
            this.cancelRoomButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelRoomButton.Location = new System.Drawing.Point(229, 123);
            this.cancelRoomButton.Name = "cancelRoomButton";
            this.cancelRoomButton.Size = new System.Drawing.Size(57, 26);
            this.cancelRoomButton.TabIndex = 5;
            this.cancelRoomButton.Text = "&Cancel";
            this.cancelRoomButton.UseVisualStyleBackColor = true;
            // 
            // okRoomButton
            // 
            this.okRoomButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okRoomButton.Enabled = false;
            this.okRoomButton.Location = new System.Drawing.Point(166, 123);
            this.okRoomButton.Name = "okRoomButton";
            this.okRoomButton.Size = new System.Drawing.Size(57, 26);
            this.okRoomButton.TabIndex = 4;
            this.okRoomButton.Text = "&Ok";
            this.okRoomButton.UseVisualStyleBackColor = true;
            // 
            // AddRoomForm
            // 
            this.AcceptButton = this.okRoomButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelRoomButton;
            this.ClientSize = new System.Drawing.Size(297, 158);
            this.Controls.Add(this.cancelRoomButton);
            this.Controls.Add(this.okRoomButton);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.textBoxAddDescription);
            this.Controls.Add(this.labelNameAdd);
            this.Controls.Add(this.labelDescriptionAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxAddDescription;
        private System.Windows.Forms.Label labelNameAdd;
        private System.Windows.Forms.Label labelDescriptionAdd;
        private System.Windows.Forms.Button cancelRoomButton;
        private System.Windows.Forms.Button okRoomButton;
    }
}