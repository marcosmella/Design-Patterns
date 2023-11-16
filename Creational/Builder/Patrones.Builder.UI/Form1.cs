using Builder.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Patrones.Builder.UI
{
    public partial class Form1 : Form
    {


        List<PizzaBuilder> _lines;
        public Form1()
        {
            InitializeComponent();

            _lines = new List<PizzaBuilder>();
            _lines.Add(new ItalianPizzaBuilder());
            _lines.Add(new LightPizzaBuilder());
            _lines.Add(new MozzarellaPizzaBuilder());
            _lines.Add(new StadiumPizzaBuilder());

            this.cboLineas.DataSource = _lines;
        
        }

        private void btnConstruír_Click(object sender, EventArgs e)
        {
            PizzaBuilder builder = (PizzaBuilder)cboLineas.SelectedItem;
            Pizza pizza = builder.BuildPizza();

            this.lstEntregas.Items.Add(pizza);
        }
    }
}
