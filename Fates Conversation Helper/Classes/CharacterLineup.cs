using System.Collections.Generic;
using System.Xml.Linq;

namespace Fates_Conversation_Helper.Classes
{
    public class CharacterLineup
    {
        private List<XElement> parentsLineup;
        private List<XElement> childrenLineup;

        public CharacterLineup(List<XElement> pLst, List<XElement> chLst)
        {
            parentsLineup = pLst;
            childrenLineup = chLst;
        }

        public CharacterLineup(List<XElement> pLst)
        {
            parentsLineup = pLst;
            childrenLineup = null;
        }

        public List<XElement> ParentsLineup
        {
            get { return parentsLineup; }
        }

        public List<XElement> ChildrenLineup
        {
            get { return childrenLineup; }
        }
    }
}
