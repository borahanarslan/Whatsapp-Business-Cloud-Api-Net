﻿using Newtonsoft.Json;

namespace WhatsappBusiness.CloudApi.Requests
{
    public class ImageMessageByUrlRequest
    {
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; private set; } = "whatsapp";

        [JsonProperty("recipient_type")]
        public string RecipientType { get; private set; } = "individual";

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; private set; } = "image";

        [JsonProperty("image")]
        public MediaImageUrl Image { get; set; }
    }

    public class MediaImageUrl
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
