using MyCrmManager.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrmManager.WinFormUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            using(var unitOfWork = new UnitOfWork(new CrmContext()))
            {
               var x=unitOfWork.Employees.Get(1);
               
            }
        }
    }
}
