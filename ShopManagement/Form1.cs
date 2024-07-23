using System.Reflection;
using System.Linq;

namespace ShopManagement
{

    public partial class Form1 : Form
    {
        

        private Models.DatabaseContext DatabaseContext { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseContext = null;
            try
            {
                DatabaseContext = new Models.DatabaseContext();
                UsernameTB.Text = "admin";
                PasswordTB.Text = "123";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Form1 : " + ex.Message);
            }
            finally
            {
                if (DatabaseContext != null)
                {
                    DatabaseContext.Dispose();
                    DatabaseContext = null;
                }
            }

        }

        public bool UserIsValid(string tempUs, string tempPs)
        {

            //string tempUs = AppState.Instance.Username;
            //string tempPs = AppState.Instance.Username;

            DatabaseContext = new Models.DatabaseContext();

            var Users = DatabaseContext.Users
                    .Where(current => current.UserName == tempUs && current.Password == tempPs)
                    .ToList();

            if (Users == null || Users.Count == 0)
            {
                //AppState.Instance.Username = String.Empty;
                //AppState.Instance.Password = String.Empty;
                AppState.Instance.IsLogin = false;
                return false;
            }

            AppState.Instance.Username = tempUs;
            AppState.Instance.Password = tempPs;
            AppState.Instance.IsLogin = true;
            return true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;

            if (username.Trim() != string.Empty || password.Trim() != string.Empty) 
            {
                //AppState.Instance.Username = username;
                //AppState.Instance.Password = password;

                if (UserIsValid(username, password))
                {
                    this.Hide();

                    Form2 form2 = new Form2();
                    form2.Show();

                }
                else
                {
                    UsernameTB.Text = string.Empty;
                    PasswordTB.Text = string.Empty;
                    MessageBox.Show("[ UserNotFound ] try again ");
                }
                
            }
            else
            {
                MessageBox.Show("username and password are empty");
            }

        }

    }
    public class AppState
    {
        private static AppState _instance;
        private static readonly object _lock = new object();

        private AppState() { }

        public static AppState Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppState();
                    }
                    return _instance;
                }
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsLogin { get; set; }
    }
}
