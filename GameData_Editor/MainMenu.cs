using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameData_Editor
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            Skills skillsWindow = new Skills();
            skillsWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enemies enemiesWindow = new Enemies();
            enemiesWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bonuses bonusesWindow = new Bonuses();
            bonusesWindow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Equipment equipmentWindow = new Equipment();
            equipmentWindow.Show();
        }
    }
}
