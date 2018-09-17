namespace Eap.Entity
{
    public class EapLogin
    {
        private string _USER_ID;
        public string USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }

        private string _USER_NAME;
        public string USER_NAME
        {
            get { return _USER_NAME; }
            set { _USER_NAME = value; }
        }
    }
}
