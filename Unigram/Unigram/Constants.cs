﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unigram
{
    public static class Constants
    {
        public const int TypingTimeout = 300;

        public static readonly string[] MediaTypes = new[] { ".jpg", ".jpeg", ".png", ".gif", ".mp4" };
        public static readonly string[] PhotoTypes = new[] { ".jpg", ".jpeg", ".png", ".gif" };

        public const string WallpaperFileName = "wallpaper.jpg";

        public const string HockeyAppId = "7d36a4260af54125bbf6db407911ed3b"; // "e5a0f6f85ab944ebbc1650fa22b8ac44"; // "7d36a4260af54125bbf6db407911ed3b";

        public static readonly string[] TelegramHosts = new string[]
        {
            "telegram.me",
            "telegram.dog",
            "t.me",
            /*"telesco.pe"*/
        };
    }
}
