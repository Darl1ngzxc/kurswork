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
    private Manager knapsackManager;

    private void CreateKnapsackManager(int capacity)
    {
        KnapsackParameters parameters = new KnapsackParameters(capacity);
        knapsackManager = new Manager(parameters);

        button1.Enabled = true;
        buttonAddItem.Enabled = true;
        buttonSetCapacity.Enabled = true;
    }

    public FormKnapsack()
    {
        InitializeComponent();
    }



    private void buttonSetCapacity_Click(object sender, EventArgs e)
    {
        FormKnapsackInput form = new FormKnapsackInput(EnumOperations.SetCapacity);
        form.Show();
        form.AddEvent(CreateKnapsackManager);

    }





    private void buttonAddItem_Click(object sender, EventArgs e)
    {
        FormKnapsackInput form = new FormKnapsackInput(EnumOperations.AddItem);
        form.Show();
        form.AddEvent(knapsackManager.AddItem);
    }
}
