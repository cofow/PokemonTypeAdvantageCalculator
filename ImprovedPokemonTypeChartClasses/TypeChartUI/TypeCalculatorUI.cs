using ImprovedPokemonTypeChart;

namespace TypeChartUI;

public partial class TypeCalculatorUI : Form
{

    public TypeCalculatorUI()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // add an option to select no secondary type to the top of the list
        SecondaryTypesComboBox.Items.Add("None");

        // populate combo boxes with pokemon types
        foreach (var pokemon in Enum.GetNames<PokemonData.PokemonTypes>())
        {
            PrimaryTypesComboBox.Items.Add(pokemon);
            SecondaryTypesComboBox.Items.Add(pokemon);
        }
    }

    private bool ValidateComboBoxes()
    {
        // TODO - in the future I'd like to create a class to the class library which handles validation
        // the idea is that id be able to pass in the text values to this class and valid it there so that in the future if i add more combo boxes it can handle a varying
        // number of combo boxes. rough ideas would be having a method that takes a list of classes which is populated in this method and sent.
        // that method would then read the list and do its checks based on the length of the list.

        // checks to see if the comboboxes are populated with a value
        if (PrimaryTypesComboBox.SelectedIndex < 0)
        {
            MessageBox.Show("Error: Please enter a valid primary type.");
            return false;
        }

        if (SecondaryTypesComboBox.SelectedIndex < 0)
        {
            MessageBox.Show("Error: Please enter a valid secondary type or select \"None\"");
            return false;
        }

        if (PrimaryTypesComboBox.Text == SecondaryTypesComboBox.Text)
        {
            MessageBox.Show("Error: You can't enter the same type twice. To enter a single type, select \"None\" for the second type");
            return false;
        }

        return true;
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        // validate input
        if (ValidateComboBoxes() == false)
        {
            return;
        }

        // create data and calc objects
        PokemonData data = new();
        TypeCalculations calc = new();

        // create temp arrays to hold the data to pass to the displayinfo method
        double[] newArr1 = calc.GetStrengthsAndWeaknesses(data.PrimaryTypeArray, PrimaryTypesComboBox.Text);
        double[] newArr2 = calc.GetStrengthsAndWeaknesses(data.SecondaryTypeArray, SecondaryTypesComboBox.Text);

        // create the displayTypeInfo object
        DisplayTypeInfo display = new();

        // pass the list returned from the DisplayInfo method to populate the text box
        PopulateTextBox(display.DisplayInfo(newArr1, newArr2));
    }

    /// <summary>
    /// Add strings from the list returned from DisplayInfo to the textbox
    /// </summary>
    /// <param name="data"></param>
    private void PopulateTextBox(List<string> data)
    {
        // TODO - challange: Change the font color in the text box for strengths and weaknesses
        foreach (var item in data)
        {
            StrengthsAndWeaknessesRichTextBox.Text += item;
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        PrimaryTypesComboBox.Text = "Select Primary Type:";
        SecondaryTypesComboBox.Text = "Select Secondary Type:";
    }
}