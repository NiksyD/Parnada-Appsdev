using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parnada_Appsdev.Controller.SubjectPreqControls
{
    public partial class SubjectPreqEdit : UserControl
    {
        private string subjCode;
        private string subjPreCode;
        private string subjCategory;

        public SubjectPreqEdit(string subjCode, string subjPreCode, string subjCategory)
        {
            InitializeComponent();
            this.subjCode = subjCode;
            this.subjPreCode = subjPreCode;
            this.subjCategory = subjCategory;
        }
    }
}
