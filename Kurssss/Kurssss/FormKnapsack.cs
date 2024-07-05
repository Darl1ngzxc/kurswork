using CourseWork;
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
    private KnapsackVisualization knapsackVisualization;
    private int currentStateStep = 0;
    private bool isSolved = false;

    private void CreateKnapsackManager(int capacity)
    {
        
        KnapsackParameters parameters = new KnapsackParameters(capacity);
        knapsackManager = new Manager(parameters);
        Show(currentStateStep);

        buttonInformation.Enabled = true;
        buttonAddItem.Enabled = true;
        buttonSetCapacity.Enabled = true;
        textBoxCapacity.Text = knapsackManager.GetStorage().GetState(currentStateStep).Capacity.ToString();
    }

    public FormKnapsack()
    {
        InitializeComponent();
        knapsackVisualization = new KnapsackVisualization();
    }

    public void Show(int currentConditionIndex)
    {
        if (knapsackManager == null || pictureBox.Height == 0 || pictureBox.Width == 0)
        {
            return;
        }
        Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.FromArgb(150, 190, 255));
        Pen pen = new Pen(Color.Black);
        Brush brush = new SolidBrush(Color.Black);
        graphics.DrawLine(pen, 500, 0, 500, 1000);
        graphics.DrawString("Предметы на выбор", SystemFonts.DefaultFont, Brushes.Black, 15, 0);
        graphics.DrawString("Рюкзак", SystemFonts.DefaultFont, Brushes.Black, 515, 0);

        var condition = knapsackManager.GetStorage().GetState(currentConditionIndex);

        knapsackVisualization.DrawKnapsack(graphics, condition);


        pictureBox.Image = bitmap;
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
        form.AddEvent(knapsackManager.AddItem, RepaintState);
        buttonSetCapacity.Enabled = false;
        buttonSolve.Enabled = true;
        buttonStepBack.Enabled = true;
    }

    private void buttonInformation_Click(object sender, EventArgs e)
    {
        FormInformation form = new FormInformation();
        form.Show();
    }

    private void RepaintState(EnumOperations enumOperations)
    {
        currentStateStep++;
        Show(currentStateStep);
        textBoxStep.Text = currentStateStep.ToString();
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
    }

    private void buttonSolve_Click(object sender, EventArgs e)
    {
        knapsackManager.ResultSolve(currentStateStep);
        currentStateStep = knapsackManager.GetStorage().GetStorageLenght() - 1;
        Show(currentStateStep);
        buttonStepBack.Enabled = true;
        buttonAddItem.Enabled = false;
        isSolved = true;
        buttonSolve.Enabled = false;
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
    }

    private void buttonStepNext_Click(object sender, EventArgs e)
    {
        currentStateStep++;
        Show(currentStateStep);
        if (currentStateStep == knapsackManager.GetStorage().GetStorageLenght() - 1)
        {
            buttonStepNext.Enabled = false;
            if (isSolved ==  false)
            {
                buttonSolve.Enabled = true;
            }
        }
        
        buttonStepBack.Enabled = true;
        textBoxStep.Text = currentStateStep.ToString();
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
    }

    private void buttonStepBack_Click(object sender, EventArgs e)
    {
        currentStateStep--;
        Show(currentStateStep);
        buttonSolve.Enabled = false;
        buttonAddItem.Enabled = false;
        buttonStepNext.Enabled = true;
        if (currentStateStep == 0)
        {
            buttonStepBack.Enabled = false;
        }
        textBoxStep.Text = currentStateStep.ToString();
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
    }
}
