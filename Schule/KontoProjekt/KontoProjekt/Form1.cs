namespace KontoProjekt
{
    public partial class Form1 : Form
    {
        private Benutzer meinBenutzer;
        private lOgin funktion;
        private string name, vorname, password;
        public Form1()
        {
            meinBenutzer = new Benutzer();
            funktion = new lOgin();
            InitializeComponent();
            anmeldenGUI();
        }

        private void anmeldenButton_Click_1(object sender, EventArgs e)
        {


            name = nameTextBox.Text;
            vorname = vornameTextbox.Text;
            
            password = passwordTextbox.Text;

            if (meinBenutzer.IsUserCredentialsValid(name, vorname, password))
            {
                kontenGUI();
                label6.Text = "Hallo, " + vorname + " " + name;
            }
            else
            {
                MessageBox.Show("Anmeldeinformationen sind ungültig.");
            }


        }

        private void abmeldenButton_Click(object sender, EventArgs e)
        {
            clearVariables();
            clearTextBoxes();
            anmeldenGUI();
        }

        private void anmeldenGUI()
        {
            //
            // Login Textboxen sichtbar machen
            //
            nameTextBox.Visible = true;
            vornameTextbox.Visible = true;
            
            passwordTextbox.Visible = true;
            //
            // Login Labels sichtbar machen
            //
            label1.Visible = true;
            label2.Visible = true;
            
            label4.Visible = true;
            //
            // Login Groupboxen sichtbar machen
            //
            groupBox1.Visible = true;
            //
            // Login Button sichtbar machen
            //
            anmeldenButton.Visible = true;
            //
            // Konten Labels unsichtbar machen
            //
            label5.Visible = false;
            label6.Visible = false;
            //
            // Konten Bottons sichtbar machen
            //
            abmeldenButton.Visible = false;
            abmeldenButton.Enabled = false;
        }

        private void kontenGUI()
        {
            //
            // Login Textboxen unsichtbar machen
            //
            nameTextBox.Visible = false;
            vornameTextbox.Visible = false;
            
            passwordTextbox.Visible = false;
            //
            // Login Labels unsichtbar machen
            //
            label1.Visible = false;
            label2.Visible = false;
            
            label4.Visible = false;
            //
            // Login Groupboxen unsichtbar machen
            //
            groupBox1.Visible = false;
            //
            // Login Button unsichtbar machen
            //
            anmeldenButton.Visible = false;
            //
            // Konten Labels sichtbar machen
            //
            label5.Visible = true;
            label6.Visible = true;
            //
            // Konten Bottons sichtbar machen
            //
            abmeldenButton.Visible = true;
            abmeldenButton.Enabled = true;
        }

        private void clearVariables()
        {
            name = "";
            vorname = "";
            
            password = "";
        }

        private void clearTextBoxes()
        {
            nameTextBox.Text = null;
            vornameTextbox.Text = null;
            
            passwordTextbox.Text = null;

        }


    }
}