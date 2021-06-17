﻿using System;
using System.Text.Json.Serialization;

namespace Twitch.Net.EventSub.Notifications
{
    /**
     * "user_id": "1234",
     * "user_login": "cool_user",
     * "user_name": "Cool_User",
     * "broadcaster_user_id": "1337",
     * "broadcaster_user_login": "cooler_user",
     * "broadcaster_user_name": "Cooler_User",
     * "moderator_user_id": "1339",
     * "moderator_user_login": "mod_user",
     * "moderator_user_name": "Mod_User",
     * "reason": "Offensive language",
     * "ends_at": "2020-07-15T18:16:11.17106713Z",
     * "is_permanent": false
     */
    public class ChannelBanNotificationEvent
    {
        [JsonPropertyName("user_id")]
        public string UserIdString { get; init; }
        public int UserId => int.Parse(UserIdString);
        
        [JsonPropertyName("user_login")]
        public string UserLogin { get; init; }
        
        [JsonPropertyName("user_name")]
        public string UserName { get; init; }
        
        [JsonPropertyName("broadcaster_user_id")]
        public string BroadcasterIdString { get; init; }
        public int BroadcasterId => int.Parse(BroadcasterIdString);
        
        [JsonPropertyName("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; init; }
        
        [JsonPropertyName("broadcaster_user_name")]
        public string BroadcasterUserName { get; init; }
        
        [JsonPropertyName("moderator_user_id")]
        public string ModeratorUserIdString { get; init; }
        public int ModeratorUserId => int.Parse(ModeratorUserIdString);
        
        [JsonPropertyName("moderator_user_login")]
        public string ModeratorUserLogin { get; init; }
        
        [JsonPropertyName("moderator_user_name")]
        public string ModeratorUserName { get; init; }
        
        [JsonPropertyName("reason")]
        public string Reason { get; init; }
        
        [JsonPropertyName("ends_at")]
        public DateTime EndsAt { get; init; }
        
        [JsonPropertyName("is_permanent")]
        public bool IsPermanent { get; init; }

        public bool IsBan => IsPermanent;
        public bool IsTimeout => !IsPermanent;
    }
}