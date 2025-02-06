namespace deep
{
    partial class deepForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deepForm));
            this.deepBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.deepBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // deepBrowser
            // 
            this.deepBrowser.AllowExternalDrop = true;
            this.deepBrowser.CreationProperties = null;
            this.deepBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.deepBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deepBrowser.Location = new System.Drawing.Point(0, 0);
            this.deepBrowser.Name = "deepBrowser";
            this.deepBrowser.Size = new System.Drawing.Size(800, 450);
            this.deepBrowser.TabIndex = 0;
            this.deepBrowser.ZoomFactor = 1D;
            // 
            // deepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deepBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deepForm";
            this.Text = "deep";
            ((System.ComponentModel.ISupportInitialize)(this.deepBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 deepBrowser;
    }
}

