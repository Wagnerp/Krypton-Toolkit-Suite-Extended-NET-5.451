﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.480/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore.Components.Controls.DialogButtons
{
    [ToolboxBitmap(typeof(KryptonButton))]
    public class KryptonNODialogButton : KryptonButton
    {
        public KryptonNODialogButton()
        {
            DialogResult = DialogResult.No;

            TextChanged += KryptonNODialogButton_TextChanged;

            ParentChanged += KryptonNODialogButton_ParentChanged;
        }

        private void KryptonNODialogButton_ParentChanged(object sender, EventArgs e)
        {
            Control parent = Parent;

            while (!(Parent is KryptonForm) && !(parent == null))
            {
                parent = parent.Parent;
            }

            if (parent is KryptonForm)
            {
                KryptonForm form = (KryptonForm)parent;

                form.CancelButton = this;
            }
        }

        private void KryptonNODialogButton_TextChanged(object sender, EventArgs e)
        {
            if (Text == Name) Text = "&No";
        }
    }
}