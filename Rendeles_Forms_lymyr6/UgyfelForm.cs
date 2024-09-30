using Rendeles_Forms_lymyr6.Data;
using Rendeles_Forms_lymyr6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_Forms_lymyr6
{
    public partial class UgyfelForm : Form
    {
        private RendelesDbContext _context;
        public UgyfelForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadData();
        }
        private void LoadData()
        {
            ugyfelBindingSource.DataSource = _context.Ugyfel.ToList();
        }

        private void btnHozzaadas_Click(object sender, EventArgs e)
        {
            var ujUgyfel = new Ugyfel { Nev = "Új Ügyfél", Email = "uj@pelda.com" };
            _context.Ugyfel.Add(ujUgyfel);
            _context.SaveChanges();
            LoadData();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (dataGridViewUgyfelek.CurrentRow != null)
            {
                var torlendoUgyfel = dataGridViewUgyfelek.CurrentRow.DataBoundItem as Ugyfel;
                if (torlendoUgyfel != null)
                {
                    _context.Ugyfel.Remove(torlendoUgyfel);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            LoadData();
        }

        private void btnFrissites_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
