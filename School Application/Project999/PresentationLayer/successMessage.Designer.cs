namespace Project999.PresentationLayer
{
    partial class SuccessMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessMessage));
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.successForm = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.successFormText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.successForm)).BeginInit();
            this.successForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(368, 6);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(25, 25);
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.StateNormal.Back.Image")));
            this.kryptonButton1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 30;
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // successForm
            // 
            this.successForm.Controls.Add(this.successFormText);
            this.successForm.Controls.Add(this.kryptonButton2);
            this.successForm.Controls.Add(this.kryptonPanel2);
            this.successForm.Location = new System.Drawing.Point(0, 0);
            this.successForm.Name = "successForm";
            this.successForm.Size = new System.Drawing.Size(405, 176);
            this.successForm.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.successForm.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.successForm.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke;
            this.successForm.StateNormal.Color2 = System.Drawing.Color.LightGray;
            this.successForm.StateNormal.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25;
            this.successForm.TabIndex = 1;
            // 
            // successFormText
            // 
            this.successFormText.Location = new System.Drawing.Point(109, 76);
            this.successFormText.Name = "successFormText";
            this.successFormText.Size = new System.Drawing.Size(221, 30);
            this.successFormText.StateNormal.ShortText.Font = new System.Drawing.Font("Quicksand", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successFormText.TabIndex = 3;
            this.successFormText.Values.Text = "Inserted Successfuly";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(322, 131);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(52, 31);
            this.kryptonButton2.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateNormal.Border.Rounding = 10;
            this.kryptonButton2.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 2;
            this.kryptonButton2.Values.Text = "OK";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(405, 38);
            this.kryptonPanel2.StateNormal.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonPanel2.StateNormal.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 1;
            // 
            // SuccessMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(404, 174);
            this.Controls.Add(this.successForm);
            this.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SuccessMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.successForm)).EndInit();
            this.successForm.ResumeLayout(false);
            this.successForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel successFormText;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel successForm;
    }
}