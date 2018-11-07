using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCataloguing
{
    public partial class UserControlbooks : UserControl
    {
        private static UserControlbooks ins;
        public static UserControlbooks instance
        {
            get
            {
                if(ins == null)
                {
                    ins = new UserControlbooks();
                }
                return ins;
            }
        }
        public UserControlbooks()
        {
            InitializeComponent();
        }
    }
}
