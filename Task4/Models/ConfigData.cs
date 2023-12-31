﻿using Task4.Models.DTOs;

namespace Task4.Models
{
    public class ConfigData
    {
        private const string configDataPath = "ConfigData.json";

        private static ConfigDataDTO _configData = FileReaderUtils.GetData<ConfigDataDTO>(configDataPath);

        static ConfigData()
        {
            Timeout = _configData.Timeout;
        }

        public static int Timeout { get; } 
    }
}