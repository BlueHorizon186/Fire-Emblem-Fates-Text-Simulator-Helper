using Fates_Conversation_Helper.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fates_Conversation_Helper
{
    partial class FatesHelperUI
    {
        private List<string> sides = new List<string>
                            { "" , "Hoshido", "Nohr" };

        private FETranslator translator = new FETranslator();
        private CharacterLineup cLineup;
        private List<System.Xml.Linq.XElement> emotionsLst;


        /* Generate the code ready to be copy-pasted into the FEITS tool */
        private void GeneratePreview(string finisher)
        {
            XElement selectedChar = cLineup.ParentsLineup.Find(
                x => x.Element("english").Value
                .Equals(this.CharsComboBox.SelectedItem));

            if (selectedChar == null)
            {
                selectedChar = cLineup.ChildrenLineup.Find(
                    x => x.Element("english").Value
                    .Equals(this.CharsComboBox.SelectedItem));
            }

            XElement selectedEmt = emotionsLst.Find(
                x => x.Element("english").Value
                .Equals(this.EmotionsComboBox.SelectedItem));

            XElement blush = null;
            XElement sweat = null;

            if (this.BlushCheckbox.Checked)
            {
                blush = emotionsLst.Find(
                    x => x.Element("english").Value.Equals("Blush"));
            }

            if (this.SweatDropCheckbox.Checked)
            {
                sweat = emotionsLst.Find(
                    x => x.Element("english").Value.Equals("Sweat Drop"));
            }

            var dialogue = new StringBuilder();
            if (selectedChar.Element("english").Value == "Avatar")
            {
                dialogue.Append(Constants.HAS_AVATAR);
            }

            dialogue.AppendFormat("{0}{1}{2}|",
                Constants.BEGIN_CONV,
                Constants.CHAR_PORTRAIT_CODE,
                selectedChar.Element("japanese").Value);

            var checkedSide = this.Controls.OfType<RadioButton>()
                                  .FirstOrDefault(n => n.Checked);

            switch (checkedSide.Text.ToString())
            {
                case "Left":
                    dialogue.Append(Constants.LEFT);
                    break;
                case "Right":
                    dialogue.Append(Constants.RIGHT);
                    break;
                default:
                    dialogue.Append(Constants.SEPARATOR);
                    break;
            }

            dialogue.AppendFormat("{0}|{1}{2}|{3}{4}",
                Constants.PORTRAIT_SIDE_CODE,
                Constants.CHAR_NAME_CODE,
                selectedChar.Element("japanese").Value,
                Constants.CHAR_EMOTION_CODE,
                selectedEmt.Element("japanese").Value);

            if (blush != null)
            {
                dialogue.AppendFormat(",{0}", blush.Element("japanese").Value);
            }

            if (sweat != null)
            {
                dialogue.AppendFormat(",{0}", sweat.Element("japanese").Value);
            }

            dialogue.AppendFormat("|{0}{1}",
                this.DialogueTextBox.Text,
                finisher);
            this.PreviewTextBox.Text = dialogue.ToString();
        }
    }
}
