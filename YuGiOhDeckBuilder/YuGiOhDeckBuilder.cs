using Microsoft.VisualBasic.FileIO;
using System;
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
        private const string collectionFileDirectory = "..\\..\\Data\\Collection.csv";

        public List<ICard> Deck { get; set; }
        public List<ICard> Collection { get; set; }

        public YugiohDeckBuilderForm()
        {
            InitializeComponent();

            Deck = new List<ICard>();
            Collection = new List<ICard>();

            LoadCollection();
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
                ICard selectedCard = Collection
                    .Where(card => card.Name == (string)listBoxCollection.SelectedItem)
                    .FirstOrDefault();
                Deck.Add(selectedCard);
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
                CsvReader reader = new CsvReader();
                TextFieldParser parser = new TextFieldParser(openFileDialog.FileName);
                List<string> cardsAsCsv = reader.Read(parser);
                CardFactory factory = new CardFactory();

                listBoxDeck.Items.Clear();
                Deck.Clear();

                foreach (var csvCard in cardsAsCsv)
                {
                    List<string> properties = csvCard.Split(',').ToList();
                    ICard card = factory.CreateFromCsv(properties);
                    Deck.Add(card);
                    listBoxDeck.Items.Add(card.Name);
                }
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

                SaveCardsToCsv(filePath, Deck);  
            }
            else
            {
                MessageBox.Show("Unable to export your deck to the specified location", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCollection()
        {
            CsvReader reader = new CsvReader();
            TextFieldParser parser = new TextFieldParser(collectionFileDirectory);
            List<string> cardsAsCsv = reader.Read(parser);
            CardFactory factory = new CardFactory();

            listBoxCollection.Items.Clear();
            Collection.Clear();

            foreach (var csvCard in cardsAsCsv)
            {
                List<string> properties = csvCard.Split(',').ToList();
                ICard card = factory.CreateFromCsv(properties);
                Collection.Add(card);
                listBoxCollection.Items.Add(card.Name);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadCollection();
        }

        private void buttonDeleteCreatedCard_Click(object sender, EventArgs e)
        {
            if (listBoxCollection.SelectedItems.Count > 0)
            {
                foreach (var selectedCardIndex in listBoxCollection.SelectedIndices)
                {
                    Collection.RemoveAt((int)selectedCardIndex);
                }

                SaveCardsToCsv(collectionFileDirectory, Collection);
                LoadCollection();
            }
            else
            {
                MessageBox.Show("Please select a card to remove from the collection.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCardsToCsv(string filePath, List<ICard> cards)
        {
            CsvWriter csvWriter = new CsvWriter();
            StreamWriter stream = new StreamWriter(filePath);
            CardParser cardParser = new CardParser();
            List<string> csvLines = cardParser.SerialiseCardsToCsv(cards);

            csvWriter.Write(stream, csvLines);
        }
    }
}
