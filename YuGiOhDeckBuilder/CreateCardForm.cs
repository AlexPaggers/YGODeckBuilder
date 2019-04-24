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
        private string[] MonsterTypes = { "Spellcaster", "Dragon", "Insect", "Warrior", "Dinosaur" };
        private string[] SpellTypes = { "Normal", "Field", "Quick-Play", "Equip", "Continuous" };
        private string[] TrapTypes = { "Normal", "Continuous", "Counter" };

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
            DisableAllProperties();
            
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

        private void DisableAllProperties()
        {
            comboBoxCardTypes.Items.Clear();
            textBoxCardName.Enabled = false;
            textBoxDescription.Enabled = false;
            comboBoxAttribute.Enabled = false;
            numericUpDownLevel.Enabled = false;
            comboBoxCardTypes.Enabled = false;
            numericUpDownAtk.Enabled = false;
            numericUpDownDef.Enabled = false;
        }

        private void EnableTrapProperties()
        {
            comboBoxCardTypes.Items.AddRange(TrapTypes);
            textBoxCardName.Enabled = true;
            textBoxDescription.Enabled = true;
            comboBoxAttribute.Enabled = false;
            numericUpDownLevel.Enabled = false;
            comboBoxCardTypes.Enabled = true;
            numericUpDownAtk.Enabled = false;
            numericUpDownDef.Enabled = false;
        }

        private void EnableSpellProperties()
        {
            comboBoxCardTypes.Items.AddRange(SpellTypes);
            textBoxCardName.Enabled = true;
            textBoxDescription.Enabled = true;
            comboBoxAttribute.Enabled = false;
            numericUpDownLevel.Enabled = false;
            comboBoxCardTypes.Enabled = true;
            numericUpDownAtk.Enabled = false;
            numericUpDownDef.Enabled = false;
        }

        private void EnableMonsterProperties()
        {
            comboBoxCardTypes.Items.AddRange(MonsterTypes);
            textBoxCardName.Enabled = true;
            textBoxDescription.Enabled = true;
            comboBoxAttribute.Enabled = true;
            numericUpDownLevel.Enabled = true;
            comboBoxCardTypes.Enabled = true;
            numericUpDownAtk.Enabled = true;
            numericUpDownDef.Enabled = true;
        }

        private void buttonCreateCard_Click(object sender, EventArgs e)
        {
            //Create card
        }
    }
}
