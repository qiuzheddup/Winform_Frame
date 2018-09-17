namespace Eap.Entity
{
    public class EapButton
    {
        private decimal _BUTTON_ID;
        public decimal BUTTON_ID
        {
            get { return _BUTTON_ID; }
            set { _BUTTON_ID = value; }
        }

        private string _BUTTON_NAME;
        public string BUTTON_NAME
        {
            get { return _BUTTON_NAME; }
            set { _BUTTON_NAME = value; }
        }

        private string _BUTTON_TEXT;
        public string BUTTON_TEXT
        {
            get { return _BUTTON_TEXT; }
            set { _BUTTON_TEXT = value; }
        }

        private string _MENU_ID;
        public string MENU_ID
        {
            get { return _MENU_ID; }
            set { _MENU_ID = value; }
        }

        private string _USER_ID;
        public string USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }
    }
}
