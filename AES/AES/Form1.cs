using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bCipher.Click += new EventHandler(bCipher_Click);
            bDecipher.Click += new EventHandler(bDecipher_Click);

        }

        void bCipher_Click(object sender, EventArgs e)
        {
            if ((tbInput.Text.Length == 0) || (tbKey.Text.Length == 0))
                return;

            Byte[,] state;
            Byte[] key;
            InputParser parser = new InputParser();

            state = parser.ParseInput(tbInput.Text);
            lblInput.Text = "Input\n" + Printer.PrintByteArray(state, 4);
            
            key = parser.ParseKey(tbKey.Text);
            int keyLength = tbKey.Text.Length / 2;
            lblKey.Text = "Key\n" + Printer.PrintByteArray(key, keyLength);

            int nK = tbKey.Text.Length / 8;
            Byte[][] expandedKey = AESFunctions.ExpandKey(key, nK);
            int nR = nK + 6;
            int nCol = 4 * (nR + 1);
            lblKeyExpand.Text = "Expanded Key\n" + Printer.PrintExpandedKeyArray(expandedKey, nCol);

            Byte[][,] allStates = AESFunctions.Cipher(state, expandedKey, nR);
            lblR1.Text = "Round1\n" + Printer.PrintByteArray(allStates[0],4);
            lblR2.Text = "Round2\n" + Printer.PrintByteArray(allStates[1], 4);
            lblR3.Text = "Round3\n" + Printer.PrintByteArray(allStates[2], 4);
            lblR4.Text = "Round4\n" + Printer.PrintByteArray(allStates[3], 4);
            lblR5.Text = "Round5\n" + Printer.PrintByteArray(allStates[4], 4);
            lblR6.Text = "Round6\n" + Printer.PrintByteArray(allStates[5], 4);
            lblR7.Text = "Round7\n" + Printer.PrintByteArray(allStates[6], 4);
            lblR8.Text = "Round8\n" + Printer.PrintByteArray(allStates[7], 4);
            lblR9.Text = "Round9\n" + Printer.PrintByteArray(allStates[8], 4);
            lblR10.Text = "Round10\n" + Printer.PrintByteArray(allStates[9], 4);
            lblOutput.Text = "Output\n" + Printer.PrintByteArray(allStates[nR], 4);
        }

        void bDecipher_Click(object sender, EventArgs e)
        {
            if ((tbInput.Text.Length == 0) || (tbKey.Text.Length == 0))
                return;

            Byte[,] state;
            Byte[] key;
            InputParser parser = new InputParser();

            state = parser.ParseInput(tbInput.Text);
            lblInput.Text = "Input\n" + Printer.PrintByteArray(state, 4);

            key = parser.ParseKey(tbKey.Text);
            int keyLength = tbKey.Text.Length / 2;
            lblKey.Text = "Key\n" + Printer.PrintByteArray(key, keyLength);

            int nK = tbKey.Text.Length / 8;
            Byte[][] expandedKey = AESFunctions.ExpandKey(key, nK);
            int nR = nK + 6;
            int nCol = 4 * (nR + 1);
            lblKeyExpand.Text = "Expanded Key\n" + Printer.PrintExpandedKeyArray(expandedKey, nCol);

            Byte[][,] allStates = AESFunctions.InvCipher(state, expandedKey, nR);
            lblR1.Text = "Round1\n" + Printer.PrintByteArray(allStates[0], 4);
            lblR2.Text = "Round2\n" + Printer.PrintByteArray(allStates[1], 4);
            lblR3.Text = "Round3\n" + Printer.PrintByteArray(allStates[2], 4);
            lblR4.Text = "Round4\n" + Printer.PrintByteArray(allStates[3], 4);
            lblR5.Text = "Round5\n" + Printer.PrintByteArray(allStates[4], 4);
            lblR6.Text = "Round6\n" + Printer.PrintByteArray(allStates[5], 4);
            lblR7.Text = "Round7\n" + Printer.PrintByteArray(allStates[6], 4);
            lblR8.Text = "Round8\n" + Printer.PrintByteArray(allStates[7], 4);
            lblR9.Text = "Round9\n" + Printer.PrintByteArray(allStates[8], 4);
            lblR10.Text = "Round10\n" + Printer.PrintByteArray(allStates[9], 4);
            lblOutput.Text = "Output\n" + Printer.PrintByteArray(allStates[nR], 4);
        }
    }
}
