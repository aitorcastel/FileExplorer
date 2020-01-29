namespace FileExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.abrirButton = new System.Windows.Forms.Button();
            this.rutaTextBox = new System.Windows.Forms.TextBox();
            this.crearButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.verFicheroButton = new System.Windows.Forms.Button();
            this.ficherosList = new System.Windows.Forms.ListBox();
            this.directorioList = new System.Windows.Forms.ListBox();
            this.modFicheroButton = new System.Windows.Forms.Button();
            this.ficheroRadioButton = new System.Windows.Forms.RadioButton();
            this.directorioRadioButton = new System.Windows.Forms.RadioButton();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contenidoFichero = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.moveTextBox = new System.Windows.Forms.TextBox();
            this.moverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abrirButton
            // 
            this.abrirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirButton.Location = new System.Drawing.Point(193, 26);
            this.abrirButton.Name = "abrirButton";
            this.abrirButton.Size = new System.Drawing.Size(126, 23);
            this.abrirButton.TabIndex = 2;
            this.abrirButton.Text = "LISTAR PATH";
            this.abrirButton.UseVisualStyleBackColor = true;
            this.abrirButton.Click += new System.EventHandler(this.abrirButton_Click);
            // 
            // rutaTextBox
            // 
            this.rutaTextBox.Location = new System.Drawing.Point(336, 28);
            this.rutaTextBox.Name = "rutaTextBox";
            this.rutaTextBox.Size = new System.Drawing.Size(490, 20);
            this.rutaTextBox.TabIndex = 4;
            this.rutaTextBox.TextChanged += new System.EventHandler(this.rutaTextBox_TextChanged);
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(13, 331);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(108, 23);
            this.crearButton.TabIndex = 7;
            this.crearButton.Text = "CREAR";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click_1);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(280, 331);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 8;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // verFicheroButton
            // 
            this.verFicheroButton.Location = new System.Drawing.Point(509, 331);
            this.verFicheroButton.Name = "verFicheroButton";
            this.verFicheroButton.Size = new System.Drawing.Size(172, 23);
            this.verFicheroButton.TabIndex = 10;
            this.verFicheroButton.Text = "VER CONTENIDO FICHERO";
            this.verFicheroButton.UseVisualStyleBackColor = true;
            this.verFicheroButton.Click += new System.EventHandler(this.verFicheroButton_Click);
            // 
            // ficherosList
            // 
            this.ficherosList.FormattingEnabled = true;
            this.ficherosList.Location = new System.Drawing.Point(193, 165);
            this.ficherosList.Name = "ficherosList";
            this.ficherosList.Size = new System.Drawing.Size(633, 82);
            this.ficherosList.TabIndex = 11;
            // 
            // directorioList
            // 
            this.directorioList.FormattingEnabled = true;
            this.directorioList.Location = new System.Drawing.Point(193, 63);
            this.directorioList.Name = "directorioList";
            this.directorioList.Size = new System.Drawing.Size(633, 82);
            this.directorioList.TabIndex = 12;
            // 
            // modFicheroButton
            // 
            this.modFicheroButton.Location = new System.Drawing.Point(687, 331);
            this.modFicheroButton.Name = "modFicheroButton";
            this.modFicheroButton.Size = new System.Drawing.Size(139, 23);
            this.modFicheroButton.TabIndex = 13;
            this.modFicheroButton.Text = "MODIFICAR FICHERO";
            this.modFicheroButton.UseVisualStyleBackColor = true;
            this.modFicheroButton.Click += new System.EventHandler(this.modFicheroButton_Click);
            // 
            // ficheroRadioButton
            // 
            this.ficheroRadioButton.AutoSize = true;
            this.ficheroRadioButton.Location = new System.Drawing.Point(203, 334);
            this.ficheroRadioButton.Name = "ficheroRadioButton";
            this.ficheroRadioButton.Size = new System.Drawing.Size(60, 17);
            this.ficheroRadioButton.TabIndex = 15;
            this.ficheroRadioButton.TabStop = true;
            this.ficheroRadioButton.Text = "Fichero";
            this.ficheroRadioButton.UseVisualStyleBackColor = true;
            // 
            // directorioRadioButton
            // 
            this.directorioRadioButton.AutoSize = true;
            this.directorioRadioButton.Location = new System.Drawing.Point(127, 334);
            this.directorioRadioButton.Name = "directorioRadioButton";
            this.directorioRadioButton.Size = new System.Drawing.Size(70, 17);
            this.directorioRadioButton.TabIndex = 16;
            this.directorioRadioButton.TabStop = true;
            this.directorioRadioButton.Text = "Directorio";
            this.directorioRadioButton.UseVisualStyleBackColor = true;
            this.directorioRadioButton.CheckedChanged += new System.EventHandler(this.directorioRadioButton_CheckedChanged);
            // 
            // changeTextBox
            // 
            this.changeTextBox.Location = new System.Drawing.Point(193, 269);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.Size = new System.Drawing.Size(633, 20);
            this.changeTextBox.TabIndex = 17;
            this.changeTextBox.TextChanged += new System.EventHandler(this.changeDirTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "RUTA DIRECTORIO / FICHERO";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // contenidoFichero
            // 
            this.contenidoFichero.Location = new System.Drawing.Point(13, 360);
            this.contenidoFichero.Multiline = true;
            this.contenidoFichero.Name = "contenidoFichero";
            this.contenidoFichero.Size = new System.Drawing.Size(812, 135);
            this.contenidoFichero.TabIndex = 22;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(174, 234);
            this.webBrowser1.TabIndex = 23;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "MOVER / RENOMBRAR";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // moveTextBox
            // 
            this.moveTextBox.Location = new System.Drawing.Point(194, 297);
            this.moveTextBox.Name = "moveTextBox";
            this.moveTextBox.Size = new System.Drawing.Size(631, 20);
            this.moveTextBox.TabIndex = 25;
            this.moveTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // moverButton
            // 
            this.moverButton.Location = new System.Drawing.Point(361, 331);
            this.moverButton.Name = "moverButton";
            this.moverButton.Size = new System.Drawing.Size(142, 23);
            this.moverButton.TabIndex = 26;
            this.moverButton.Text = "MOVER / RENOMBRAR";
            this.moverButton.UseVisualStyleBackColor = true;
            this.moverButton.Click += new System.EventHandler(this.moverButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 507);
            this.Controls.Add(this.moverButton);
            this.Controls.Add(this.moveTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.contenidoFichero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeTextBox);
            this.Controls.Add(this.directorioRadioButton);
            this.Controls.Add(this.ficheroRadioButton);
            this.Controls.Add(this.modFicheroButton);
            this.Controls.Add(this.directorioList);
            this.Controls.Add(this.ficherosList);
            this.Controls.Add(this.verFicheroButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.rutaTextBox);
            this.Controls.Add(this.abrirButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Practica Ficheros C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button abrirButton;
        private System.Windows.Forms.TextBox rutaTextBox;
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button verFicheroButton;
        private System.Windows.Forms.ListBox ficherosList;
        private System.Windows.Forms.ListBox directorioList;
        private System.Windows.Forms.Button modFicheroButton;
        private System.Windows.Forms.RadioButton ficheroRadioButton;
        private System.Windows.Forms.RadioButton directorioRadioButton;
        private System.Windows.Forms.TextBox changeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contenidoFichero;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox moveTextBox;
        private System.Windows.Forms.Button moverButton;
    }
}

