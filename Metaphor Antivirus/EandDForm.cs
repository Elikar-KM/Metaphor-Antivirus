using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Metaphor_Antivirus
{
    /* MD5
     * AES
     * BASE64
     * CIPHER
     */

    public partial class EandDForm : Form
    {

        public EandDForm()
        {
            InitializeComponent();
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (Method.selectedValue == "MD5")
            {
                // MD5
            }
            else if (Method.selectedValue == "AES")
            {
                // AES
            }
            else if (Method.selectedValue == "BASE64")
            {
                // BASE64
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (Method.selectedValue == "MD5")
            {
                // MD5
            }
            else if (Method.selectedValue == "AES")
            {
                // AES
            }
            else if (Method.selectedValue == "BASE64")
            {
                // BASE64
            }
        }
    }
}
