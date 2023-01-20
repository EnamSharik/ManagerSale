using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.INTERFACE.SALE {
    public partial class frameMain_sale : Form {
        private int childFormNumber = 0;
        Form super;
        

        public frameMain_sale(Form super, string name) {
            InitializeComponent();
            this.super = super;
            this.text_user.Text = name;
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void button_closeSesion_Click(object sender, EventArgs e) {
            super.Visible = true;
            this.Close();
        }

        private void button_product_Click(object sender, EventArgs e) {
            INTERFACE.SALE.frame_productoEnlistado frame = new frame_productoEnlistado(MANAGER_SALE.CONTROLLER.GlobalVARS.gestorProductoEnlistado);
            frame.MdiParent = this;
            MANAGER_SALE.CONTROLLER.GlobalVARS.gestorProductoEnlistado = frame.gestorProductoEnlistado;
            frame.Show();
        }

        private void button_client_Click(object sender, EventArgs e) {
            INTERFACE.SALE.frame_datoClient frame = new frame_datoClient(MANAGER_SALE.CONTROLLER.GlobalVARS.gestorProductoEnlistado.total);
            frame.MdiParent = this;           
            frame.Show();
        }
    }
}
