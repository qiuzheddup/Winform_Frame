using System.Collections.Generic;
namespace Eap.Entity
{
    public class EapMenu
    {
        private string _MENU_ID;
        public string MENU_ID
        {
            get { return _MENU_ID; }
            set { _MENU_ID = value; }
        }

        private string _MENU_NAME;
        public string MENU_NAME
        {
            get { return _MENU_NAME; }
            set { _MENU_NAME = value; }
        }

        private string _PARENT_MENU_ID;
        public string PARENT_MENU_ID
        {
            get { return _PARENT_MENU_ID; }
            set { _PARENT_MENU_ID = value; }
        }

        private string _ASSEMBLY_NAME;
        public string ASSEMBLY_NAME
        {
            get { return _ASSEMBLY_NAME; }
            set { _ASSEMBLY_NAME = value; }
        }

        private string _FORM_NAME;
        public string FORM_NAME
        {
            get { return _FORM_NAME; }
            set { _FORM_NAME = value; }
        }

        private string _ICON;
        public string ICON
        {
            get { return _ICON; }
            set { _ICON = value; }
        }

        private IList<EapMenu> _SUB_MENU;
        public IList<EapMenu> SUB_MENU
        {
            get { return _SUB_MENU; }
            set { _SUB_MENU = value; }
        }
    }
}
