using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifenetrage.Helper
{
    public class WindowsAccessHelper
    {
        //Importer un DDL speciale
        // [] s'appelle une Annotation 
        [STAThread]
        [System.Runtime.InteropServices.DllImport("advapi32.dll")]


        public static extern bool LogonUser(string userName, string domainName,
            string password, int LogonType,
            int LogonProvider, ref IntPtr phToken);


        /* fournit par Microsoft  et permet de verifier si un compte utilisateur 
        et le mot de passe sont valides ou pas */

        public static bool IsValidateCredentials(string userName, string password, string domain)
        {
            bool isValid = false;
            // utilise un code managé => pas de pointeur 
            IntPtr tokenHandler = IntPtr.Zero;

            isValid = LogonUser(userName, domain, password, 2, 0, ref tokenHandler);

            return isValid;


            // On va créer un compte windows local pour tester la fonctionnalité

        }


    }
}
