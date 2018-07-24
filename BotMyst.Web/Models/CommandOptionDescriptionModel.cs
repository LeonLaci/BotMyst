using System.Reflection;

namespace BotMyst.Web.Models
{
    public class CommandOptionDescriptionModel
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public string OptionType { get; set; }
        public object Value { get; set; }
    }
}