using Kontrol.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kontrol_Server_UI
{
    public class AuthorizationPrompter : ISecurityPrompter
    {
        public bool PropmptUserToAuthorizeMAC(string mac)
        {
            string sMessageBoxText = string.Format("A phone with MAC address {0} is trying to connect. Do you want to allow it?", mac);
            string sCaption = "Connection request";

            MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
            MessageBoxImage icnMessageBox = MessageBoxImage.Warning;

            MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    return true;

                case MessageBoxResult.No:
                    return false;

                case MessageBoxResult.Cancel:
                    return false;

                default:
                    return false;
            }
        }
    }
}