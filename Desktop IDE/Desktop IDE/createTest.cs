using MetroFramework;
using MetroFramework.Forms;
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

namespace Desktop_IDE
{
    public partial class createTest : MetroForm,Test
    {
        static Random random = new Random();
        
        
        public createTest()
        {
            
            InitializeComponent();
            otherFunctions.test = this;
            
        }

        

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        

        private void clickLoad(object sender, EventArgs e)
        {
            otherFunctions.LoadQuestions();
            if (max == 0)
            {
                butCreate.Enabled = false;
            }
            else
                butCreate.Enabled = true;
        }

        public int max
        {
            get { return Convert.ToInt32(txtTotal.Text);}
            set { txtTotal.Text = value.ToString(); }
        }

        private string create()
        {
            
            List<int> rand = new List<int>();
            int count;
            string countx = txtItems.Text;
            int max;
            if (countx != null)
            {
                int.TryParse(txtTotal.Text, out max);
                int.TryParse(countx, out count);
                rand = GenerateRandom(count, 0, max);
                string tmp = otherFunctions.TmpFile();
                StreamWriter sw = new StreamWriter(tmp);
                sw.WriteLine(count.ToString());
                for (int i = 0; i < count; i++)
                {
                    sw.WriteLine("<" + (i + 1).ToString() + "><Q>:" + strData.strQuestion[rand[i]]);
                    sw.WriteLine("<" + (i + 1).ToString() + "><A>:" + strData.strA[rand[i]]);
                    sw.WriteLine("<" + (i + 1).ToString() + "><B>:" + strData.strB[rand[i]]);
                    sw.WriteLine("<" + (i + 1).ToString() + "><C>:" + strData.strC[rand[i]]);
                    sw.WriteLine("<" + (i + 1).ToString() + "><D>:" + strData.strD[rand[i]]);
                    sw.WriteLine("<" + (i + 1).ToString() + "><Answer>:" + strData.strChoice[rand[i]]);
                }
                sw.Close();
                return tmp;

            }
            else
                return null;

        }


        

        

        static List<int> GenerateRandom(int count, int min, int max)
        {

            //  initialize set S to empty
            //  for J := N-M + 1 to N do
            //    T := RandInt(1, J)
            //    if T is not in S then
            //      insert T in S
            //    else
            //      insert J in S
            //
            // adapted for C# which does not have an inclusive Next(..)
            // and to make it from configurable range not just 1.

            if (max <= min || count < 0 ||
                // max - min > 0 required to avoid overflow
                    (count > max - min && max - min > 0))
            {
                // need to use 64-bit to support big ranges (negative min, positive max)
                throw new ArgumentOutOfRangeException("Range " + min + " to " + max +
                        " (" + ((Int64)max - (Int64)min) + " values), or count " + count + " is illegal");
            }

            // generate count random values.
            HashSet<int> candidates = new HashSet<int>();

            // start count values before max, and end at max
            for (int top = max - count; top < max; top++)
            {
                // May strike a duplicate.
                // Need to add +1 to make inclusive generator
                // +1 is safe even for MaxVal max value because top < max
                if (!candidates.Add(random.Next(min, top + 1)))
                {
                    // collision, add inclusive max.
                    // which could not possibly have been added before.
                    candidates.Add(top);
                }
            }

            // load them in to a list, to sort
            List<int> result = candidates.ToList();

            // shuffle the results because HashSet has messed
            // with the order, and the algorithm does not produce
            // random-ordered results (e.g. max-1 will never be the first value)
            for (int i = result.Count - 1; i > 0; i--)
            {
                int k = random.Next(i + 1);
                int tmp = result[k];
                result[k] = result[i];
                result[i] = tmp;
            }
            return result;
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(txtItems.Text) != 0) && (txtItems != null))
            {
                string temp = create();
                if (testData.save(temp))
                {
                    MetroMessageBox.Show(this, "File has been saved", "Saved",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            else
                MetroMessageBox.Show(this, "You must put the desired number of items first", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
