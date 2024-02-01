namespace DirectoryFileForEver
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxRutaFiles = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerCreationDate = new System.Windows.Forms.DateTimePicker();
            this.buttonApply = new System.Windows.Forms.Button();
            this.checkBoxCreationDate = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonDirectorios = new System.Windows.Forms.RadioButton();
            this.radioButtonTodo = new System.Windows.Forms.RadioButton();
            this.radioButtonFicheros = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OrderBy";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 121);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Tipo";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Fecha creacion";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(19, 81);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(91, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Descendiente";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(19, 40);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(82, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Ascendente";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 344);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxRutaFiles
            // 
            this.textBoxRutaFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxRutaFiles.Location = new System.Drawing.Point(196, 57);
            this.textBoxRutaFiles.Name = "textBoxRutaFiles";
            this.textBoxRutaFiles.Size = new System.Drawing.Size(345, 20);
            this.textBoxRutaFiles.TabIndex = 6;
            this.textBoxRutaFiles.TextChanged += new System.EventHandler(this.textBoxRutaFiles_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBuscar.Location = new System.Drawing.Point(565, 55);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Browser....";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(196, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(306, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(415, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filter.png");
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(6, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Search JSON";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button7.Location = new System.Drawing.Point(6, 314);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Write JSON";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.checkBoxNombre);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.textBoxName);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.dateTimePickerCreationDate);
            this.groupBox3.Controls.Add(this.buttonApply);
            this.groupBox3.Controls.Add(this.checkBoxCreationDate);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(793, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 344);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Location = new System.Drawing.Point(14, 133);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(63, 17);
            this.checkBoxNombre.TabIndex = 18;
            this.checkBoxNombre.Text = "Nombre";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            this.checkBoxNombre.CheckedChanged += new System.EventHandler(this.checkBoxNombre_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(13, 156);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 15;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // dateTimePickerCreationDate
            // 
            this.dateTimePickerCreationDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePickerCreationDate.Location = new System.Drawing.Point(13, 214);
            this.dateTimePickerCreationDate.Name = "dateTimePickerCreationDate";
            this.dateTimePickerCreationDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCreationDate.TabIndex = 6;
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonApply.Location = new System.Drawing.Point(151, 254);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 5;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxCreationDate
            // 
            this.checkBoxCreationDate.AutoSize = true;
            this.checkBoxCreationDate.Location = new System.Drawing.Point(13, 191);
            this.checkBoxCreationDate.Name = "checkBoxCreationDate";
            this.checkBoxCreationDate.Size = new System.Drawing.Size(89, 17);
            this.checkBoxCreationDate.TabIndex = 1;
            this.checkBoxCreationDate.Text = "Creation date";
            this.checkBoxCreationDate.UseVisualStyleBackColor = true;
            this.checkBoxCreationDate.CheckedChanged += new System.EventHandler(this.checkBoxCreationDate_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonDirectorios);
            this.groupBox4.Controls.Add(this.radioButtonTodo);
            this.groupBox4.Controls.Add(this.radioButtonFicheros);
            this.groupBox4.Location = new System.Drawing.Point(13, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter Advanced";
            // 
            // radioButtonDirectorios
            // 
            this.radioButtonDirectorios.AutoSize = true;
            this.radioButtonDirectorios.Location = new System.Drawing.Point(14, 21);
            this.radioButtonDirectorios.Name = "radioButtonDirectorios";
            this.radioButtonDirectorios.Size = new System.Drawing.Size(75, 17);
            this.radioButtonDirectorios.TabIndex = 7;
            this.radioButtonDirectorios.Text = "Directorios";
            this.radioButtonDirectorios.UseVisualStyleBackColor = true;
            this.radioButtonDirectorios.CheckedChanged += new System.EventHandler(this.radioButtonDirectorios_CheckedChanged);
            // 
            // radioButtonTodo
            // 
            this.radioButtonTodo.AutoSize = true;
            this.radioButtonTodo.Checked = true;
            this.radioButtonTodo.Location = new System.Drawing.Point(14, 75);
            this.radioButtonTodo.Name = "radioButtonTodo";
            this.radioButtonTodo.Size = new System.Drawing.Size(50, 17);
            this.radioButtonTodo.TabIndex = 9;
            this.radioButtonTodo.TabStop = true;
            this.radioButtonTodo.Text = "Todo";
            this.radioButtonTodo.UseVisualStyleBackColor = true;
            this.radioButtonTodo.CheckedChanged += new System.EventHandler(this.radioButtonTodo_CheckedChanged);
            // 
            // radioButtonFicheros
            // 
            this.radioButtonFicheros.AutoSize = true;
            this.radioButtonFicheros.Location = new System.Drawing.Point(14, 48);
            this.radioButtonFicheros.Name = "radioButtonFicheros";
            this.radioButtonFicheros.Size = new System.Drawing.Size(65, 17);
            this.radioButtonFicheros.TabIndex = 8;
            this.radioButtonFicheros.Text = "Ficheros";
            this.radioButtonFicheros.UseVisualStyleBackColor = true;
            this.radioButtonFicheros.CheckedChanged += new System.EventHandler(this.radioButtonFicheros_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1045, 545);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxRutaFiles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox textBoxRutaFiles;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonTodo;
        private System.Windows.Forms.RadioButton radioButtonFicheros;
        private System.Windows.Forms.RadioButton radioButtonDirectorios;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreationDate;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.CheckBox checkBoxCreationDate;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

