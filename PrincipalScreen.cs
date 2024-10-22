using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesPerMonth
{
    public partial class PrincipalScreen : Form
    {
        Operations _Operations = new Operations();
        String _date = String.Empty;
        Form register_form = new Form();
        TextBox amount = new TextBox();
        Label label = new Label();

        public PrincipalScreen()
        {
            InitializeComponent();
           
            dataGridView1.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#243642");
            dataGridView1.BorderStyle = BorderStyle.None;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#243642");

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.CurrentCell = null;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Dock = DockStyle.Fill;

            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");
            label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");

            cb_months.BackColor= System.Drawing.ColorTranslator.FromHtml("#387478");
            cb_months.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");

            cb_year.BackColor = System.Drawing.ColorTranslator.FromHtml("#387478");
            cb_year.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");


            btn_GastoTotal.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");
            btn_GastoTotal.BackColor = System.Drawing.ColorTranslator.FromHtml("#387478");
            btn_GastoTotal.FlatStyle = FlatStyle.Flat;

            dataGridView1.EnableHeadersVisualStyles = false; 
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#629584");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");


            dataGridView1.RowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#387478");
            dataGridView1.RowsDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#387478");
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");

            dataGridView1.CellDoubleClick += dataGridView_CellDoubleClick;

            amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox1_KeyPress);

            cb_year.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_year.Items.AddRange(new object[] { "2024", "2025" });
            cb_months.DropDownStyle = ComboBoxStyle.DropDownList;
            FillComboBox();
        }

        private void FillComboBox()
        {
            cb_months.Items.AddRange(new object[]
            {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre",
                "Diciembre"
            });

            cb_months.SelectedIndexChanged += cb_Months_SelectedIndexChanged;
            cb_year.SelectedIndexChanged += cb_Year_SelectedIndexChanged;
        }
        int year = 0;

        private void cb_Year_SelectedIndexChanged (object sender, EventArgs e)
        {
            if(int.TryParse(cb_year.Text,out year))
            {
                FillDataGridView(cb_months.SelectedIndex + 1, year);
               
                btn_GastoTotal.Text = $"Gasto total de {cb_months.Text}: ${GastoTotal()}";
            }
        }
        private void cb_Months_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.TryParse(cb_year.Text, out year))
            {
                FillDataGridView(cb_months.SelectedIndex + 1, year);
 
                btn_GastoTotal.Text = $"Gasto total de {cb_months.Text}: ${GastoTotal()}";

            }
        }

        private void FillDataGridView(int month, int year)
        {
            if(month > 0) {
            dataGridView1.Rows.Clear();
            DateTime _date = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(_date.Year, _date.Month);
            int dayWeek = (int)_date.DayOfWeek;
            int rowIndex = 0;

                for (int i = 1; i <= daysInMonth; i++)
                {

                    if (dayWeek == 0 && i != 1)
                    {
                        dataGridView1.Rows.Add();
                        rowIndex++;
                    }
                    if (dataGridView1.Rows.Count <= rowIndex)
                    {
                        dataGridView1.Rows.Add();
                    }

                    dataGridView1[dayWeek, rowIndex].Value = i;
                    dataGridView1[dayWeek, rowIndex].ReadOnly = true;
                    dayWeek = (dayWeek + 1) % 7;
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellvalue = dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                if (cellvalue != null)
                {
                    register_form.Text = "REGISTER WINDOW";

                    Button btn_insert = new Button();
                    btn_insert.Text = "Ingresar monto gastado";
                    btn_insert.Location = new Point(190, 50);
                    btn_insert.Width = 200;
                    btn_insert.Height = 50;
                    btn_insert.BackColor = System.Drawing.ColorTranslator.FromHtml("#387478");
                    btn_insert.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");
                    btn_insert.FlatStyle = FlatStyle.Flat;
                    btn_insert.Click += btn_Insert_Click;
                 
                    amount.Location = new Point(190,20);
                    amount.Width = 200;

                    _date = $"{cb_year.Text}-{cb_months.SelectedIndex + 1}-{cellvalue}";

                    DataTable table = new DataTable();
                    table = _Operations.GetRows(_date);
                    string money = String.Empty;

                    if (table.Rows.Count>0)
                    {
                        money = table.Rows[0][1].ToString();
                    }
                    else
                    {
                        money = "$0";
                    }

                    label.Text = $"La cantidad que se ha gastado en este día {_date} es de: {money}";
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E2F1E7");

                    register_form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    this.MaximizeBox = false;
                    register_form.BackColor = System.Drawing.ColorTranslator.FromHtml("#243642");
                    register_form.Controls.Add(amount);
                    register_form.Controls.Add(btn_insert);
                    register_form.Controls.Add(label);
                    register_form.StartPosition = FormStartPosition.CenterScreen;
                    register_form.Size = new Size(600, 600);
                    register_form.ShowDialog();
                }
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e) 
        {
            decimal amountd = 0;
            if (decimal.TryParse(amount.Text, out amountd))
            {
                if (!_Operations.Exist(_date))
                {
                    if (_Operations.Insert(_date, amountd))
                    {
                        MessageBox.Show("Agregado con exito");
                        amount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un registro de las ganancias del día seleccionado");
                    amount.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ha dejado el campo vacío");
            }        
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        public String GastoTotal()
        {
            DataTable table2 = new DataTable();
            table2 = _Operations.GetRowsWithOutFilters();
            var filasFiltradas = table2.AsEnumerable()
                                .Where(row =>
                                {
                                    DateTime fecha;
                                    bool esFechaValida = DateTime.TryParse(row.Field<string>("Fecha"), out fecha);
                                    return esFechaValida && fecha.Month == cb_months.SelectedIndex + 1 && fecha.Year == int.Parse(cb_year.Text);
                                }).ToList();

            decimal total = 0;

            for (int i = 0; i < filasFiltradas.Count; i++)
            {
                for (int j = 1; j < table2.Columns.Count; j++)
                {
                    total += Convert.ToDecimal(filasFiltradas[i][j].ToString());
                }
            }

            return total.ToString();
        }

        private void btn_GastoTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
