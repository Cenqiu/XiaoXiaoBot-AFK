namespace xiaoxiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            transTextBox1 = new BaseTextBox.TransTextBox();
            transTextBox2 = new BaseTextBox.TransTextBox();
            transTextBox3 = new BaseTextBox.TransTextBox();
            SuspendLayout();
            // 
            // transTextBox1
            // 
            transTextBox1.BorderStyle = BorderStyle.None;
            resources.ApplyResources(transTextBox1, "transTextBox1");
            transTextBox1.ForeColor = SystemColors.MenuText;
            transTextBox1.Name = "transTextBox1";
            transTextBox1.TextChanged += transTextBox1_TextChanged_1;
            // 
            // transTextBox2
            // 
            transTextBox2.BorderStyle = BorderStyle.None;
            resources.ApplyResources(transTextBox2, "transTextBox2");
            transTextBox2.Name = "transTextBox2";
            transTextBox2.TextChanged += transTextBox2_TextChanged;
            // 
            // transTextBox3
            // 
            transTextBox3.BorderStyle = BorderStyle.None;
            resources.ApplyResources(transTextBox3, "transTextBox3");
            transTextBox3.Name = "transTextBox3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources._65999f81202c3e8d_1551969793_BIG;
            Controls.Add(transTextBox3);
            Controls.Add(transTextBox2);
            Controls.Add(transTextBox1);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        protected internal BaseTextBox.TransTextBox transTextBox1;
        private BaseTextBox.TransTextBox transTextBox2;
        private BaseTextBox.TransTextBox transTextBox3;
    }
}
