namespace DirectoryFileForEver
{
    partial class FiltrarArchivo_Directorio
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
            this.checkBoxDT = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonDirectorios = new System.Windows.Forms.RadioButton();
            this.radioButtonArchivos = new System.Windows.Forms.RadioButton();
            this.radioButtonTodo = new System.Windows.Forms.RadioButton();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxDT
            // 
            this.checkBoxDT.AutoSize = true;
            this.checkBoxDT.Location = new System.Drawing.Point(57, 145);
            this.checkBoxDT.Name = "checkBoxDT";
            this.checkBoxDT.Size = new System.Drawing.Size(116, 17);
            this.checkBoxDT.TabIndex = 30;
            this.checkBoxDT.Text = "Fecha de Creación";
            this.checkBoxDT.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 176);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // radioButtonDirectorios
            // 
            this.radioButtonDirectorios.AutoSize = true;
            this.radioButtonDirectorios.Location = new System.Drawing.Point(57, 116);
            this.radioButtonDirectorios.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDirectorios.Name = "radioButtonDirectorios";
            this.radioButtonDirectorios.Size = new System.Drawing.Size(75, 17);
            this.radioButtonDirectorios.TabIndex = 28;
            this.radioButtonDirectorios.TabStop = true;
            this.radioButtonDirectorios.Text = "Directorios";
            this.radioButtonDirectorios.UseVisualStyleBackColor = true;
            // 
            // radioButtonArchivos
            // 
            this.radioButtonArchivos.AutoSize = true;
            this.radioButtonArchivos.Location = new System.Drawing.Point(57, 87);
            this.radioButtonArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonArchivos.Name = "radioButtonArchivos";
            this.radioButtonArchivos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonArchivos.TabIndex = 27;
            this.radioButtonArchivos.TabStop = true;
            this.radioButtonArchivos.Text = "Archivos";
            this.radioButtonArchivos.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodo
            // 
            this.radioButtonTodo.AutoSize = true;
            this.radioButtonTodo.Location = new System.Drawing.Point(57, 57);
            this.radioButtonTodo.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTodo.Name = "radioButtonTodo";
            this.radioButtonTodo.Size = new System.Drawing.Size(50, 17);
            this.radioButtonTodo.TabIndex = 26;
            this.radioButtonTodo.TabStop = true;
            this.radioButtonTodo.Text = "Todo";
            this.radioButtonTodo.UseVisualStyleBackColor = true;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(57, 211);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(77, 23);
            this.buttonAplicar.TabIndex = 25;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filtrar Por:";
            // 
            // FiltrarArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 271);
            this.Controls.Add(this.checkBoxDT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonDirectorios);
            this.Controls.Add(this.radioButtonArchivos);
            this.Controls.Add(this.radioButtonTodo);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.label1);
            this.Name = "FiltrarArchivo_Directorio";
            this.Text = "FiltrarArchivo_Directorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonDirectorios;
        private System.Windows.Forms.RadioButton radioButtonArchivos;
        private System.Windows.Forms.RadioButton radioButtonTodo;
        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.Label label1;
    }
}