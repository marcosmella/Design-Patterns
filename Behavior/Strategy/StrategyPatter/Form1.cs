using Strategy.Core;
//using System.Management.Instrumentation;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {

        List<Weapon> _strategysDisparo;
        Player player;
        public Form1()
        {
            InitializeComponent();

            _strategysDisparo = new List<Weapon>();

            _strategysDisparo.Add(new Gun());
            _strategysDisparo.Add(new Bazooka());
            _strategysDisparo.Add(new Ak47());

            this.cboEstrategias.DataSource = _strategysDisparo;


            player = new Player();
            player.Name = "Rambo";
            this.lblPlayer.Text = player.Name;

        }

        private void cmdShoot_Click(object sender, EventArgs e)
        {
          
                MessageBox.Show(player.Shoot());
           
         
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            Weapon weapon = (Weapon)this.cboEstrategias.SelectedItem;
            player.CambiarEstrategia(weapon);
        }
    }
}
