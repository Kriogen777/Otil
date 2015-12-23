﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace AIOSystemUtility3
{
    public delegate void VoidDelegate();
    public static class Utils
    {

        /// <summary>
        /// Black magic that lets us ignore issues where something is wrong 
        /// without surrounding every single line in a try-catch.
        /// 
        /// Don't try this at home folks.
        /// Source: http://stackoverflow.com/questions/117173/c-try-catch-every-line-of-code-without-individual-try-catch-blocks
        /// </summary>
        public static void Try(VoidDelegate v)
        {
            try
            {
                v();
            }
            catch { }
        }

        /// <summary>
        /// Method allowing us to animate controls as we se fit
        /// Source: http://stackoverflow.com/questions/6102241/how-can-i-add-moving-effects-to-my-controls-in-c
        /// </summary>
        public enum Effect { Roll, Slide, Center, Blend }

        public static void Animate(Control ctl, Effect effect, int msec, int angle, bool visited = false)
        {
            int flags = effmap[(int)effect];
            if (ctl.Visible) { 
                flags |= 0x10000;
                //angle += 180; 
            }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[(angle % 360) / 45];

            // Part of Form1.renderedOnce [] - horrible animation hack
            if (!visited)
            {
                ctl.Visible = !ctl.Visible;
                ctl.Visible = !ctl.Visible;
                //Console.WriteLine(ctl.Name + " has been hacked into animating properly.");
            }
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }

        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);



        // Solution to draw text onto an Icon from : http://stackoverflow.com/a/5966965/4331033
        public static Icon GetIcon(string text)
        {
            //Create bitmap, kind of canvas
            Bitmap bitmap = new Bitmap(32, 32);

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            //System.Drawing.Font drawFont = new System.Drawing.Font("Calibri", 14, FontStyle.Bold);
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);

            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            graphics.DrawIcon(icon, new Rectangle(0, 0, 32, 32));
            graphics.DrawString(text, drawFont, drawBrush, 0, 4);
            
            //To Save icon to disk
            bitmap.Save("icon.ico", System.Drawing.Imaging.ImageFormat.Icon);

            Icon createdIcon = Icon.FromHandle(bitmap.GetHicon());

            drawFont.Dispose();
            drawBrush.Dispose();
            graphics.Dispose();
            bitmap.Dispose();

            return createdIcon;
        }


    }
}