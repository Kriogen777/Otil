using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AIOSystemUtility3
{
    class Colours
    {
        // Background, Normal, Mouseover, Text1, Text2
        public static int SELECTED_COLOUR_SCHEME { get; private set; }
        public static List<Color[]> COLOURS { get; private set; }

        private static int indexOfLastDefaultScheme = 5;
        private static Colours instance = null;
        public static Colours GetInstance()
        {
            if (instance == null)
            {
                instance = new Colours();
            }
            return instance;
        }

        private Colours()
        {
            SELECTED_COLOUR_SCHEME = 0;
            COLOURS = new List<Color[]>();
            COLOURS.Add(
                new Color[] {
                Color.FromArgb(62,69,77),
                Color.FromArgb(94,103,113),
                Color.FromArgb(78,86,95),
                Color.FromArgb(198,99,106),
                Color.FromArgb(179,181,183)
            }
                );
            COLOURS.Add(
                new Color[] {
                Color.FromArgb(62,69,77),
                Color.FromArgb(94,103,113),
                Color.FromArgb(78,86,95),
                Color.FromArgb(23,210,124),
                Color.FromArgb(179,181,183)
            }
                );
            COLOURS.Add(
                new Color[] {
                Color.FromArgb(232,232,232),
                Color.FromArgb(212,212,212),
                Color.FromArgb(200,200,200),
                Color.FromArgb(71,71,71),
                Color.FromArgb(0,170,212)
            }
                );
            COLOURS.Add(
                new Color[] {
                Color.FromArgb(62,69,77),
                Color.FromArgb(94,103,113),
                Color.FromArgb(78,86,95),
                Color.FromArgb(179,181,183),
                Color.FromArgb(215,99,106)
            }
                );
            COLOURS.Add(
                new Color[] {
                Color.FromArgb(62,69,77),
                Color.FromArgb(94,103,113),
                Color.FromArgb(78,86,95),
                Color.FromArgb(179,181,183),
                Color.FromArgb(23,210,124)
            }
                );
            COLOURS.Add(
                new Color[] {
                Color.FromArgb(236,239,241),
                Color.FromArgb(228,231,233),
                Color.FromArgb(209,214,217),
                Color.FromArgb(127,139,143),
                Color.FromArgb(77,182,172)
            }
                );
            // Load settings
            loadCOLOURSFromSettings();
            try
            {
                SELECTED_COLOUR_SCHEME = AIOSystemUtility3.Properties.Settings.Default["SELECTED_COLOUR_SCHEME"] == null ? 0 : (int)AIOSystemUtility3.Properties.Settings.Default["SELECTED_COLOUR_SCHEME"];
            }
            catch (System.Configuration.ConfigurationErrorsException ex)
            {
                Console.WriteLine(ex);
                SELECTED_COLOUR_SCHEME = 0;
            }
        }

        public void SetSelectedColourScheme(int index)
        {
            if (index >= 0 && index < COLOURS.Count)
            {
                SELECTED_COLOUR_SCHEME = index;
                // Save settings
                try
                {
                    AIOSystemUtility3.Properties.Settings.Default["SELECTED_COLOUR_SCHEME"] = index;
                    AIOSystemUtility3.Properties.Settings.Default.Save();
                }
                catch (System.Configuration.ConfigurationErrorsException ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void AddColourScheme(Color[] colours)
        {
            COLOURS.Add(colours);
            // Save settings
            saveFromCOLOURS();
        }

        public void RemoveColourScheme(int index)
        {
            if (index > indexOfLastDefaultScheme)
            {
                if (SELECTED_COLOUR_SCHEME == index)
                {
                    SELECTED_COLOUR_SCHEME--;
                    AIOSystemUtility3.Properties.Settings.Default["SELECTED_COLOUR_SCHEME"] = SELECTED_COLOUR_SCHEME;
                    AIOSystemUtility3.Properties.Settings.Default.Save();
                }
                COLOURS.RemoveAt(index);
                // Save settings
                saveFromCOLOURS();
            }
        }

        private void saveFromCOLOURS()
        {
            List<String[]> returnable = new List<String[]>();
            foreach (Color[] arr in COLOURS)
            {
                String[] scheme = new String[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    scheme[i] = ColorTranslator.ToHtml(arr[i]);//arr[i].Name;
                }
                returnable.Add(scheme);
            }
            try
            {
                AIOSystemUtility3.Properties.Settings.Default["COLOURS"] = returnable;
                AIOSystemUtility3.Properties.Settings.Default.Save();
            }
            catch (System.Configuration.ConfigurationErrorsException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void loadCOLOURSFromSettings()
        {
            try
            {
                List<String[]> x = AIOSystemUtility3.Properties.Settings.Default["COLOURS"] == null ? new List<String[]>() : (List<String[]>)AIOSystemUtility3.Properties.Settings.Default["COLOURS"];
                if (x.Count > COLOURS.Count)
                {
                    COLOURS = new List<Color[]>();
                    foreach (String[] arr in x)
                    {
                        Color[] scheme = new Color[arr.Length];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            scheme[i] = System.Drawing.ColorTranslator.FromHtml(arr[i]);
                            //scheme[i] = Color.FromName(arr[i]);
                        }
                        COLOURS.Add(scheme);
                    }
                }
                else
                {
                    saveFromCOLOURS();
                }
            }
            catch (System.Configuration.ConfigurationErrorsException ex)
            {
                Console.WriteLine(ex);
                saveFromCOLOURS();
            }
        }
    }
}
