namespace MiConAccGetter
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            PortNamesBox = new ComboBox();
            ConnectStart = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PortNamesBox
            // 
            PortNamesBox.FormattingEnabled = true;
            PortNamesBox.Location = new Point(93, 12);
            PortNamesBox.Name = "PortNamesBox";
            PortNamesBox.Size = new Size(121, 23);
            PortNamesBox.TabIndex = 1;
            // 
            // ConnectStart
            // 
            ConnectStart.Location = new Point(181, 57);
            ConnectStart.Name = "ConnectStart";
            ConnectStart.Size = new Size(75, 23);
            ConnectStart.TabIndex = 2;
            ConnectStart.Text = "button1";
            ConnectStart.UseVisualStyleBackColor = true;
            ConnectStart.Click += ConnectStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 288);
            Controls.Add(ConnectStart);
            Controls.Add(PortNamesBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ComboBox PortNamesBox;
        private Button ConnectStart;
    }
}
