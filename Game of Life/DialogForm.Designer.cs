
namespace Game_of_Life
{
    partial class DialogForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.labelW = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(97, 203);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(68, 30);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(219, 203);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(68, 30);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(74, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(251, 29);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Change Universe Size";
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(69, 129);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(109, 20);
            this.textBoxW.TabIndex = 3;
            this.textBoxW.TextChanged += new System.EventHandler(this.textBoxW_TextChanged);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(216, 129);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(109, 20);
            this.textBoxL.TabIndex = 4;
            this.textBoxL.TextChanged += new System.EventHandler(this.textBoxL_TextChanged);
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW.Location = new System.Drawing.Point(65, 93);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(113, 24);
            this.labelW.TabIndex = 5;
            this.labelW.Text = "Enter Width:";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(215, 93);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(123, 24);
            this.labelL.TabIndex = 6;
            this.labelL.Text = "Enter Length:";
            // 
            // DialogForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universe Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelL;
    }
}