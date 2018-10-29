using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Codehaks.TagHelpers
{
    public class StarsTagHelper : TagHelper
    {
        public StarsTagHelper()
        {
            Count = 5;
        }
        public int Level { get; set; }

        public int Count { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            for (int i = 0; i < Count; i++)
            {
                if (i < Level)
                {

                    output.Content.AppendHtml("<i class='fa fa-star' style='color:#ffd800'></i>");
                }
                else
                {
                    output.Content.AppendHtml("<i class='fa fa-star-o'></i>");
                }
            }
        }
    }
}
