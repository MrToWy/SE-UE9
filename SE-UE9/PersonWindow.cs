using System;
using System.Windows.Forms;

namespace SE_UE9
{
    public partial class PersonWindow : Form
    {
        private Person person;


        public PersonWindow()
        {
            InitializeComponent();
            person = new Person();
            person.ObjectUpdated += Person_ObjectUpdated;
        }

        public PersonWindow(Person person)
        {
            InitializeComponent();
            this.person = person;
            person.ObjectUpdated += Person_ObjectUpdated;
        }

        private void Person_ObjectUpdated(object sender, EventArgs e)
        {
            this.textBoxVorname.Text = person.vorname;
            this.textBoxName.Text = person.name;
        }

        private void buttonNewDialog_Click(object sender, System.EventArgs e)
        {
            PersonWindow personWindow = new PersonWindow();
            personWindow.Show();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            person.vorname = textBoxVorname.Text;
            person.name = textBoxName.Text;
        }
    }
}