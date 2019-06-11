// dgvgroupedcell.cs

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace _5gpro.Funcoes
{
    public partial class MyForm : Form
    {



        DataGridView dgv;

        bool IsTheSameCellValue(int column, int row)
        {

            DataGridViewCell cell1 = dgv[column, row];
            DataGridViewCell cell2 = dgv[column, row - 1];

            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }

            if (cell1.Value.ToString() == cell2.Value.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex == 0)
                return;

            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;

            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dgv.AdvancedCellBorderStyle.Top;
            }
        }

        void MyForm_Load(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ds.ReadXml("http://cbsa.com.br/rss");

            dgv.ColumnCount = 5;
            dgv.Columns[0].DataPropertyName = "title";
            dgv.Columns[0].HeaderText = "title";
            dgv.Columns[1].DataPropertyName = "link";
            dgv.Columns[1].HeaderText = "link";
            dgv.Columns[2].DataPropertyName = "description";
            dgv.Columns[2].HeaderText = "description";

            dgv.AutoGenerateColumns = false;
            for (int i = 0; i < ds.Tables["item"].Rows.Count; i++)
            {
                //Definir a mesma descrição para testar o agrupamento
                ds.Tables["item"].Rows[i]["description"] = "descrição";
            }
            dgv.DataSource = ds.Tables["item"];
        }

        public MyForm()
        {
            //InitializeComponent();
            dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
            dgv.CellPainting += new DataGridViewCellPaintingEventHandler(dgv_CellPainting);
            this.Controls.Add(dgv);
            this.Load += new EventHandler(MyForm_Load);
        }
    }
}
