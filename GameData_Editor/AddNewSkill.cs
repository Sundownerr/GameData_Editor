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
    public partial class AddNewSkill : Form
    {
        public AddNewSkill()
        {
            InitializeComponent();
        }

        private void CheckCB(CheckBox cb1, CheckBox cb2)
        {
            if (cb1.Checked)
            {
                cb2.Checked = false;
            } else
            {
                cb2.Checked = true;
            }            
        }

        private void EnableElements(string elementName, bool enabled)
        {
            int elementsHeight;

            if (elementName == "Derivable")
            {
                elementsHeight = DerivableL.Height + DerivablePlusL.Height + FirstParentCOB.Height + SecondParentCOB.Height;

                if (enabled)
                {
                    DerivableL.Visible = true;
                    DerivablePlusL.Visible = true;
                    FirstParentCOB.Visible = true;
                    SecondParentCOB.Visible = true;

                    ValueInfoGB.Height += elementsHeight / 2;
                }
                else
                {
                    DerivableL.Visible = false;
                    DerivablePlusL.Visible = false;
                    FirstParentCOB.Visible = false;
                    SecondParentCOB.Visible = false;

                    ValueInfoGB.Height -= elementsHeight / 2;
                }
            }

            if(elementName == "Lasts")
            {
                elementsHeight = LastsCOB.Height + LastsL.Height;

                if (enabled)
                {
                    LastsCOB.Visible = true;
                    LastsL.Visible = true;                  
                }
                else
                {
                    LastsCOB.Visible = false;
                    LastsL.Visible = false;
                }
            }
           
        }    
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewSkill_Load(object sender, EventArgs e)
        {
            
        }

        private void SelfCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(SelfCB, EnemyCB);
        }

        private void EnemyCB_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckCB(EnemyCB, SelfCB);
        }

        private void ActiveCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(ActiveCB, PassiveCB);
        }

        private void PassiveCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(PassiveCB, ActiveCB);
        }

        private void HealingCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(HealingCB, DamagingCB);
        }

        private void DamagingCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(DamagingCB, HealingCB);
        }

        private void InstantCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(InstantCB, OverTimeCB);

            if (InstantCB.Checked)
            {
                EnableElements("Lasts", false);
            }
            else
            {
                EnableElements("Lasts", true);
            }
        }

        private void OverTimeCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(OverTimeCB, InstantCB);

            if(OverTimeCB.Checked)
            {
                EnableElements("Lasts", true);
            }
            else
            {
                EnableElements("Lasts", false);
            } 
        }

        private void SeparateCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(SeparateCB, DerivedCB);

            if (SeparateCB.Checked)
            {
                EnableElements("Derivable", false);
            }
            else
            {
                EnableElements("Derivable", true);
            }
        }

        private void DerivedCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(DerivedCB, SeparateCB);

            if (DerivedCB.Checked)
            {
                EnableElements("Derivable", true);
            }
            else
            {
                EnableElements("Derivable", false);
            }
        }

        private void SingleTrgtCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(SingleTrgtCB, AOECB);
        }

        private void AOECB_CheckedChanged(object sender, EventArgs e)
        {
            CheckCB(AOECB, SingleTrgtCB);
        }     
    
    }
}
