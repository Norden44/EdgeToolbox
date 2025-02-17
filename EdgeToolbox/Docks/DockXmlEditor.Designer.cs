﻿namespace EdgeToolbox {
    partial class DockXmlEditor {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.xmlView = new DarkUI.Controls.DarkTreeView();
            this.SuspendLayout();
            // 
            // xmlView
            // 
            this.xmlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlView.Location = new System.Drawing.Point(0, 0);
            this.xmlView.MaxDragChange = 20;
            this.xmlView.Name = "xmlView";
            this.xmlView.ShowIcons = true;
            this.xmlView.Size = new System.Drawing.Size(278, 443);
            this.xmlView.TabIndex = 1;
            // 
            // DockXmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xmlView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DockXmlEditor";
            this.Size = new System.Drawing.Size(278, 443);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkTreeView xmlView;
    }
}
