﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdWindows;
using Telegram.Api.Services;
using Telegram.Api.TL;
using Unigram.Services;

namespace Unigram.ViewModels.Settings.Privacy
{
    public class SettingsPrivacyAllowChatInvitesViewModel : SettingsPrivacyViewModelBase
    {
        public SettingsPrivacyAllowChatInvitesViewModel(IProtoService protoService, ICacheService cacheService, IEventAggregator aggregator)
            : base(protoService, cacheService, aggregator, new UserPrivacySettingAllowChatInvites())
        {
        }
    }
}
