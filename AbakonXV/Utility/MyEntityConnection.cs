namespace AbakonXVWPF.Utility
{
    public class MyEntityConnection
    {

        string _serverName;
        public string ServerName
        {
            get { return _serverName; }
            set { _serverName = value; }
        }

        string _databaseName;
        public string DatabaseName
        {
            get { return _databaseName; }
            set { _databaseName = value; }
        }

        bool _DbAuth;
        public bool DbAuth
        {
            get { return _DbAuth; }
            set { _DbAuth = value; }
        }

        string _User;
        public string User
        {
            get { return _User; }
            set { _User = value; }
        }

        string _PSW;
        public string PSW
        {
            get { return _PSW; }
            set { _PSW = value; }
        }

        bool _ConnectionOK;
        public bool ConnectionOK
        {
            get { return _ConnectionOK; }
            set { _ConnectionOK = value; }
        }

        private static MyEntityConnection _instance;
        public static MyEntityConnection GetMyEntityConnection()
        {
            if (_instance == null)
            {
                _instance = new MyEntityConnection();
                //   _instance.Database.Log = Console.Write; 
            }
            return _instance;
        }

        private MyEntityConnection()
        {
            _instance = this;
            LoadParameters();
            if (_serverName == "Undefined" || _databaseName == "Undefined")
            {
                DataBaseConnectionWindow dbConn = new DataBaseConnectionWindow();
                dbConn.ShowDialog();
            }
            ConnectionOK = AbakonDataModel.ConnectionString.TestConnection();
        }

        public void SaveParameters()
        {
            
            AbakonXVWPF.Properties.Settings.Default._DB_server = _serverName;
            AbakonXVWPF.Properties.Settings.Default._DB_Name = _databaseName;
            AbakonXVWPF.Properties.Settings.Default._DB_Authetification = !_DbAuth;
            if (_DbAuth)
            {
                AbakonXVWPF.Properties.Settings.Default._DB_user = string.Empty;
            }
            else
            {
                AbakonXVWPF.Properties.Settings.Default._DB_user = _User;
            }

            if (_PSW == string.Empty || _PSW == null)
            {
                AbakonXVWPF.Properties.Settings.Default._DB_psw = string.Empty;
            }
            else
            {
                AbakonXVWPF.Properties.Settings.Default._DB_psw = AbakonXVWPF.Utility.RijndaelCrypto.EncryptString(_PSW);
            }
            AbakonXVWPF.Properties.Settings.Default.Save();
        }

        private void LoadParameters()
        {
            _serverName = AbakonXVWPF.Properties.Settings.Default._DB_server;
            _databaseName = AbakonXVWPF.Properties.Settings.Default._DB_Name;
            _DbAuth = !AbakonXVWPF.Properties.Settings.Default._DB_Authetification;
            _User = AbakonXVWPF.Properties.Settings.Default._DB_user;

            if (_serverName == "Undefined" || _databaseName == "Undefined")
            {
                DataBaseConnectionWindow dbConn = new DataBaseConnectionWindow();
                dbConn.ShowDialog();
            }
            else
            {
                if (AbakonXVWPF.Properties.Settings.Default._DB_psw == string.Empty)
                {
                    _PSW = string.Empty;
                }
                else
                {
                    _PSW = AbakonXVWPF.Utility.RijndaelCrypto.DecryptString(AbakonXVWPF.Properties.Settings.Default._DB_psw);
                }
                AbakonDataModel.ConnectionString.CreateConnectionString(_serverName, _databaseName, _DbAuth, _User, _PSW);
            }

        }
      //  public EntityConnection Connection { get; set; }
        public string SQLStringConnection { get; private set; }

    }
}
