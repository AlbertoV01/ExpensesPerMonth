namespace ExpensesPerMonth
{
    partial class PrincipalScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_months = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GastoTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_months
            // 
            this.cb_months.FormattingEnabled = true;
            this.cb_months.Location = new System.Drawing.Point(54, 19);
            this.cb_months.Name = "cb_months";
            this.cb_months.Size = new System.Drawing.Size(121, 24);
            this.cb_months.TabIndex = 0;
            this.cb_months.Text = "Meses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domingo,
            this.lunes,
            this.martes,
            this.miercoles,
            this.jueves,
            this.viernes,
            this.sabado});
            this.dataGridView1.Location = new System.Drawing.Point(57, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 292);
            this.dataGridView1.TabIndex = 1;
            // 
            // domingo
            // 
            this.domingo.HeaderText = "Domingo";
            this.domingo.MinimumWidth = 6;
            this.domingo.Name = "domingo";
            // 
            // lunes
            // 
            this.lunes.HeaderText = "Lunes";
            this.lunes.MinimumWidth = 6;
            this.lunes.Name = "lunes";
            // 
            // martes
            // 
            this.martes.HeaderText = "Martes";
            this.martes.MinimumWidth = 6;
            this.martes.Name = "martes";
            // 
            // miercoles
            // 
            this.miercoles.HeaderText = "Miercoles";
            this.miercoles.MinimumWidth = 6;
            this.miercoles.Name = "miercoles";
            // 
            // jueves
            // 
            this.jueves.HeaderText = "Jueves";
            this.jueves.MinimumWidth = 6;
            this.jueves.Name = "jueves";
            // 
            // viernes
            // 
            this.viernes.HeaderText = "Viernes";
            this.viernes.MinimumWidth = 6;
            this.viernes.Name = "viernes";
            // 
            // sabado
            // 
            this.sabado.HeaderText = "Sabado";
            this.sabado.MinimumWidth = 6;
            this.sabado.Name = "sabado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mes: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-3, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 388);
            this.panel1.TabIndex = 4;
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(221, 19);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(121, 24);
            this.cb_year.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Año:";
            // 
            // btn_GastoTotal
            // 
            this.btn_GastoTotal.Location = new System.Drawing.Point(646, 23);
            this.btn_GastoTotal.Name = "btn_GastoTotal";
            this.btn_GastoTotal.Size = new System.Drawing.Size(334, 36);
            this.btn_GastoTotal.TabIndex = 7;
            this.btn_GastoTotal.Text = "Gasto total de";
            this.btn_GastoTotal.UseVisualStyleBackColor = true;
            this.btn_GastoTotal.Click += new System.EventHandler(this.btn_GastoTotal_Click);
            // 
            // PrincipalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.btn_GastoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_months);
            this.Name = "PrincipalScreen";
            this.Text = "PRINCIPAL SCREEN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_months;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GastoTotal;
    }
}

