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
    public partial class CreateCardForm : Form
    {
        public CreateCardForm()
        {
            InitializeComponent();
        }

        enum CardType
        {
            Monster,
            Spell,
            Trap
        }

        private void CreateCardForm_Load(object sender, EventArgs e)
        {
            comboBoxCardType.Items.Add(nameof(CardType.Monster));
            comboBoxCardType.Items.Add(nameof(CardType.Spell));
            comboBoxCardType.Items.Add(nameof(CardType.Trap));
        }

        private void comboBoxCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disable all fields

            //Change type label and box contents
            labelType.Text = comboBoxCardType.SelectedItem.ToString() + " Type:";

            //Enable fields that pertain to monster cards
            if ((string)comboBoxCardType.SelectedItem == nameof(CardType.Monster))
            {
                EnableMonsterProperties();
            }

            //Enable fields that pertain to spell cards
            if ((string)comboBoxCardType.SelectedItem == nameof(CardType.Spell))
            {
                EnableSpellProperties();
            }

            //Enable fields that pertain to trap cards
            if ((string)comboBoxCardType.SelectedItem == nameof(CardType.Trap))
            {
                EnableTrapProperties();
            }
        }

        private void EnableTrapProperties()
        {
        }

        private void EnableSpellProperties()
        {
        }

        private void EnableMonsterProperties()
        {
        }

        private void buttonCreateCard_Click(object sender, EventArgs e)
        {
            //Create card
        }
    }
}
