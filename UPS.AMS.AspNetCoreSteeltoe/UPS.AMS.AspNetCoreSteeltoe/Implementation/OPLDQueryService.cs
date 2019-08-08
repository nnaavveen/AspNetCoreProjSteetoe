namespace UPS.AMS.AspNetCoreSteeltoe.Implementation
{
    #region Namespaces
    using System;
    using UPS.AMS.AspNetCoreSteeltoe.Interface;
    #endregion

    public class OPLDQueryService : IOPLDQueryService
    {
        public string GetOPLDPackageTrackingNumber()
        {
            return DateTime.Now+ "1Z300FF70340006640";
        }

        public string[] GetMultipleTrackingNumber(int count)
        {
            if (count == 1) {
                return new string[] { "1Z6028360364543274" };
            }
            else
            {
                return new string[] { "1Z6028360364543274", "1Z300FF70340006640" };
            }
        }
    }
}
