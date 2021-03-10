using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numberOfWords = Convert.ToInt32(passphraseSize.Text);
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < numberOfWords; i++)
            {
                var concRoll = concatenateRolls.Fiverolls();
                var getWordIndex = new WordHelper();
                var word = WordHelper.GetWord(concRoll);

                stringBuilder.Append(word);
                stringBuilder.Append(" ");
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);

            resultBox.Text = stringBuilder.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passphraseSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passphrase_Generator_Load(object sender, EventArgs e)
        {

        }
    }
}
