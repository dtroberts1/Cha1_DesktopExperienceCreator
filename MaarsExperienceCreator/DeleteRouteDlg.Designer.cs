﻿namespace MaarsExperienceCreator
{
    partial class DeleteRouteDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRouteDlg));
            this.label1 = new System.Windows.Forms.Label();
            this.saveNewRouteOkBtn = new System.Windows.Forms.Button();
            this.saveNewRouteCancelBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Route For Deletion";
            // 
            // saveNewRouteOkBtn
            // 
            this.saveNewRouteOkBtn.Location = new System.Drawing.Point(226, 82);
            this.saveNewRouteOkBtn.Name = "saveNewRouteOkBtn";
            this.saveNewRouteOkBtn.Size = new System.Drawing.Size(75, 23);
            this.saveNewRouteOkBtn.TabIndex = 2;
            this.saveNewRouteOkBtn.Text = "Ok";
            this.saveNewRouteOkBtn.UseVisualStyleBackColor = true;
            this.saveNewRouteOkBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveNewRouteOkBtn_MouseUp);
            // 
            // saveNewRouteCancelBtn
            // 
            this.saveNewRouteCancelBtn.Location = new System.Drawing.Point(307, 82);
            this.saveNewRouteCancelBtn.Name = "saveNewRouteCancelBtn";
            this.saveNewRouteCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.saveNewRouteCancelBtn.TabIndex = 3;
            this.saveNewRouteCancelBtn.Text = "Cancel";
            this.saveNewRouteCancelBtn.UseVisualStyleBackColor = true;
            this.saveNewRouteCancelBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveNewRouteCancelBtn_MouseUp);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // DeleteRouteDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 114);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.saveNewRouteCancelBtn);
            this.Controls.Add(this.saveNewRouteOkBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteRouteDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Route";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveNewRouteOkBtn;
        private System.Windows.Forms.Button saveNewRouteCancelBtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}