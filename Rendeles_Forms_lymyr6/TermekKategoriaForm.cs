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
    public partial class TermekKategoriaForm : Form
    {
        private RendelesDbContext _context;
        public TermekKategoriaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadKategoriak();
        }

        private void LoadKategoriak()
        {
            // Az összes kategória lekérdezése az adatbázisból
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            // TreeView tartalmának törlése
            treeViewKategoriak.Nodes.Clear();

            // Főkategóriák hozzáadása a TreeView-hoz
            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }
        }

        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            // TreeNode létrehozása az aktuális kategóriához
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            // Alkategóriák keresése és hozzáadása
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }

            return node;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode != null)
            {
                treeViewKategoriak.SelectedNode.BeginEdit();
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoadKategoriak();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TermekKategoria termekKategoria = new TermekKategoria();
            termekKategoria.Nev = "Új Kategória";
            termekKategoria.SzuloKategoriaId = null;
            _context.TermekKategoria.Add(termekKategoria);
            _context.SaveChanges();

            TreeNode node = new TreeNode(termekKategoria.Nev);
            node.Tag = termekKategoria;
            treeViewKategoriak.Nodes.Add(node);

            treeViewKategoriak.SelectedNode = node;

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TermekKategoria termekKategoria = new TermekKategoria();
            termekKategoria.Nev = "Új alkategória";
            termekKategoria.SzuloKategoriaId = ((TermekKategoria)treeViewKategoriak.SelectedNode.Tag).KategoriaId;
            _context.TermekKategoria.Add(termekKategoria);
            _context.SaveChanges();

            TreeNode node = new TreeNode(termekKategoria.Nev);
            node.Tag = termekKategoria;
            treeViewKategoriak.Nodes.Add(node);

            treeViewKategoriak.SelectedNode = node;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode.Nodes.Count == 0)
            {
                TermekKategoria kategoria = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                _context.TermekKategoria.Remove(kategoria);
                _context.SaveChanges();

                treeViewKategoriak.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Nem törölhető a kategória, mivel van alkategóriája!");
            }




        }

        private void treeViewKategoriak_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && !string.IsNullOrEmpty(e.Label))
            {
                TermekKategoria kategoria = (TermekKategoria)e.Node.Tag;
                kategoria.Nev = e.Label;
                _context.SaveChanges();
            }
        }
    }
}
