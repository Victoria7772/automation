using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class form : Component
    {
        public form()
        {
            InitializeComponent();
        }

        public form(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
