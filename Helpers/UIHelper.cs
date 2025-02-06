using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using Coursework.Exceptions;

namespace Coursework.Helpers
{
    public enum CustomFont
    {
        Build,
        Secondary
    }
    public enum CursorStyle
    {
        Default,
        TFClass
    }

    public static class UIHelper
    {
        private static PrivateFontCollection fontCollection = new();

        public static Font? TF2Build;
        public static Font? TF2Secondary;

        /// <summary>
        /// <c>P/Invoke</c> Creates a cursor handle from a cursor file. Allows the custom cursor to utilise colour.
        /// </summary>
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string fileName);

        /// <summary>
        /// Loads the font into a location in a PrivateFontCollection and instantiates it to a variable.
        /// </summary>
        public static void MakeFont()
        {
            string fontPath = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Resources\";
            fontCollection.AddFontFile(Path.Combine(fontPath, "TF2Build.ttf"));
            fontCollection.AddFontFile(Path.Combine(fontPath, "TF2secondary.ttf"));

            // Instantiation to font variables from PrivateFontCollection
            TF2Secondary = new Font(fontCollection.Families[1], 12.0F);
            TF2Build = new Font(fontCollection.Families[0], 16.0F);
        }

        /// <summary>
        /// Applies the specified custom font to a Control. If the font entered is invalid, a FontNotFoundException is thrown.
        /// </summary>
        public static void UseFont(this Control control, CustomFont fontChoice)
        {
            switch (fontChoice)
            {
                case CustomFont.Build:
                    control.Font = new(TF2Build.FontFamily, control.Font.SizeInPoints);
                    break;

                case CustomFont.Secondary:
                    control.Font = new(TF2Secondary.FontFamily, control.Font.SizeInPoints);
                    break;

                default:
                    Debug.WriteLine($"Font not found for Control {control} located in {control.Parent}. Using fallback font.");
                    throw new FontNotFoundException();
            }
        }

        /// <summary>
        /// Iterates through each Control (and its children, if applicable) and applies a font - 'Build' if the Text property is fully uppercase, 'Secondary' if not.
        /// </summary>
        public static void ApplyFonts(Control form) // This is the method which will apply the custom fonts to the controls in the form. It takes the base form as input (the Form class is derived from Control)
        {
            foreach (Control control in form.Controls) // First, the method will iterate over each Control in the form
            {
                if (control.Controls.Count > 0) // This will check if the Control has any children (this will be used to apply these fonts to Controls located in Panels, GroupBoxes, etc.)
                {
                    ApplyFonts(control); // calls the method using the Control found to have children as the parameter.
                }

                if (control.GetType() == typeof(TextBox)) // checks for textboxes which can include placeholder text
                {
                    TextBox textBox = (TextBox)control; // parses the control to a TextBox object so the placeholder text can be accessed

                    if (textBox.PlaceholderText.ToUpper() == textBox.PlaceholderText)  // removes spaces and check if the string is fully uppercase, then applies fonts as specified
                    {
                        control.UseFont(CustomFont.Build);
                    }
                    else
                    {
                        control.UseFont(CustomFont.Secondary);
                    }
                }

                if (control.GetType() == typeof(ListView))
                {
                    ListView listView = (ListView)control;
                    foreach (ListViewItem cell in listView.Items)
                    {
                        if (cell.Text.ToUpper() == cell.Text)  // removes spaces and check if the string is fully uppercase, then applies fonts as specified
                        {
                            control.UseFont(CustomFont.Build);
                        }
                        else
                        {
                            control.UseFont(CustomFont.Secondary);
                        }
                    }
                }


                if (!String.IsNullOrEmpty(control.Text) && control.Text.ToUpper() == control.Text) // Ignores TextBoxes (handled above) and checks if the string (with spaces removed - these always count as lowercase) matches itself when it is fully capitalised, which ensures the string iss all caps)
                {
                    control.UseFont(CustomFont.Build); // strings which are made all caps are set to use the Build font, which acts as a title display font
                }
                else
                {
                    control.UseFont(CustomFont.Secondary); // otherwise the Secondary font is used as a more general font.
                }
            }
        }

        /// <summary>
        /// Applies a custom cursor to each Control within the form as well as the overarching Form object.
        /// </summary>
        public static void ApplyCursor(Control form, CursorStyle cursorType)
        {
            Cursor customCursor;
            string cursorPath = $@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Cursors\";

            uint id = FormHelper.s_quizPlayer == null ? 0 : FormHelper.s_quizPlayer.TFClass.Id;

            switch (cursorType)
            {
                case CursorStyle.Default:
                    customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "defaultCursor.cur")));
                    break;

                case CursorStyle.TFClass:
                    switch (id)
                    {
                        case 1:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "scoutCursor.cur")));
                            break;

                        case 2:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "soldierCursor.cur")));
                            break;

                        case 3:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "pyroCursor.cur")));
                            break;

                        case 4:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "demoCursor.cur")));
                            break;

                        case 5:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "hwgCursor.cur")));
                            break;

                        case 6:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "engineerCursor.cur")));
                            break;

                        case 7:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "medicCursor.cur")));
                            break;

                        case 8:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "sniperCursor.cur")));
                            break;

                        case 9:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "spyCursor.cur")));
                            break;

                        default:
                            customCursor = new Cursor(LoadCursorFromFile(Path.Combine(cursorPath, "defaultCursor.cur")));
                            break;
                    }
                    break;

                default:
                    throw new CursorNotFoundException();
            }

            foreach (Control control in form.Controls)
            {
                if (control.Controls.Count > 0)
                {
                    ApplyCursor(control, cursorType);
                }

                control.Cursor = customCursor;
            }

            form.Cursor = customCursor;
        }

        /// <summary>
        /// Draws a custom ToolTip via the OwnerDraw property, giving it the same appearance as the rest of the UI.
        /// </summary>
        public static void DrawToolTip(object sender, DrawToolTipEventArgs e)
        {
            ToolTip toolTip = (ToolTip)sender;
            SolidBrush textBrush = new(toolTip.ForeColor);

            using (StringFormat sf = new())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                e.Graphics.Clear(toolTip.BackColor);
                e.Graphics.DrawString(e.ToolTipText, UIHelper.TF2Secondary, textBrush, e.Bounds, sf);
            }
        }

        /// <summary>
        /// Resizes the custom drawn ToolTip to account for the change in font.
        /// </summary>
        public static void SizeToolTip(object sender, PopupEventArgs e)
        {
            string toolTip = ((ToolTip)sender).GetToolTip(e.AssociatedControl);

            Size textSize = TextRenderer.MeasureText(toolTip, UIHelper.TF2Secondary);

            e.ToolTipSize = textSize;
        }
    }
}
