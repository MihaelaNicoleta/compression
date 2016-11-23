﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZ77
{
    public partial class Form1 : Form
    {
        String inputFileName;
        String compressedFileName;

        int noBitsForOffset = 3;
        int noBitsForLength = 2;

        LZ77 coder;

        public Form1()
        {
            InitializeComponent();

            for(int i = 3; i <= 16; i++)
            {
                lbOffset.Items.Add(i);
            }
            
            for (int i = 2; i <= 5; i++)
            {
                lbLength.Items.Add(i);
            }

            lbOffset.SelectedIndex = 0;
            lbLength.SelectedIndex = 0;

            tbTokens.Text = "";

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;

            DialogResult opened = dialog.ShowDialog();

            if (opened == DialogResult.OK)
            {
                tbPath.Text = dialog.FileName;
                inputFileName = tbPath.Text;
            }

        }

        private void btnLoadCompressedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "LZ77 Compressed Files (.lz77)|*.lz77";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;

            DialogResult opened = dialog.ShowDialog();

            if (opened == DialogResult.OK)
            {
                tbCompressedPath.Text = dialog.FileName;
                compressedFileName = tbCompressedPath.Text;
            }

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            noBitsForOffset = (int)lbOffset.SelectedItem;
            noBitsForLength = (int)lbLength.SelectedItem;

            if(inputFileName != "")
            {
                coder = new LZ77(noBitsForOffset, noBitsForLength);
                var ok = coder.compress(inputFileName);

                if (ok == true)
                {
                    tbTokens.Text += "\r\nCompression was a great success.\r\n";
                }

                if (chkDisplayTokens.Checked)
                {
                    List<Token> resultTokens = new List<Token>();
                    resultTokens = coder.getTokens();

                    displayTokens(resultTokens);
                }
            }
            else
            {
                throw new Exception("You haven't selecetd any file.");
            }        

        }

        private void displayTokens(List<Token> tokens)
        {
            foreach (Token token in tokens)
            {
                tbTokens.Text += token.toString();
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (compressedFileName != "")
            { 
                coder = new LZ77();
                var ok = coder.decompress(compressedFileName);
                if(ok == true)
                {
                    tbTokens.Text += "\r\nDecompression was a great success.\r\n";
                }
                
            }
            else
            {
                throw new Exception("You haven't selecetd any file.");
            }
        }
    }
}
