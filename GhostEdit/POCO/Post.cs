using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GhostEdit
{
    public partial class Post
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("mobiledoc")]
        public string Mobiledoc { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("feature_image")]
        public Uri FeatureImage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("custom_excerpt")]
        public string CustomExcerpt { get; set; }

        [JsonProperty("canonical_url")]
        public string CanonicalUrl { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("authors")]
        public string[] Authors { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("og_image")]
        public string OgImage { get; set; }

        [JsonProperty("og_title")]
        public string OgTitle { get; set; }

        [JsonProperty("og_description")]
        public string OgDescription { get; set; }

        [JsonProperty("twitter_image")]
        public string TwitterImage { get; set; }

        [JsonProperty("twitter_title")]
        public string TwitterTitle { get; set; }

        [JsonProperty("twitter_description")]
        public string TwitterDescription { get; set; }

        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }
    }
}
