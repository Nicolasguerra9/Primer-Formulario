namespace PrimerProyectoNicolasGuerraGarcia
{
    partial class FormPeticion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSalirPeticion = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxresumen = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminarTodos = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBoxQuieroIr = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBoxCursoMatriculado = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTom = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxModulo = new System.Windows.Forms.GroupBox();
            this.checkedListBoxModulo = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNombreModulo = new System.Windows.Forms.Label();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxresumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxQuieroIr.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxCursoMatriculado.SuspendLayout();
            this.groupBoxTom.SuspendLayout();
            this.groupBoxModulo.SuspendLayout();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButtonSalirPeticion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::PrimerProyectoNicolasGuerraGarcia.Properties.Resources.nuevo;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButtonSalirPeticion
            // 
            this.toolStripButtonSalirPeticion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSalirPeticion.Image = global::PrimerProyectoNicolasGuerraGarcia.Properties.Resources.salida;
            this.toolStripButtonSalirPeticion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalirPeticion.Name = "toolStripButtonSalirPeticion";
            this.toolStripButtonSalirPeticion.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonSalirPeticion.Text = "toolStripButton2";
            this.toolStripButtonSalirPeticion.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxresumen);
            this.groupBox1.Controls.Add(this.groupBoxQuieroIr);
            this.groupBox1.Controls.Add(this.groupBoxCursoMatriculado);
            this.groupBox1.Controls.Add(this.groupBoxModulo);
            this.groupBox1.Controls.Add(this.groupBoxDatosPersonales);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 528);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxresumen
            // 
            this.groupBoxresumen.Controls.Add(this.dataGridView1);
            this.groupBoxresumen.Controls.Add(this.buttonEliminarTodos);
            this.groupBoxresumen.Controls.Add(this.buttonEliminar);
            this.groupBoxresumen.Location = new System.Drawing.Point(6, 322);
            this.groupBoxresumen.Name = "groupBoxresumen";
            this.groupBoxresumen.Size = new System.Drawing.Size(672, 200);
            this.groupBoxresumen.TabIndex = 12;
            this.groupBoxresumen.TabStop = false;
            this.groupBoxresumen.Text = "Resumen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Nom,
            this.Apellido});
            this.dataGridView1.Location = new System.Drawing.Point(10, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 145);
            this.dataGridView1.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data Pet.";
            this.Data.Name = "Data";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // buttonEliminarTodos
            // 
            this.buttonEliminarTodos.Location = new System.Drawing.Point(91, 20);
            this.buttonEliminarTodos.Name = "buttonEliminarTodos";
            this.buttonEliminarTodos.Size = new System.Drawing.Size(103, 23);
            this.buttonEliminarTodos.TabIndex = 1;
            this.buttonEliminarTodos.Text = "Eliminar Todos";
            this.buttonEliminarTodos.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(10, 20);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 0;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuieroIr
            // 
            this.groupBoxQuieroIr.Controls.Add(this.comboBox4);
            this.groupBoxQuieroIr.Controls.Add(this.comboBox5);
            this.groupBoxQuieroIr.Controls.Add(this.textBox3);
            this.groupBoxQuieroIr.Controls.Add(this.label5);
            this.groupBoxQuieroIr.Controls.Add(this.label6);
            this.groupBoxQuieroIr.Controls.Add(this.label7);
            this.groupBoxQuieroIr.Controls.Add(this.groupBox3);
            this.groupBoxQuieroIr.Location = new System.Drawing.Point(331, 146);
            this.groupBoxQuieroIr.Name = "groupBoxQuieroIr";
            this.groupBoxQuieroIr.Size = new System.Drawing.Size(347, 169);
            this.groupBoxQuieroIr.TabIndex = 11;
            this.groupBoxQuieroIr.TabStop = false;
            this.groupBoxQuieroIr.Text = "Curso donde quiero ir";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(57, 130);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(284, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(58, 74);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(283, 21);
            this.comboBox5.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(58, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(283, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Profesor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tutor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Curso";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(10, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 43);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tom";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(170, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "Tarda";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(48, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Mati";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBoxCursoMatriculado
            // 
            this.groupBoxCursoMatriculado.Controls.Add(this.comboBox3);
            this.groupBoxCursoMatriculado.Controls.Add(this.comboBox2);
            this.groupBoxCursoMatriculado.Controls.Add(this.textBox4);
            this.groupBoxCursoMatriculado.Controls.Add(this.label4);
            this.groupBoxCursoMatriculado.Controls.Add(this.label3);
            this.groupBoxCursoMatriculado.Controls.Add(this.label2);
            this.groupBoxCursoMatriculado.Controls.Add(this.groupBoxTom);
            this.groupBoxCursoMatriculado.Location = new System.Drawing.Point(6, 146);
            this.groupBoxCursoMatriculado.Name = "groupBoxCursoMatriculado";
            this.groupBoxCursoMatriculado.Size = new System.Drawing.Size(319, 169);
            this.groupBoxCursoMatriculado.TabIndex = 4;
            this.groupBoxCursoMatriculado.TabStop = false;
            this.groupBoxCursoMatriculado.Text = "Curso donde estas matriculado";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(57, 130);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(256, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(58, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(255, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(255, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tutor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curso";
            // 
            // groupBoxTom
            // 
            this.groupBoxTom.Controls.Add(this.radioButton2);
            this.groupBoxTom.Controls.Add(this.radioButton1);
            this.groupBoxTom.Location = new System.Drawing.Point(10, 20);
            this.groupBoxTom.Name = "groupBoxTom";
            this.groupBoxTom.Size = new System.Drawing.Size(268, 43);
            this.groupBoxTom.TabIndex = 0;
            this.groupBoxTom.TabStop = false;
            this.groupBoxTom.Text = "Tom";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(170, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Tarda";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(48, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mati";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxModulo
            // 
            this.groupBoxModulo.Controls.Add(this.checkedListBoxModulo);
            this.groupBoxModulo.Controls.Add(this.comboBox1);
            this.groupBoxModulo.Controls.Add(this.labelNombreModulo);
            this.groupBoxModulo.Location = new System.Drawing.Point(331, 40);
            this.groupBoxModulo.Name = "groupBoxModulo";
            this.groupBoxModulo.Size = new System.Drawing.Size(347, 100);
            this.groupBoxModulo.TabIndex = 3;
            this.groupBoxModulo.TabStop = false;
            this.groupBoxModulo.Text = "Modulo";
            // 
            // checkedListBoxModulo
            // 
            this.checkedListBoxModulo.CheckOnClick = true;
            this.checkedListBoxModulo.ColumnWidth = 65;
            this.checkedListBoxModulo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkedListBoxModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxModulo.FormattingEnabled = true;
            this.checkedListBoxModulo.Items.AddRange(new object[] {
            "UF1",
            "UF2",
            "UF3",
            "UF4",
            "UF5"});
            this.checkedListBoxModulo.Location = new System.Drawing.Point(10, 63);
            this.checkedListBoxModulo.MultiColumn = true;
            this.checkedListBoxModulo.Name = "checkedListBoxModulo";
            this.checkedListBoxModulo.Size = new System.Drawing.Size(331, 20);
            this.checkedListBoxModulo.TabIndex = 0;
            this.checkedListBoxModulo.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // labelNombreModulo
            // 
            this.labelNombreModulo.AutoSize = true;
            this.labelNombreModulo.Location = new System.Drawing.Point(7, 29);
            this.labelNombreModulo.Name = "labelNombreModulo";
            this.labelNombreModulo.Size = new System.Drawing.Size(44, 13);
            this.labelNombreModulo.TabIndex = 0;
            this.labelNombreModulo.Text = "Nombre";
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.textBox2);
            this.groupBoxDatosPersonales.Controls.Add(this.textBox1);
            this.groupBoxDatosPersonales.Controls.Add(this.labelApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.labelNom);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(6, 40);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(319, 100);
            this.groupBoxDatosPersonales.TabIndex = 2;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos Personales";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 2;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(7, 63);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(7, 30);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(44, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nombre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia de peticion";
            // 
            // FormPeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormPeticion";
            this.Text = "FormPeticion";
            this.Load += new System.EventHandler(this.FormPeticion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxresumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxQuieroIr.ResumeLayout(false);
            this.groupBoxQuieroIr.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxCursoMatriculado.ResumeLayout(false);
            this.groupBoxCursoMatriculado.PerformLayout();
            this.groupBoxTom.ResumeLayout(false);
            this.groupBoxTom.PerformLayout();
            this.groupBoxModulo.ResumeLayout(false);
            this.groupBoxModulo.PerformLayout();
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalirPeticion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxQuieroIr;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBoxCursoMatriculado;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTom;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxModulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelNombreModulo;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.GroupBox groupBoxresumen;
        private System.Windows.Forms.CheckedListBox checkedListBoxModulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button buttonEliminarTodos;
        private System.Windows.Forms.Button buttonEliminar;
    }
}