using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdatbazisGyak
{
    public partial class Form1 : Form
    {
        List<Auto> autokLista = new List<Auto>();
        DataTable raktarTable = new DataTable();
        public Form1()
        {
            InitializeComponent();

            autokLista.Add(new Auto("Pál", "BMW", "zöld"));
            autokLista.Add(new Auto("Petra", "VW", "piros"));
            autokLista.Add(new Auto("Melinda", "Ford", "fekete"));
            autokLista.Add(new Auto("Péter", "BMW", "ezüst"));

            TablazatsemaLetrehoz();
            TablazatFeltolt();

            dataGridView1.DataSource = raktarTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TablazatsemaLetrehoz() 
        {
            DataColumn gyartoColumn = new DataColumn("Gyártó", typeof(string));
            DataColumn szinColumn = new DataColumn("Szín", typeof(string));
            DataColumn nevColumn = new DataColumn("Név", typeof(string));

            DataColumn autoIdColumn = new DataColumn("autoId", typeof(int));
            autoIdColumn.Caption = "Autó ID";
            autoIdColumn.ReadOnly = true;
            autoIdColumn.AllowDBNull = false;
            autoIdColumn.Unique = true;
            autoIdColumn.AutoIncrement = true;
            autoIdColumn.AutoIncrementSeed = 0;
            autoIdColumn.AutoIncrementStep = 1;


            raktarTable.Columns.AddRange(new DataColumn[] {autoIdColumn, gyartoColumn, szinColumn, nevColumn });
        }

        private void TablazatFeltolt() 
        {
            foreach (Auto auto in autokLista)
            {
                DataRow dr = raktarTable.NewRow();

                dr["Gyártó"] = auto.Gyarto;
                dr["Szín"] = auto.Szin;
                dr["Név"] = auto.Nev;

                raktarTable.Rows.Add(dr);
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            try
            {
                raktarTable.Rows[int.Parse(txtTorol.Text)].Delete();
                raktarTable.AcceptChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            raktarTable.Rows.Clear();

            TablazatFeltolt();
        }
    }
}
