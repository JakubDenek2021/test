using iMedicalMVC.DAO;
using iMedicalMVC.Helpers;
using iMedicalMVC.Interface;
using iMedicalMVC.ViewModel.Login;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iMedicalMVC.Enum;
using iMedicalMVC.Helpers;

namespace iMedicalMVC.Fascade
{
    public class LoginService
    {
        public int CheckedLogin<T>(T viewmodel) where T : ILogin, IPassword
        {
            var dao = new LoginDao();

            bool isCorrectPassword = dao.CheckPassword(viewmodel.Login, SHAHelper.GenerateSHA512(viewmodel.Password));

            if (isCorrectPassword)
            {
                int idLogin = dao.GetLoginId(viewmodel.Login);

                return idLogin;
            }
            else
            {
               
                throw new Exception("Błędne dane logowania");

            }
        }


        public string GetLogin(int idLogin)
        {
            return new LoginDao().GetLogin(idLogin);
        }

        public UserType GetUserType(int idLogin)
        {
            try
            {
                var dao = new LoginDao();
                var employeeTypeId = dao.GetEmployeeType(idLogin);
                if (employeeTypeId == null)
                {
                    if (dao.GetIdClient(idLogin) == 0)
                    {
                        throw new Exception("Błąd podczas pobierania roli w systemie");
                    }
                    else
                    {
                        return UserType.Patient;
                    }

                }
                else
                {
                    return (UserType)employeeTypeId;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Błąd podczas pobierania roli w systemie");
            }
        }

        internal void ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            CheckedLogin(changePasswordViewModel);
            new LoginDao().ChangePassword(changePasswordViewModel.Login, SHAHelper.GenerateSHA512(changePasswordViewModel.Password));
        }

        internal void ValidateChangePassword(ChangePasswordViewModel model)
        {
            var password = model.Password;
            var replayPassword = model.ReplayNewPassword;

            if (string.Compare(password, replayPassword) != 0)
            {
                throw new Exception("Walidacja sie nie udala");
            }
        }

    }
}
