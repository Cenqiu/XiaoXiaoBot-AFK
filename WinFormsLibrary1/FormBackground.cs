﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseTextBox
{
    public class TransTextBox : RichTextBox
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadLibrary(string lpFileName);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams prams = base.CreateParams;
                if (LoadLibrary("msftedit.dll") != IntPtr.Zero)
                {
                    prams.ExStyle |= 0x020; // transparent 
                    prams.ClassName = "RICHEDIT50W";// TRANSTEXTBOXW
                }
                return prams;
            }
        }
    }
    //[ToolboxBitmap(typeof(TextBox))]
    //public class TextBox1 : TextBox
    //{
    //    private string _emptyTextTip;
    //    private Color _emptyTextTipColor = Color.DarkGray;
    //    private const int WM_PAINT = 0xF;
    //    public TextBox1() : base()
    //    {

    //    }
    //    [DefaultValue("")]
    //    public string EmptyTextTip
    //    {
    //        get { return _emptyTextTip; }
    //        set
    //        {
    //            _emptyTextTip = value;
    //            base.Invalidate();
    //        }
    //    }

    //    [DefaultValue(typeof(Color), "DarkGray")]
    //    public Color EmptyTextTipColor
    //    {
    //        get { return _emptyTextTipColor; }
    //        set
    //        {
    //            _emptyTextTipColor = value;
    //            base.Invalidate();
    //        }
    //    }

    //    protected override void WndProc(ref Message m)
    //    {
    //        base.WndProc(ref m);
    //        if (m.Msg == WM_PAINT)
    //        {
    //            WmPaint(ref m);
    //        }
    //    }

    //    private void WmPaint(ref Message m)
    //    {
    //        using (Graphics graphics = Graphics.FromHwnd(base.Handle))
    //        {
    //            if (Text.Length == 0
    //                && !string.IsNullOrEmpty(_emptyTextTip)
    //                && !Focused)
    //            {
    //                TextFormatFlags format =
    //                    TextFormatFlags.EndEllipsis |
    //                    TextFormatFlags.VerticalCenter;

    //                if (RightToLeft == RightToLeft.Yes)
    //                {
    //                    format |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
    //                }

    //                TextRenderer.DrawText(
    //                    graphics,
    //                    _emptyTextTip,
    //                    Font,
    //                    base.ClientRectangle,
    //                    _emptyTextTipColor,
    //                    format);
    //            }
    //        }
    //    }

    //    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    //    private static extern IntPtr LoadLibrary(string lpFileName);
    //    protected override CreateParams CreateParams
    //    {
    //        get
    //        {
    //            CreateParams prams = base.CreateParams;
    //            if (LoadLibrary("msftedit.dll") != IntPtr.Zero)
    //            {
    //                prams.ExStyle |= 0x020; // transparent 
    //                prams.ClassName = "RICHEDIT50W";
    //            }
    //            return prams;
    //        }
    //    }
    //}
}