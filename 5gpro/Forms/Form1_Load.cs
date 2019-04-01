using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class Form1_Load : Form
    {
        public Form1_Load()
        {
            InitializeComponent();
        }

        public void Form1_Load_Load(object sender, EventArgs e)
        {
            // Tabela pai  
            DataTable dtstudent = new DataTable();
            // adiciona coluna ao item de dados     
            dtstudent.Columns.Add("Student_ID", typeof(int));
            dtstudent.Columns.Add("Student_Name", typeof(string));
            dtstudent.Columns.Add("Student_RollNo", typeof(string));
            // Child table  
            DataTable dtstudentMarks = new DataTable();
            dtstudentMarks.Columns.Add("Student_ID", typeof(int));
            dtstudentMarks.Columns.Add("Subject_ID", typeof(int));
            dtstudentMarks.Columns.Add("Subject_Name", typeof(string));
            dtstudentMarks.Columns.Add("Marks", typeof(int));
            // Adicionando Linhas  

            dtstudent.Rows.Add(111, "Devesh", "03021013014");
            dtstudent.Rows.Add(222, "ROLI", "0302101444");
            dtstudent.Rows.Add(333, "ROLI Ji", "030212222");
            dtstudent.Rows.Add(444, "NIKHIL", "KANPUR");
            // data para devesh ID = 111  
            dtstudentMarks.Rows.Add(111, "01", "Physics", 99);
            dtstudentMarks.Rows.Add(111, "02", "Maths", 77);
            dtstudentMarks.Rows.Add(111, "03", "C #", 100);
            dtstudentMarks.Rows.Add(111, "01", "Physics", 99);
            // data para ROLI ID = 222  
            dtstudentMarks.Rows.Add(222, "01", "Physics", 80);
            dtstudentMarks.Rows.Add(222, "02", "English", 95);
            dtstudentMarks.Rows.Add(222, "03", "Commerce", 95);
            dtstudentMarks.Rows.Add(222, "01", "BankPO", 99);

            DataSet dsDataset = new DataSet();
            // Adicionar duas tabelas de dados no conjunto de dados   

            dsDataset.Tables.Add(dtstudent);
            dsDataset.Tables.Add(dtstudentMarks);
            DataRelation Datatablerelation = new DataRelation("DetailsMarks", dsDataset.Tables[0].Columns[0], dsDataset.Tables[1].Columns[0], true);
            dsDataset.Relations.Add(Datatablerelation);
            dataGrid1.DataSource = dsDataset.Tables[0];
        }
    }
}
