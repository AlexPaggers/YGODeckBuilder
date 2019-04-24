﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOhDeckBuilder
{
    public partial class YugiohDeckBuilderForm : Form
    {
        public YugiohDeckBuilderForm()
        {
            InitializeComponent();
            listBoxCollection.Items.Add("Summoned Skull");
            listBoxCollection.Items.Add("Black Luster Soldier");
            listBoxCollection.Items.Add("Mystical Space Typhoon");
            listBoxCollection.Items.Add("Sangan");
            listBoxCollection.Items.Add("Blue-Eyes Ultimate Dragon");
            listBoxCollection.Items.Add("Torrential Tribute");
            listBoxCollection.Items.Add("Odd-Eyes Pendulum Dragon");
            listBoxCollection.Items.Add("Cyber Dragon Infinity");
            listBoxCollection.Items.Add("Decode Talker");
        }

        private void buttonClearDeck_Click(object sender, EventArgs e)
        {
                        DialogResult result = MessageBox.Show("Clearing your deck will remove all cards you have added to it. " +
                "This cannot be undone. Would you like to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                listBoxDeck.Items.Clear();

                MessageBox.Show("Your deck has been cleared.", "Deck cleared!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAddToDeck_Click(object sender, EventArgs e)
        {
            if(listBoxCollection.SelectedItems.Count > 0)
            {
                listBoxDeck.Items.Add((string)listBoxCollection.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a card to add to your deck.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveFromDeck_Click(object sender, EventArgs e)
        {
            if(listBoxDeck.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a card to remove from deck.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = 0;

            //If the first item in the deck hasn't been selected            
            if(listBoxDeck.SelectedIndex > 0)
            {
                //save the index of the selected item
                index = listBoxDeck.SelectedIndex;
            }

            //remove the selected item
            listBoxDeck.Items.Remove(listBoxDeck.SelectedItem);

            //Check the deck isn't empty
            if(listBoxDeck.Items.Count > 0)
            {
                //Check that we didn't remove the first item
                if (index > 0)
                {
                    //If so, select the item above the item we deleted
                    listBoxDeck.SelectedIndex = index - 1;
                }
                else
                {
                    //Otherwise, select the new first item
                    listBoxDeck.SelectedIndex = 0;
                }
            } 
        }

        private void buttonCreateCard_Click(object sender, EventArgs e)
        {
            CreateCardForm createCardForm = new CreateCardForm();
            createCardForm.ShowDialog();
        }

        private void buttonImportDeck_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //IMPORT IT USING TEXT FIELD PARSER FROM VB NET
            }
            else
            {
                MessageBox.Show("Unable to import the specified file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveDeck_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //TODO add another dialogue box to choose a deck name
                DirectoryInfo directory = new DirectoryInfo(folderBrowserDialog.SelectedPath);

                string filePath = directory.FullName + @"\Deck.csv";

                DeckWriter deckWriter = new DeckWriter();

                //Hook this list of cards to the names above. Probable best solution is to just
                //Have the listviews show the name of a card and have a separate two lists for your deck and collection?

                List<MonsterCard> monsterCards = new List<MonsterCard>();
                StreamWriter writer = new StreamWriter(filePath);

                //foreach card in cards
                for (int i = 0; i < 5; i++)
                {
                    //TODO get each card as a list of strings and pass them througgh
                    deckWriter.Write(writer, new List<string>() { "1", "2", "3", "4", "5", "6" });
                }
            }
            else
            {
                MessageBox.Show("Unable to export your deck to the specified location", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}