namespace ImportController {
    partial class FormImpControl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.richTextBoxMonitor = new System.Windows.Forms.RichTextBox();
            this.listViewTransCode = new System.Windows.Forms.ListView();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(4, 84);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(75, 20);
            this.buttonCount.TabIndex = 1;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.ButtonCountClick);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(4, 42);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 20);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
            // 
            // richTextBoxMonitor
            // 
            this.richTextBoxMonitor.Location = new System.Drawing.Point(247, 137);
            this.richTextBoxMonitor.Name = "richTextBoxMonitor";
            this.richTextBoxMonitor.Size = new System.Drawing.Size(341, 184);
            this.richTextBoxMonitor.TabIndex = 3;
            this.richTextBoxMonitor.Text = "";
            // 
            // listViewTransCode
            // 
            this.listViewTransCode.FullRowSelect = true;
            this.listViewTransCode.GridLines = true;
            this.listViewTransCode.Location = new System.Drawing.Point(4, 137);
            this.listViewTransCode.Name = "listViewTransCode";
            this.listViewTransCode.Size = new System.Drawing.Size(237, 184);
            this.listViewTransCode.TabIndex = 4;
            this.listViewTransCode.TabStop = false;
            this.listViewTransCode.UseCompatibleStateImageBehavior = false;
            this.listViewTransCode.View = System.Windows.Forms.View.Details;
            this.listViewTransCode.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewTransCodeColumnClick);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessages.Location = new System.Drawing.Point(4, 327);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(584, 13);
            this.textBoxMessages.TabIndex = 5;
            this.textBoxMessages.TabStop = false;
            // 
            // FormImpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 353);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.listViewTransCode);
            this.Controls.Add(this.richTextBoxMonitor);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonCount);
            this.Name = "FormImpControl";
            this.Text = "Import Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.RichTextBox richTextBoxMonitor;
        private System.Windows.Forms.ListView listViewTransCode;
        private System.Windows.Forms.TextBox textBoxMessages;
    }
}

