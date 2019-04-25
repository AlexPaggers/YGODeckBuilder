using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOhDeckBuilder
{
    public partial class ChooseDeckNameForm : Form
    {
        public string DeckName { get; set; }

        public ChooseDeckNameForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DeckName = textBoxDeckName.Text;

            if (DeckName.All(c => char.IsLetterOrDigit(c)))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Deck names can only contain alphanumeric characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
