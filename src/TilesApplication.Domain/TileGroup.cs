using System.Collections.Generic;

namespace TilesApplication.Domain
{
    public class TileGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IList<LiveTile> Tiles { get; set; }
    }
}