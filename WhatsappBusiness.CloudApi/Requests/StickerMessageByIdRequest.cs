﻿using Newtonsoft.Json;

namespace WhatsappBusiness.CloudApi.Requests
{
    public class StickerMessageByIdRequest
    {
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; private set; } = "whatsapp";

        [JsonProperty("recipient_type")]
        public string RecipientType { get; private set; } = "individual";

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; private set; } = "sticker";

        [JsonProperty("sticker")]
        public MediaSticker Sticker { get; set; }
    }

    public class MediaSticker
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
