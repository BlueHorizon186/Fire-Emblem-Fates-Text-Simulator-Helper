using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Fates_Conversation_Helper.Classes
{
    public class FETranslator
    {
        private static string NamesPath = "../../CharacterInfo/NameTranslations.xml";
        private static string EmotionsPath = "../../CharacterInfo/EmotionsTranslations.xml";

        public CharacterLineup GetCharacters(string side)
        {
            var parentChars = ParseCharacters("parents", side);
            var childChars = ParseCharacters("children", side);
            return new CharacterLineup(parentChars, childChars);
        }

        public List<XElement> GetEmotions()
        {
            var emotionXml = XDocument.Load(EmotionsPath);
            return emotionXml.Descendants("emotion").ToList();
        }

        private List<XElement> ParseCharacters(string parentage,
                                               string side)
        {
            var charXml = XDocument.Load(NamesPath);
            return charXml.Descendants(parentage)
                          .Elements("character")
                          .Where(x => FilterCharacter(x, side))
                          .ToList();
        }

        private bool FilterCharacter(XElement next, string side)
        {
            if (side.Equals("Hoshido") || side.Equals("Nohr"))
            {
                return (next.Element("kingdom").Value.Equals(side)
                     || next.Element("kingdom").Value.Equals("All"));
            }
            return (next.Element("kingdom").Value.Equals(side));
        }
    }
}
