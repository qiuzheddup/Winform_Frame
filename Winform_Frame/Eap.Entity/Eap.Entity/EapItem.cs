namespace Eap.Entity
{
    public class EapItem
    {
        public EapItem(string id, string text)
        {
            this._ID = id;
            this._TEXT = text;
        }

        public override string ToString()
        {
            return this._TEXT;
        }

        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _TEXT;
        public string TEXT
        {
            get { return _TEXT; }
            set { _TEXT = value; }
        }
    }
}
