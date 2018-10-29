using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Codehaks.TagHelpers
{
    public class StarsTagHelper : TagHelper
    {
        public StarsTagHelper()
        {
            Count = 5;
            ActiveClass = "fa fa-star";
            ActiveStyle = "color:#ffd800";

            DeActiveClass = "fa fa-star-o";
            DeActiveStyle = "";

        }
        public int Level { get; set; }

        public int Count { get; set; }

        public string ActiveClass { get; set; }
        public string ActiveStyle { get; set; }

        public string DeActiveClass { get; set; }
        public string DeActiveStyle { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            for (int i = 0; i < Count; i++)
            {
                if (i < Level)
                {
                    output.Content.AppendHtml("<i class='"+ ActiveClass+"' style='" + ActiveStyle + "'></i>");
                }
                else
                {
                    output.Content.AppendHtml("<i class='" +DeActiveClass + "' style='" + DeActiveStyle + "'></i>");
                }
            }
        }
    }
}
