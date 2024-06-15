using InterfazBd.Paneles;

namespace InterfazBd;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Login login = new Login();
        login.TopLevel = false;
        MainPanel.Controls.Add(login);
        login.Show();
    }
}