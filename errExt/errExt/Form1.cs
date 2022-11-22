namespace errExt
{
    public partial class ERRLOGS : Form
    {
        public ERRLOGS()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
            }
            lstNames.Items.Add(txtName.Text.SubstringAfter(": "));
            lstNames.Items.Add(txtName.Text.SubstringBetween("[", "]"));
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

    public static class LogAnalysis
    {
        public static string SubstringAfter(this string str, string lmt)
        {
            return str.Substring(str.IndexOf(lmt) + lmt.Length);
        }
        public static string SubstringBetween(this string str, string start, string end)
        {
            return str.Substring(str.IndexOf(start) + start.Length, str.IndexOf(end) - end.Length);
        }
        public static string Message(this string str)
        {
            return str.SubstringAfter(": ");
        }
        public static string LogLevel(this string str)
        {
            return str.SubstringBetween("[", "]");
        }
    }
}