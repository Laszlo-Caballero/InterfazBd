using InterfazBd.Database;

namespace InterfazBd;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        CDatabase cDatabase = new CDatabase();
        cDatabase.getConexion();
    }
}
