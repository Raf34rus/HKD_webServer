using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKD_WebServer.DataManager
{
    public class Consts
    {

        /// Разделители
        public static readonly string[] SeparatorN = { "\n" };
        public static readonly string[] SeparatorRN = { "\r\n" };
        public static readonly char[] UserInputTrim = { '\n', ' ' };

        #region AccessRole
        /// Роли админа
        public const string AdminRole = "store_administrator";
        public const string ADAdminRole = "hkd_admins";
        public const string AdminRoles = "store_administrator,hkd_admins";
        /// Роли юриста
        public const string LawyerRole = "lawyer";
        public const string ADLawyerRole = "hkd_lawer";
        /// Роли ОСОП
        public const string OsopRole = "osop";
        public const string ADOsopRole = "hkd_osop";
        /// Роли юриста и админа
        public const string UserManager = "user_manager";
        public const string Clerk = "clerk";
        public const string ADClerk = "hkd_clerk";
        public const string ADCollector = "hkd_collector";
        public const string LaweyrRoles = LawyerRole + "," + AdminRole + "," + Clerk + "," + ADLawyerRole + "," + ADAdminRole + "," + ADClerk;
        #endregion
    }
}
