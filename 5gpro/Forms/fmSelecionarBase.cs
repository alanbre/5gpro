using _5gpro.Daos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmSelecionarBase : Form
    {
        private struct Bases
        {
            public string Database;
            public string Server;
            public string Uid;
            public string Pwd;
        }

        private List<Bases> bases = new List<Bases>();
        private readonly Bases localhost = new Bases()
        {
            Database = "5gprodatabase",
            Server = "localhost",
            Uid = "5gprouser",
            Pwd = "5gproedualan"
        };
        private readonly Bases dalva = new Bases()
        {
            Database = "5gprodatabase",
            Server = "192.168.2.111",
            Uid = "5gprouser",
            Pwd = "5gproedualan"
        };
        private readonly Bases eduardoNote = new Bases()
        {
            Database = "5gprodatabase",
            Server = "192.168.0.103",
            Uid = "5gprouser",
            Pwd = "5gproedualan"
        };
        private readonly Bases itamar = new Bases()
        {
            Database = "5gprodatabase",
            Server = "192.168.2.114",
            Uid = "5gprouser",
            Pwd = "5gproedualan"
        };

        public static string database = "";
        public static string server = "";
        public static string uid = "";
        public static string pwd = "";


        public fmSelecionarBase()
        {
            InitializeComponent();

            bases.Add(localhost);
            bases.Add(dalva);
            bases.Add(eduardoNote);
            bases.Add(itamar);
            PreencheGridBases();
        }
        private void BtSair_Click(object sender, EventArgs e) => Sair();
        private void BtEntrar_Click(object sender, EventArgs e) => Entrar();


        private void PreencheGridBases()
        {
            dgvBases.Rows.Clear();
            foreach (var b in bases)
            {
                dgvBases.Rows.Add(b.Database, b.Server, b.Uid, b.Pwd);
            }
            dgvBases.Refresh();
        }
        private void Sair()
        {
            Environment.Exit(0);
        }
        private void Entrar()
        {
            database = dgvBases.CurrentRow.Cells[0].Value.ToString();
            server = dgvBases.CurrentRow.Cells[1].Value.ToString();
            uid = dgvBases.CurrentRow.Cells[2].Value.ToString();
            pwd = dgvBases.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
