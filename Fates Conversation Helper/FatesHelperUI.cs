using Fates_Conversation_Helper.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fates_Conversation_Helper
{
    public partial class FatesHelperUI : Form
    {
        /* Main Constructor */
        public FatesHelperUI()
        {
            InitializeComponent();
            this.CharsComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            this.CharsComboBox.DrawItem 
                += new DrawItemEventHandler(this.CharsComboBox_DrawItem);
            this.CharsComboBox.SelectedIndexChanged
                += new EventHandler(this.CharsComboBox_SelectedIndexChanged);
        }


        /* GUI On Load Actions */
        private void FatesHelperUI_Load(object sender, EventArgs e)
        {
            foreach (var s in this.sides)
            {
                this.SidesComboBox.Items.Add(s);
            }

            emotionsLst = translator.GetEmotions();
            emotionsLst.ForEach(x => {
                string emotionName = x.Element("english").Value;

                if (emotionName.Equals("Blush") ||
                    emotionName.Equals("Sweat Drop"))
                {
                    return;
                }
                this.EmotionsComboBox.Items.Add(emotionName);
            });
        }


        /* Fonts to be used to write text within the app */
        Font itemsFont = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
        Font separatorFont = new Font("Microsoft Sans Serif", 9, FontStyle.Italic);

        /* Define character combobox items' behavior */
        private void CharsComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (cLineup != null && (e.Index == cLineup.ParentsLineup.Count + 1
                                    || e.Index == 0))
            {
                e.Graphics.DrawString(CharsComboBox.Items[e.Index].ToString(),
                                      separatorFont,
                                      Brushes.LightSlateGray,
                                      e.Bounds);
            }

            else if (e.Index >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(CharsComboBox.Items[e.Index].ToString(),
                                      itemsFont,
                                      Brushes.Black,
                                      e.Bounds);
                e.DrawFocusRectangle();
            }
        }


        /* Populate or unpopulate the characters combobox with the kingdom
         * selected by the user */
        private void SidesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SidesComboBox.SelectedIndex <= 0)
            {
                StartOver();
                return;
            }

            EnableControl(this.CharsComboBox);
            this.CharsComboBox.Items.Clear();

            var selectedSide = (string)this.SidesComboBox.SelectedItem;
            cLineup = translator.GetCharacters(selectedSide);

            this.CharsComboBox.Items.Add("--- 1st Generation ---");
            foreach (var ch in cLineup.ParentsLineup)
            {
                this.CharsComboBox.Items.Add(ch.Element("english").Value);
            }

            this.CharsComboBox.Items.Add("--- 2nd Generation ---");
            foreach (var ch in cLineup.ChildrenLineup)
            {
                this.CharsComboBox.Items.Add(ch.Element("english").Value);
            }
        }


        /* Prepare text generating behavior based on the selected character */
        private void CharsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CharsComboBox.SelectedIndex == 0 ||
                CharsComboBox.SelectedIndex == cLineup.ParentsLineup.Count + 1)
            {
                CharsComboBox.SelectedIndex = -1;
                return;
            }
            EnableControl(this.EmotionsComboBox);
        }


        /* Once the main emotion is chosen, you are ready to begin writing
         * down the dialogues :) */
        private void EmotionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControl(this.BlushCheckbox);
            EnableControl(this.SweatDropCheckbox);
            EnableAllConversationControls();
        }


        /* Start all over again. */
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            StartOver();
        }


        /* Adds new line */
        private void NewlineBtn_Click(object sender, EventArgs e)
        {
            this.DialogueTextBox.Text += "\\n";
        }


        /* Generate dialogue with upcoming line scroll */
        private void ScrollNextBtn_Click(object sender, EventArgs e)
        {
            GeneratePreview(Constants.LINE_SCROLL);
        }


        /* Adds the Avatar's name to the dialogue */
        private void AddAvatarBtn_Click(object sender, EventArgs e)
        {
            this.DialogueTextBox.Text += Constants.AVATAR_NAME;
        }


        /* Generate the last dialogue of the conversation */
        private void EndBtn_Click(object sender, EventArgs e)
        {
            GeneratePreview(Constants.END_CONV);
        }


        /* ****************************************************************
         *                       Helper Functions
         * ***************************************************************/

        /* Return application settings to startup default. */
        private void StartOver()
        {
            this.CharsComboBox.Items.Clear();
            this.SidesComboBox.SelectedIndex = 0;
            this.EmotionsComboBox.SelectedIndex = -1;

            this.DialogueTextBox.Text = "";
            this.PreviewTextBox.Text = "";

            DisableAllControls(this);
            EnableControl(this.SidesComboBox);
            EnableControl(this.ClearBtn);
        }


        /* Disable every single control in the application except
         * the Kingdom Combobox. This is done whenever the user
         * unselects the previously selected kingdom or clicks
         * the "Clear" button. */
        private void DisableAllControls(Control control)
        {
            foreach (Control cont in control.Controls)
            {
                DisableAllControls(cont);
            }
            control.Enabled = false;
        }


        /* This method enables the given control as parameter.
         * Use this method instead of directly setting the "enabled"
         * property because it ensures the parent is enabled too. */
        private void EnableControl(Control control)
        {
            if (control != null)
            {
                control.Enabled = true;
                EnableControl(control.Parent);
            }
        }


        /* This method encapsulates the task of enabling all controls
         * to write the conversation: Dialogue, Screen Pos, etc. */
        private void EnableAllConversationControls()
        {
            EnableControl(this.NoPortraitChoiceBtn);
            EnableControl(this.LeftChoiceBtn);
            EnableControl(this.RightChoiceBtn);

            EnableControl(this.DialogueTextBox);
            EnableControl(this.NewlineBtn);
            EnableControl(this.ScrollNextBtn);
            EnableControl(this.AddAvatarBtn);

            EnableControl(this.PreviewTextBox);
            EnableControl(this.EndBtn);
        }
    }
}
