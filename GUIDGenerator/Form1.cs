using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDGenerator
{
    public partial class MainForm : Form
    {
        private Guid guid;
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateGUID(object sender, EventArgs e)
        {
            guid = Guid.NewGuid();
            guidTxt.Text = guid.ToString();
        }

        private void ToCharArry(object sender, EventArgs e)
        {
            int pp = 0;
            guid = Guid.Parse(guidTxt.Text);

            String guidString = guid.ToString();
            StringBuilder outstr = new StringBuilder();
            if (enbraces.Checked)
            {
                pp = 1;
                outstr.AppendFormat("0x{0,02:X}, ", (int)'{');
            }

            for (int i = 0; i < guidString.Length; i++)
            {
                if ((i + pp) % 12 == 0 && i != 0)
                    outstr.AppendFormat("\r\n");
                int val = (int)guidString[i];
                outstr.AppendFormat("0x{0,02:X}, ", val);
            }

            if (enbraces.Checked)
                outstr.AppendFormat("0x{0,02:X}", (int)'}');

            GUIDarray.Text = outstr.ToString();
        }

        private void ToWcharArray(object sender, EventArgs e)
        {
            int pp = 0;
            guid = Guid.Parse(guidTxt.Text);

            String guidString = guid.ToString();
            StringBuilder outstr = new StringBuilder();
            if (enbraces.Checked)
            {
                pp = 1;
                outstr.AppendFormat("0x{0,02:X}, 0x00, ", (int)'{');
            }

            for (int i = 0; i < guidString.Length; i++)
            {
                if ((i + pp) % 6 == 0 && i != 0)
                    outstr.AppendFormat("\r\n");
                int val = (int)guidString[i];
                outstr.AppendFormat("0x{0,02:X}, 0x00, ", val);
            }

            if (enbraces.Checked)
                outstr.AppendFormat("0x{0,02:X}, 0x00", (int)'}');

            GUIDarray.Text = outstr.ToString();
        }
    }
}
