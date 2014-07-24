namespace fPlayer_2
{
    partial class libraryEditor
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libraryEditor));
            this.foldersinlibraryheader = new System.Windows.Forms.Label();
            this.folderBox = new System.Windows.Forms.ListBox();
            this.okbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // foldersinlibraryheader
            // 
            resources.ApplyResources(this.foldersinlibraryheader, "foldersinlibraryheader");
            this.foldersinlibraryheader.ForeColor = System.Drawing.Color.Black;
            this.foldersinlibraryheader.Name = "foldersinlibraryheader";
            // 
            // folderBox
            // 
            resources.ApplyResources(this.folderBox, "folderBox");
            this.folderBox.FormattingEnabled = true;
            this.folderBox.Name = "folderBox";
            // 
            // okbutton
            // 
            resources.ApplyResources(this.okbutton, "okbutton");
            this.okbutton.Name = "okbutton";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            resources.ApplyResources(this.removeButton, "removeButton");
            this.removeButton.Name = "removeButton";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // folderBrowserDialog
            // 
            resources.ApplyResources(this.folderBrowserDialog, "folderBrowserDialog");
            // 
            // libraryEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.folderBox);
            this.Controls.Add(this.foldersinlibraryheader);
            this.Name = "libraryEditor";
            this.Load += new System.EventHandler(this.libraryEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label foldersinlibraryheader;
        private System.Windows.Forms.ListBox folderBox;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
