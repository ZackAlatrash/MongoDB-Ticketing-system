namespace Forms_UI
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            // Check if the application was opened with the reset token link
            if (args.Length > 0)
            {
                try
                {
                    // Parse the URL to extract the token
                    string url = args[0];
                    var uri = new Uri(url);
                    var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
                    string token = query.Get("token");  // Extract the token from the query string

                    // Open the ResetPasswordForm and pass the token
                    Application.Run(new ResetPasswordForm(token));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing URL: {ex.Message}");
                    Application.Run(new LoginForm()); // Fallback to LoginForm
                }
            }
            else
            {
                Application.Run(new LoginForm());
            }
            Application.Run(new MainForm());
        }
    }
}
