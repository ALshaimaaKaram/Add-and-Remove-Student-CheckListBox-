
namespace ControlerForm
{
    partial class Trainees
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
            this.lblTrainees = new System.Windows.Forms.Label();
            this.cklboxTrainees = new System.Windows.Forms.CheckedListBox();
            this.cklboxLab = new System.Windows.Forms.CheckedListBox();
            this.lblLab = new System.Windows.Forms.Label();
            this.cmboxLab = new System.Windows.Forms.ComboBox();
            this.btnTrnToLab = new System.Windows.Forms.Button();
            this.btnAllTrnToLab = new System.Windows.Forms.Button();
            this.btnLabToTrn = new System.Windows.Forms.Button();
            this.btnAllLabToTrn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrainees
            // 
            this.lblTrainees.AutoSize = true;
            this.lblTrainees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrainees.Location = new System.Drawing.Point(54, 54);
            this.lblTrainees.Name = "lblTrainees";
            this.lblTrainees.Size = new System.Drawing.Size(90, 28);
            this.lblTrainees.TabIndex = 1;
            this.lblTrainees.Text = "Trainees";
            // 
            // cklboxTrainees
            // 
            this.cklboxTrainees.FormattingEnabled = true;
            this.cklboxTrainees.Location = new System.Drawing.Point(54, 103);
            this.cklboxTrainees.Name = "cklboxTrainees";
            this.cklboxTrainees.Size = new System.Drawing.Size(263, 274);
            this.cklboxTrainees.TabIndex = 0;
            this.cklboxTrainees.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklboxTrainees_ItemCheck);
            // 
            // cklboxLab
            // 
            this.cklboxLab.FormattingEnabled = true;
            this.cklboxLab.Location = new System.Drawing.Point(480, 103);
            this.cklboxLab.Name = "cklboxLab";
            this.cklboxLab.Size = new System.Drawing.Size(251, 274);
            this.cklboxLab.TabIndex = 0;
            this.cklboxLab.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklboxLab_ItemCheck);
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLab.Location = new System.Drawing.Point(480, 54);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(50, 28);
            this.lblLab.TabIndex = 1;
            this.lblLab.Text = "Lab:";
            // 
            // cmboxLab
            // 
            this.cmboxLab.FormattingEnabled = true;
            this.cmboxLab.Location = new System.Drawing.Point(536, 58);
            this.cmboxLab.Name = "cmboxLab";
            this.cmboxLab.Size = new System.Drawing.Size(195, 23);
            this.cmboxLab.TabIndex = 2;
            this.cmboxLab.SelectedIndexChanged += new System.EventHandler(this.cmboxLab_SelectedIndexChanged);
            // 
            // btnTrnToLab
            // 
            this.btnTrnToLab.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrnToLab.Location = new System.Drawing.Point(362, 132);
            this.btnTrnToLab.Name = "btnTrnToLab";
            this.btnTrnToLab.Size = new System.Drawing.Size(75, 33);
            this.btnTrnToLab.TabIndex = 3;
            this.btnTrnToLab.Text = ">";
            this.btnTrnToLab.UseVisualStyleBackColor = true;
            this.btnTrnToLab.Click += new System.EventHandler(this.btnTrnToLab_Click);
            // 
            // btnAllTrnToLab
            // 
            this.btnAllTrnToLab.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllTrnToLab.Location = new System.Drawing.Point(362, 191);
            this.btnAllTrnToLab.Name = "btnAllTrnToLab";
            this.btnAllTrnToLab.Size = new System.Drawing.Size(75, 33);
            this.btnAllTrnToLab.TabIndex = 3;
            this.btnAllTrnToLab.Text = ">>";
            this.btnAllTrnToLab.UseVisualStyleBackColor = true;
            this.btnAllTrnToLab.Click += new System.EventHandler(this.btnAllTrnToLab_Click);
            // 
            // btnLabToTrn
            // 
            this.btnLabToTrn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLabToTrn.Location = new System.Drawing.Point(362, 252);
            this.btnLabToTrn.Name = "btnLabToTrn";
            this.btnLabToTrn.Size = new System.Drawing.Size(75, 33);
            this.btnLabToTrn.TabIndex = 3;
            this.btnLabToTrn.Text = "<";
            this.btnLabToTrn.UseVisualStyleBackColor = true;
            this.btnLabToTrn.Click += new System.EventHandler(this.btnLabToTrn_Click);
            // 
            // btnAllLabToTrn
            // 
            this.btnAllLabToTrn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllLabToTrn.Location = new System.Drawing.Point(362, 307);
            this.btnAllLabToTrn.Name = "btnAllLabToTrn";
            this.btnAllLabToTrn.Size = new System.Drawing.Size(75, 33);
            this.btnAllLabToTrn.TabIndex = 3;
            this.btnAllLabToTrn.Text = "<<";
            this.btnAllLabToTrn.UseVisualStyleBackColor = true;
            this.btnAllLabToTrn.Click += new System.EventHandler(this.btnAllLabToTrn_Click);
            // 
            // Trainees
            // 
            this.ClientSize = new System.Drawing.Size(795, 419);
            this.Controls.Add(this.btnAllLabToTrn);
            this.Controls.Add(this.btnLabToTrn);
            this.Controls.Add(this.btnAllTrnToLab);
            this.Controls.Add(this.btnTrnToLab);
            this.Controls.Add(this.cmboxLab);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblTrainees);
            this.Controls.Add(this.cklboxLab);
            this.Controls.Add(this.cklboxTrainees);
            this.Name = "Trainees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklboxTrainees;
        private System.Windows.Forms.CheckedListBox cklboxLab;
        private System.Windows.Forms.Label lblTrainees;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.ComboBox cmboxLab;
        private System.Windows.Forms.Button btnTrnToLab;
        private System.Windows.Forms.Button btnAllTrnToLab;
        private System.Windows.Forms.Button btnLabToTrn;
        private System.Windows.Forms.Button btnAllLabToTrn;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.CheckedListBox checkedListBox1;
        //private System.Windows.Forms.CheckedListBox checkedListBox2;
        //private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.Button button4;
    }
}

