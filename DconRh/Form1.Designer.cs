namespace DconRh
{
    partial class Form1
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
            this.CboxTestList = new System.Windows.Forms.ComboBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.TxtNomeFuncao = new System.Windows.Forms.TextBox();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CboxTestList
            // 
            this.CboxTestList.FormattingEnabled = true;
            this.CboxTestList.Location = new System.Drawing.Point(66, 50);
            this.CboxTestList.Name = "CboxTestList";
            this.CboxTestList.Size = new System.Drawing.Size(121, 21);
            this.CboxTestList.TabIndex = 0;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(392, 106);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(161, 23);
            this.BtnTest.TabIndex = 1;
            this.BtnTest.Text = "È Teste Meu Irmão!!";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // TxtNomeFuncao
            // 
            this.TxtNomeFuncao.Location = new System.Drawing.Point(392, 54);
            this.TxtNomeFuncao.Name = "TxtNomeFuncao";
            this.TxtNomeFuncao.Size = new System.Drawing.Size(161, 20);
            this.TxtNomeFuncao.TabIndex = 2;
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(392, 80);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(161, 20);
            this.TxtDesc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.TxtNomeFuncao);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.CboxTestList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxTestList;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.TextBox TxtNomeFuncao;
        private System.Windows.Forms.TextBox TxtDesc;
    }
}