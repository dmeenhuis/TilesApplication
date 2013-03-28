using System.Collections.Generic;

namespace TilesApplication.Domain
{
    public class LiveTile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public IList<KeyValuePair<string, string>> Attributes { get; set; }
        public IList<string> ContentSections { get; set; }
        public IList<string> CssClasses { get; set; }
        public IList<TileGroup> Groups { get; set; }

        public LiveTile()
        {
            Attributes = new List<KeyValuePair<string, string>>();
            ContentSections = new List<string>();
            CssClasses = new List<string>();
        }
    }
}
