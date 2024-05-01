using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
    }

    private async void CallApi_Click(object sender, EventArgs e)
    {
        ResultsStatusLabel.Text = "Calling API";
        ResultsJson.Text = "";
        //Validate the API URL
        if (api.IsValidUrl(ApiText.Text) == false)
        {
            ResultsStatusLabel.Text = "Invalid URL";
            return;
        }

        try
        {
            
            //API Call
            ResultsJson.Text = await api.CallApiAsync(ApiText.Text);

            StatusResults.Text = "Ready";
        }
        catch (Exception ex)
        {
            ResultsJson.Text = "Error" + ex.Message;
            ResultsStatusLabel.Text = "Error";
        }
    }
}
