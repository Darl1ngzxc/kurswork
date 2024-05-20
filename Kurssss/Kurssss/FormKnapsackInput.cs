namespace Kurssss;

public partial class FormKnapsackInput : System.Windows.Forms.Form
{
    private event Action<int>? _setSizeDelegate;
    private event Action<string, int, int>? _addItemDelegate;
    private Action<EnumOperations>? _afterActionCallback;
    public FormKnapsackInput(EnumOperations actiontype)
    {
        InitializeComponent();
        switch (actiontype)
        {
            case EnumOperations.AddItem:
                buttonAddItem.Enabled = true;
                maskedTextBoxInputValue.Enabled = true;
                maskedTextBoxInputWeight.Enabled = true;
                textBoxInputName.Enabled = true;
                break;
            case EnumOperations.SetCapacity:
                buttonInputCapacity.Enabled = true;
                maskedTextBoxInputCapacity.Enabled = true;
                break;
            default:
                throw new ArgumentException();
        }
    }

    public void AddEvent(Action<int> setSizeDelegate)
    {
        _setSizeDelegate += setSizeDelegate;
    }

    public void AddEvent(Action<string, int, int> addItemDelegate)
    {
        _addItemDelegate += addItemDelegate;
    }

   

    private void buttonInputCapacity_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(maskedTextBoxInputCapacity.Text))
            {
                throw new Exception("������� ������ ������������");
            }
            int capacity = Convert.ToInt32(maskedTextBoxInputCapacity.Text);
            _setSizeDelegate?.Invoke(capacity);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("������� ������������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAddItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(textBoxInputName.Text) || string.IsNullOrEmpty(maskedTextBoxInputWeight.Text) || string.IsNullOrEmpty(maskedTextBoxInputValue.Text))
            {
                throw new Exception("������� ������ �����������");
            }
            string name = textBoxInputName.Text;
            int weight = Convert.ToInt32(maskedTextBoxInputWeight.Text);
            int value = Convert.ToInt32(maskedTextBoxInputValue.Text);
            _addItemDelegate?.Invoke(name, weight, value);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("������� ��� ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}