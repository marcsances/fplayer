/*
 * This file is part of fPlayer.

    fPlayer is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LibAP is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with libAP.  If not, see <http://www.gnu.org/licenses/>.
 * */
// This class directly comes out from a solution at Stack Overflow: http://stackoverflow.com/questions/2519587/is-there-any-way-to-disable-the-double-click-to-copy-functionality-of-a-net-l
// Implements a workaround to solve that "feature" of NT 6.x that copies Label text on double click.
// Solves bug BTC110

using System.ComponentModel;
using System.Windows.Forms;
using System;

public class Label2 : Label
{
    private const int WM_LBUTTONDCLICK = 0x203;
    private string clipboardText;

    [DefaultValue(false)]
    [Description("Overrides default behavior of Label to copy Label text to clipboard on double click")]
    public bool CopyTextOnDoubleClick { get; set; }

    protected override void OnDoubleClick(EventArgs e)
    {
        if (!string.IsNullOrEmpty(clipboardText))
            Clipboard.SetData(DataFormats.Text, clipboardText);
        clipboardText = null;
        base.OnDoubleClick(e);
    }

    protected override void WndProc(ref Message m)
    {
        if (!CopyTextOnDoubleClick)
        {
            if (m.Msg == WM_LBUTTONDCLICK)
            {
                IDataObject d = Clipboard.GetDataObject();
                if (d.GetDataPresent(DataFormats.Text))
                    clipboardText = (string)d.GetData(DataFormats.Text);
            }
        }
        base.WndProc(ref m);
    }

}