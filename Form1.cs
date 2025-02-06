using System.Windows.Forms;

namespace deep
{
    public partial class deepForm : Form
    {
        public deepForm()
        {
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            await deepBrowser.EnsureCoreWebView2Async(null);
            deepBrowser.CoreWebView2.Navigate("https://chat.deepseek.com");
        }
    }
}
