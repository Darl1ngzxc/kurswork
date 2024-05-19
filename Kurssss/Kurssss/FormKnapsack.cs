using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Kurssss;

public partial class FormKnapsack : Form
{
    public FormKnapsack()
    {
        InitializeComponent();
    }

   
    
    private void buttonSetCapacity_Click(object sender, EventArgs e)
    {
        FormKnapsackInput form = new FormKnapsackInput();
        form.Show();
        form.AddEvent();
    }
}
