using System;

namespace SE_UE9
{
    public class Person
    {
        private string _name;
        public string name {
            get
            {
                return _name;
            }
            set {
                if (_name == value) return;

                _name = value;
                ObjectUpdated(this, null);
            } 
        }

        private string _vorname;
        public string vorname {
            get
            {
                return _vorname;
            }
            set
            {
                if (_vorname == value) return;

                _vorname = value;
                ObjectUpdated(this, null);
            }
        }


        public event EventHandler ObjectUpdated;
    }
}