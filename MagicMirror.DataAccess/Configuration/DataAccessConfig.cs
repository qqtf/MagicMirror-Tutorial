﻿namespace MagicMirror.DataAccess.Configuration
{
    public static class DataAccessConfig
    {
        public static string OpenWeatherMapApiId
        {
            get
            {
                return "14785d234ad5cf3a84fb674779edf62e";
            }
        }

        public static string OpenWeatherMapApiUrl
        {
            get
            {
                return "http://api.openweathermap.org/data/2.5";
            }
        }

        public static string GoogleMapsTrafficApiUrl
        {
            get
            {
                return "https://maps.googleapis.com/maps/api/distancematrix/json";
            }
        }

        public static string GoogleMapsTrafficApiId
        {
            get
            {
                return "AIzaSyBGoN7HTIWBLk6N9CqEqvJsV_KGFmwt8tw";
            }
        }

        public static string MapQuestApiUrl
        {
            get
            {
                return "http://open.mapquestapi.com/directions/v2/route";
            }
        }

        public static string MapQuestApiId
        {
            get
            {
                return "TIAP8yKgs5dGdT6ny1HsV19vt3YrrrGd";
            }
        }
    }
}