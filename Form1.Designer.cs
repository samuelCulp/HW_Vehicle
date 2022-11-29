namespace WindowsFormsApp2
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
            this.make_model = new System.Windows.Forms.ComboBox();
            this.list = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // make_model
            // 
            this.make_model.FormattingEnabled = true;
            this.make_model.Location = new System.Drawing.Point(130, 67);
            this.make_model.Name = "make_model";
            this.make_model.Size = new System.Drawing.Size(147, 21);
            this.make_model.TabIndex = 0;
            this.make_model.Text = "Make & Model";
            this.make_model.SelectedIndexChanged += new System.EventHandler(this.make_model_SelectedIndexChanged);
            // 
            // list
            // 
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(98, 143);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(496, 213);
            this.list.TabIndex = 1;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // type_box
            // 
            this.type_box.FormattingEnabled = true;
            this.type_box.Location = new System.Drawing.Point(344, 67);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(150, 21);
            this.type_box.TabIndex = 3;
            this.type_box.Text = "Body Type";
            this.type_box.SelectedIndexChanged += new System.EventHandler(this.type_box_SelectedIndexChanged);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(385, 363);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(664, 130);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(50, 13);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "infoLabel";
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.make_model);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox make_model;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label infoLabel;
    }
}

