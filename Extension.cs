using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Class to provide extended UI tools: to standaralize the font.
    /// </summary>
    public static class Extension
    {


            /// <summary>
            /// Provides the same font for all controls (labels, buttons etc).
            /// </summary>
            /// <param name="controls"></param>
            /// <param name="font"></param>
            public static void SetGlobalFont(Control.ControlCollection controls, Font font)//collection class
            {
                foreach (Control control in controls)
                {
                    control.Font = font;

                    // Recursively apply the font to all child controls
                    if (control.HasChildren)
                    {
                        SetGlobalFont(control.Controls, font);
                    }
                }
            }
        




    }
}
