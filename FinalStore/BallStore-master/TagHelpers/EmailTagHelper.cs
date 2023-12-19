using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SongStore.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string EmailAddress { get; set; }
        public string LinkText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" +  EmailAddress);

            output.Content.SetContent(LinkText);
        }
    }
}
