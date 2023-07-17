using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_trainer.Layer
{
    internal class EventHandler
    {
        // Combo Text Box Event Handling.
        public void ComboTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("ComboTextBox: Event KeyDown");
        }

        public void ComboTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("ComboTextBox: Event KeyPress");
        }

        public void ComboTextBox_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("ComboTextBox: Event Leave");
        }

        // TL Training Switch Event Handling.
        public void FLTrain_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("FLTrainCheck: Event Checked");
        }
    }
}
