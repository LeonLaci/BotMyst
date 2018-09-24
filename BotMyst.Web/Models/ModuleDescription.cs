using System.Collections.Generic;

namespace BotMyst.Web.Models
{
    public class ModuleDescription
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<CommandDescription> CommandDescriptions { get; set; }
    }
}