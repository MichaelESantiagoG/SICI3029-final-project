
namespace EmptyGUI
{
    partial class Form3_Product_Or_Client_List
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClient_List = new System.Windows.Forms.Button();
            this.btnProduct_List = new System.Windows.Forms.Button();
            this.btnLog_Out = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLog_Out);
            this.groupBox1.Controls.Add(this.btnClient_List);
            this.groupBox1.Controls.Add(this.btnProduct_List);
            this.groupBox1.Location = new System.Drawing.Point(78, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of spreadsheet";
            // 
            // btnClient_List
            // 
            this.btnClient_List.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClient_List.Location = new System.Drawing.Point(51, 143);
            this.btnClient_List.Name = "btnClient_List";
            this.btnClient_List.Size = new System.Drawing.Size(152, 45);
            this.btnClient_List.TabIndex = 1;
            this.btnClient_List.Text = "Client list";
            this.btnClient_List.UseVisualStyleBackColor = false;
            this.btnClient_List.Click += new System.EventHandler(this.btnClient_List_Click);
            // 
            // btnProduct_List
            // 
            this.btnProduct_List.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProduct_List.Location = new System.Drawing.Point(51, 69);
            this.btnProduct_List.Name = "btnProduct_List";
            this.btnProduct_List.Size = new System.Drawing.Size(152, 45);
            this.btnProduct_List.TabIndex = 0;
            this.btnProduct_List.Text = "Product list";
            this.btnProduct_List.UseVisualStyleBackColor = false;
            this.btnProduct_List.Click += new System.EventHandler(this.btnProduct_List_Click);
            // 
            // btnLog_Out
            // 
            this.btnLog_Out.Location = new System.Drawing.Point(6, 230);
            this.btnLog_Out.Name = "btnLog_Out";
            this.btnLog_Out.Size = new System.Drawing.Size(60, 30);
            this.btnLog_Out.TabIndex = 1;
            this.btnLog_Out.Text = "Log out";
            this.btnLog_Out.UseVisualStyleBackColor = true;
            this.btnLog_Out.Click += new System.EventHandler(this.btnLog_Out_Click);
            // 
            // Form3_Product_Or_Client_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmptyGUI.Properties.Resources.image__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 408);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3_Product_Or_Client_List";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClient_List;
        private System.Windows.Forms.Button btnProduct_List;
        private System.Windows.Forms.Button btnLog_Out;
    }
}