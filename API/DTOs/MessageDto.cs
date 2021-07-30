﻿using System;
using System.Text.Json.Serialization;

namespace API.DTOs
{
    public class MessageDto
    {
        #region Properties
        public int Id { get; set; }

        public int SourceId { get; set; }

        public string SenderUsername { get; set; }

        public string SenderPhotoUrl { get; set; }

        public int RecipientId { get; set; }

        public string RecipientUsername { get; set; }

        public string RecipientPhotoUrl { get; set; }

        public string Content { get; set; }

        public DateTime? DateRead { get; set; }

        public DateTime? MessageSent { get; set; }

        [JsonIgnore]
        public bool SenderDeleted { get; set; }

        [JsonIgnore]
        public bool RecipientDeleted { get; set; }
        #endregion
    }
}
