using MKH.Library.Clasess.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace MKH.Permission.ViewModel.Security
{
    public class MSSPolicySystem_cls
    {
        #region Constructors
        public MSSPolicySystem_cls()
        {
            //UsersDT = new Model.UserEntities();
        }
        #endregion
        #region Member Variables
        public enum PasswordStrongly { Blank = 0, VeryWeak = 1, Weak = 2, Medium = 3, Strong = 4, VeryStrong = 5 };
        #endregion
        #region Properties
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string EncryptPassword { get; set; }
        public string UserLogin { get; set; }
        public int MinimumPasswordLength { get; set; }
        public bool PasswordMustComplexity { get; set; }

        public int MaximumPasswordAge { get; set; }
        public int MinimumPasswordAge { get; set; }
        public bool ChangePasswordAtNextLogon { get; set; }
        public bool UserCanNotChangePassword { get; set; }
        //public MKH.Permission.Model.UserEntities UsersDT { get; set; }
        #endregion
        #region Methods

        public string CheckAuthentication(string userLogin, string password, int SoftwareId, ref bool UserOrPass)
        {

            if (userLogin.Trim().Equals("") && password.Trim().Equals("") && 
                new ViewModel.Users.Users().CountList() == 0)
            {
                string str = ""; int? idSet = 0;
                byte[] b = null;
                List<MKH.Permission.Model.Users.TBL_User> Ls = new List<MKH.Permission.Model.Users.TBL_User>(1);
                MKH.Permission.Model.Users.TBL_User Users = new MKH.Permission.Model.Users.TBL_User();
                Users.UserPic = b;
                Users.Name = "Admin";
                Users.Family = "";
                Users.NationalCode = "";
                Users.TelNo = "";
                Users.MobileNo = "";
                Users.BirthDate = "1380/01/01";

                Users.UserName = "Admin";
                Users.Description = "";


                Users.DateActive = new System.Globalization.PersianCalendar().GetYear(DateTime.Now).ToString("0000") + "/" + new System.Globalization.PersianCalendar().GetMonth(DateTime.Now).ToString("00") + "/" + new System.Globalization.PersianCalendar().GetDayOfMonth(DateTime.Now).ToString("00");
                Users.DateInActive = (new System.Globalization.PersianCalendar().GetYear(DateTime.Now)+1).ToString("0000") + "/" + new System.Globalization.PersianCalendar().GetMonth(DateTime.Now).ToString("00") + "/" + new System.Globalization.PersianCalendar().GetDayOfMonth(DateTime.Now).ToString("00");
                
                Users.IsActive = true;
                Users.IsAdmin = true;


                Ls.Add(Users);

               new ViewModel.Users.Users().InsertEntity(Ls, ref str, ref idSet);
               userLogin = "Admin";
               password = "1";

            }


            string ret = "";
            if (userLogin.Trim().Equals(""))
            {
                UserOrPass = true;
                return "نام كاربر خالي مي باشد...";
            }
            if (password.Trim().Equals(""))
            {
                UserOrPass = false;
                return "رمز عبور خالي مي باشد...";
            }

            ret = new MainClass_cls().UserPasswordIsOkay(userLogin, password, ref UserOrPass);
            if (ret.Length == 0)
            {
                if (new MainClass_cls().GetAccessibleResourceIds(userLogin, SoftwareId))
                {
                    Security.MSSConfiguration_cls.Instance.USER = userLogin;
                    Security.MSSConfiguration_cls.Instance.PASSWORD = password;
                    Security.MSSConfiguration_cls.Instance.SoftwareId = SoftwareId;

                    Security.MSSConfiguration_cls.Instance.IsAdmin = new ViewModel.Users.Users().GetAllListByLogin(userLogin, ref ret).Single().IsAdmin ?? false;
                    Security.MSSConfiguration_cls.Instance.USERID = new ViewModel.Users.Users().GetAllListByLogin(userLogin, ref ret).Single().Id;

                    MKH.Library.Clasess.PublicParam.UserLoginCode = userLogin;
                    MKH.Library.Clasess.PublicParam.UserLoginName = new ViewModel.Users.Users().GetAllListByLogin(userLogin, ref ret).Single().Name + " " + new ViewModel.Users.Users().GetAllListByLogin(userLogin, ref ret).Single().Family;

                    //Model.Logmanagement.TBL_Login Login = new Model.Logmanagement.TBL_Login()
                    //{
                    //    DomainName = new MSSConfigHelp().DomainName,
                    //    ComputerName = new MSSConfigHelp().ComputerName,
                    //    UserName = userLogin,
                    //    UserProfile = new MSSConfigHelp().CurrentWinUserName,
                    //    LogDate = DateTime.Now,
                    //    SoftwareId = SoftwareId
                    //};
                    //List<Model.Logmanagement.TBL_Login> A = new List<Model.Logmanagement.TBL_Login>();
                    //A.Add(Login);
                    //new MKH.Permission.ViewModel.Logmangement.Login().InsertLogin(A, ref ret);
                        
                }
                else
                    ret = "کاربر مجاز به استفاده از این نرم افزار نمی باشد...";
            }
            return ret;

        }

        public bool GetAccessibleResourceIds(string userLogin)
        {
            return new MainClass_cls().GetAccessibleResourceIds(userLogin, Security.MSSConfiguration_cls.Instance.SoftwareId);
        }
        
        private bool ComplexityPasswordIsOk()
        {
            bool retVal = false;
            PasswordStrongly passStrong = CheckStrength(Password);
            if (passStrong == PasswordStrongly.Strong || passStrong == PasswordStrongly.VeryStrong)
                retVal = true;
            return retVal;
        }

        private PasswordStrongly CheckStrength(string password)
        {
            int score = 1;
            if (password.Length < 1)
                return PasswordStrongly.Blank;
            if (password.Length < 4)
                return PasswordStrongly.VeryWeak;

            if (password.Length >= 4)
            {
                int countDigit = 0;
                int countUpperLetter = 0;
                int countLowerLetter = 0;
                int countOthers = 0;
                foreach (char c in password)
                {
                    countDigit += Char.IsDigit(c) ? 1 : 0;
                    countUpperLetter += Char.IsUpper(c) ? 1 : 0;
                    countLowerLetter += Char.IsLower(c) ? 1 : 0;
                    //if (Regex.IsMatch(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript))
                    //  countOthers++;
                    countOthers += !(Char.IsDigit(c) || Char.IsLetter(c)) ? 1 : 0;
                }

                if (countDigit > 0)
                    score++;
                if (countUpperLetter > 0 && countLowerLetter > 0)
                    score++;
                if (countOthers > 0)
                    score++;
                if (countOthers > 2)
                    score++;
                // OR
                //if (Regex.IsMatch(password, @"/\d+/", RegexOptions.ECMAScript))
                //  score++;

                //if (Regex.IsMatch(password, @"/[a-z]/", RegexOptions.ECMAScript)
                // && Regex.IsMatch(password, @"/[A-Z]/", RegexOptions.ECMAScript))
                //  score++;
            }
            return (PasswordStrongly)score;
        }

        #endregion
      
     }
}
