using System;

namespace BikeSharing.Clients.Core
{
    public static class GlobalSettings
    {
        public const string AuthenticationEndpoint = "http://bikesharing-services-profilesg2m7lgvod5pme.azurewebsites.net";
        public const string EventsEndpoint = "http://bikesharing-services-eventsg2m7lgvod5pme.azurewebsites.net/";
        public const string IssuesEndpoint = "http://bikesharing-services-feedbackg2m7lgvod5pme.azurewebsites.net";
        public const string RidesEndpoint = "http://bikesharing-services-ridesg2m7lgvod5pme.azurewebsites.net";

        public const string OpenWeatherMapAPIKey = "f90487349bfa6f5a954fa964f2737b0f";

        public const string HockeyAppAPIKeyForAndroid = "YOUR_HOCKEY_APP_ID";
        public const string HockeyAppAPIKeyForiOS = "YOUR_HOCKEY_APP_ID";

        public const string SkypeBotAccount = "skype:YOUR_BOT_ID?chat";

        public const string BingMapsAPIKey = "ArDvHkD19Q8zMT15x0CeQXLaOzCUcqlzf30qc5PGpSB_w1m9Pm6QTDb9Cr_VQywy";


        public static string City => "Redmond";

        public static int TenantId = 1;

        public static DateTime EventDate = new DateTime(2017, 03, 07);
        public static float EventLatitude = 47.673988f;
        public static float EventLongitude = -122.121513f;
    }
}
