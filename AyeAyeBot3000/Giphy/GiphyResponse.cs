using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AyeAyeBot3000
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

    public class GiphyResponse
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
    public class DownsizedLarge
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedHeightSmallStill
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class Original
    {
        [JsonPropertyName("frames")]
        public string Frames { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedHeightDownsampled
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class DownsizedStill
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedHeightStill
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class DownsizedMedium
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class Downsized
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class PreviewWebp
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class OriginalMp4
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedHeightSmall
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedHeight
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class DownsizedSmall
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class Preview
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedWidthDownsampled
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedWidthSmallStill
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedWidthSmall
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class OriginalStill
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class FixedWidthStill
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class Looping
    {
        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }
    }

    public class FixedWidth
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class PreviewGif
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }

    public class _480wStill
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }
    }

    public class Images
    {
        [JsonPropertyName("downsized_large")]
        public DownsizedLarge DownsizedLarge { get; set; }

        [JsonPropertyName("fixed_height_small_still")]
        public FixedHeightSmallStill FixedHeightSmallStill { get; set; }

        [JsonPropertyName("original")]
        public Original Original { get; set; }

        [JsonPropertyName("fixed_height_downsampled")]
        public FixedHeightDownsampled FixedHeightDownsampled { get; set; }

        [JsonPropertyName("downsized_still")]
        public DownsizedStill DownsizedStill { get; set; }

        [JsonPropertyName("fixed_height_still")]
        public FixedHeightStill FixedHeightStill { get; set; }

        [JsonPropertyName("downsized_medium")]
        public DownsizedMedium DownsizedMedium { get; set; }

        [JsonPropertyName("downsized")]
        public Downsized Downsized { get; set; }

        [JsonPropertyName("preview_webp")]
        public PreviewWebp PreviewWebp { get; set; }

        [JsonPropertyName("original_mp4")]
        public OriginalMp4 OriginalMp4 { get; set; }

        [JsonPropertyName("fixed_height_small")]
        public FixedHeightSmall FixedHeightSmall { get; set; }

        [JsonPropertyName("fixed_height")]
        public FixedHeight FixedHeight { get; set; }

        [JsonPropertyName("downsized_small")]
        public DownsizedSmall DownsizedSmall { get; set; }

        [JsonPropertyName("preview")]
        public Preview Preview { get; set; }

        [JsonPropertyName("fixed_width_downsampled")]
        public FixedWidthDownsampled FixedWidthDownsampled { get; set; }

        [JsonPropertyName("fixed_width_small_still")]
        public FixedWidthSmallStill FixedWidthSmallStill { get; set; }

        [JsonPropertyName("fixed_width_small")]
        public FixedWidthSmall FixedWidthSmall { get; set; }

        [JsonPropertyName("original_still")]
        public OriginalStill OriginalStill { get; set; }

        [JsonPropertyName("fixed_width_still")]
        public FixedWidthStill FixedWidthStill { get; set; }

        [JsonPropertyName("looping")]
        public Looping Looping { get; set; }

        [JsonPropertyName("fixed_width")]
        public FixedWidth FixedWidth { get; set; }

        [JsonPropertyName("preview_gif")]
        public PreviewGif PreviewGif { get; set; }

        [JsonPropertyName("480w_still")]
        public _480wStill _480wStill { get; set; }
    }

    public class User
    {
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("banner_image")]
        public string BannerImage { get; set; }

        [JsonPropertyName("banner_url")]
        public string BannerUrl { get; set; }

        [JsonPropertyName("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }

        [JsonPropertyName("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonPropertyName("instagram_url")]
        public string InstagramUrl { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("bitly_gif_url")]
        public string BitlyGifUrl { get; set; }

        [JsonPropertyName("bitly_url")]
        public string BitlyUrl { get; set; }

        [JsonPropertyName("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("content_url")]
        public string ContentUrl { get; set; }

        [JsonPropertyName("source_tld")]
        public string SourceTld { get; set; }

        [JsonPropertyName("source_post_url")]
        public string SourcePostUrl { get; set; }

        [JsonPropertyName("is_sticker")]
        public int IsSticker { get; set; }

        [JsonPropertyName("import_datetime")]
        public string ImportDatetime { get; set; }

        [JsonPropertyName("trending_datetime")]
        public string TrendingDatetime { get; set; }

        [JsonPropertyName("images")]
        public Images Images { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("image_original_url")]
        public string ImageOriginalUrl { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("image_mp4_url")]
        public string ImageMp4Url { get; set; }

        [JsonPropertyName("image_frames")]
        public string ImageFrames { get; set; }

        [JsonPropertyName("image_width")]
        public string ImageWidth { get; set; }

        [JsonPropertyName("image_height")]
        public string ImageHeight { get; set; }

        [JsonPropertyName("fixed_height_downsampled_url")]
        public string FixedHeightDownsampledUrl { get; set; }

        [JsonPropertyName("fixed_height_downsampled_width")]
        public string FixedHeightDownsampledWidth { get; set; }

        [JsonPropertyName("fixed_height_downsampled_height")]
        public string FixedHeightDownsampledHeight { get; set; }

        [JsonPropertyName("fixed_width_downsampled_url")]
        public string FixedWidthDownsampledUrl { get; set; }

        [JsonPropertyName("fixed_width_downsampled_width")]
        public string FixedWidthDownsampledWidth { get; set; }

        [JsonPropertyName("fixed_width_downsampled_height")]
        public string FixedWidthDownsampledHeight { get; set; }

        [JsonPropertyName("fixed_height_small_url")]
        public string FixedHeightSmallUrl { get; set; }

        [JsonPropertyName("fixed_height_small_still_url")]
        public string FixedHeightSmallStillUrl { get; set; }

        [JsonPropertyName("fixed_height_small_width")]
        public string FixedHeightSmallWidth { get; set; }

        [JsonPropertyName("fixed_height_small_height")]
        public string FixedHeightSmallHeight { get; set; }

        [JsonPropertyName("fixed_width_small_url")]
        public string FixedWidthSmallUrl { get; set; }

        [JsonPropertyName("fixed_width_small_still_url")]
        public string FixedWidthSmallStillUrl { get; set; }

        [JsonPropertyName("fixed_width_small_width")]
        public string FixedWidthSmallWidth { get; set; }

        [JsonPropertyName("fixed_width_small_height")]
        public string FixedWidthSmallHeight { get; set; }

        [JsonPropertyName("caption")]
        public string Caption { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        [JsonPropertyName("response_id")]
        public string ResponseId { get; set; }
    }



}
