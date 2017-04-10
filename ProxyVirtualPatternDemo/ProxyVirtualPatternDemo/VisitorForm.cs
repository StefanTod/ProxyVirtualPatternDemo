using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyVirtualPatternDemo
{
    public partial class VisitorForm : Form
    {

        private Hero hero;
        private Mage mage;
        private MagicFrog magicFrog;
        private Wolf wolf;
        private int timerCounter = 0;
        public VisitorForm()
        {
            InitializeComponent();
            hero = new Hero();
            mage = new Mage();
            wolf = new Wolf();
            magicFrog = new MagicFrog();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            if (magicFrog.Health < 0)
            {
                heroAttackFrogBtn.Enabled = false;
                mageAttackFrogBtn.Enabled = false;
            }
            else
            {
                
                frogHpPb.Value = magicFrog.Health;
                frogArmorLbl.Text = Convert.ToString(magicFrog.Armor);
                frogMrLbl.Text = Convert.ToString(magicFrog.MagicResistance);
                frogHpLbl.Text = Convert.ToString(magicFrog.Health);
                frogMaxHpLbl.Text = Convert.ToString(magicFrog.MaxHealth);
            }

            if (wolf.Health < 0)
            {
                heroAttackWolfBtn.Enabled = false;
                heroAttackWolfBtn.Enabled = false;
                
            }
            else
            {
                wolfHpPb.Value = wolf.Health;
                wolfArmorLbl.Text = Convert.ToString(wolf.Armor);
                wolfMrLbl.Text = Convert.ToString(wolf.MagicResistance);
                wolfHpLbl.Text = Convert.ToString(wolf.Health);
                wolfMaxHpLbl.Text = Convert.ToString(wolf.MaxHealth);
            }
        }

        private void heroAttackFrogBtn_Click(object sender, EventArgs e)
        {
            hero.attacks(magicFrog);
            UpdateInfo();
        }

        private void heroAttackWolfBtn_Click(object sender, EventArgs e)
        {
            hero.attacks(wolf);
            UpdateInfo();
            
        }

        private void mageAttackFrogBtn_Click(object sender, EventArgs e)
        {
            mage.attacks(magicFrog);
            UpdateInfo();
        }

        private void mageAttackWolfBtn_Click(object sender, EventArgs e)
        {
            mage.attacks(wolf);
            UpdateInfo();
        }
    }
}
