namespace Eap.Entity
{
    public class EapUserMenuRight
    {
        private decimal _USER_MENU_RIGHT_ID;
        public decimal USER_MENU_RIGHT_ID
        {
            get { return _USER_MENU_RIGHT_ID; }
            set { _USER_MENU_RIGHT_ID = value; }
        }

        private string _USER_ID;
        public string USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }

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
       
    }
}
