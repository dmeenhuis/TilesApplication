using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TilesApplication.Domain;

namespace TilesApplication.Controllers
{
    public class TilesController : ApiController
    {
        public IEnumerable<TileGroup> Get(string groupId = null, string tileId = null)
        {
            var tileGroups = GetTileGroups();

            if (groupId != null && tileId != null)
            {
                var group = tileGroups.First(x => x.Id.Equals(groupId, StringComparison.OrdinalIgnoreCase));
                var tile = group.Tiles.First(x => x.Id.Equals(tileId, StringComparison.OrdinalIgnoreCase));

                return tile.Groups;
            }

            return tileGroups;
        }

        private IEnumerable<TileGroup> GetTileGroups()
        {
            return new List<TileGroup>
            {
                new TileGroup
                    {
                        Id = "AppMgr",
                        Name = "AppManager",
                        Tiles = new List<LiveTile>
                        {
                            new LiveTile
                            {
                                Id = "THP",
                                Name = "Theme pages",
                                Badge = "5",
                                Url = "Theme",
                                ContentSections = new [] { "Tile content" },
                                CssClasses = new [] { "bg-color-blue" }
                            },
                            new LiveTile
                            {
                                Id = "HTSP",
                                Name = "Hotspots",
                                Url = "Hotspots",
                                ContentSections = new [] { "Hotspot content" },
                                CssClasses = new [] { "bg-color-green" }
                            },
                            new LiveTile
                            {
                                Id = "PRLX",
                                Name = "Parallax Effects",
                                Url = "Parallax",
                                ContentSections = new [] { "Parallax content", "some more" },
                                CssClasses = new [] { "bg-color-yellow" },
                                Attributes = new List<KeyValuePair<string, string>>
                                {
                                    new KeyValuePair<string, string>("data-role", "tile-slider"),
                                    new KeyValuePair<string, string>("data-param-period", "3000")
                                }
                            },
                            new LiveTile
                            {
                                Id = "BTN",
                                Name = "Theme Buttons",
                                Url = "Buttons",
                                ContentSections = new [] { "Button content" },
                                CssClasses = new [] { "bg-color-pink" },
                                Groups = new List<TileGroup>
                                {
                                    new TileGroup
                                        {
                                            Id = "SubGrp",
                                            Name = "SubGroup",
                                            Tiles = new List<LiveTile>
                                            {
                                                new LiveTile
                                                {
                                                    Id = "THP",
                                                    Name = "Theme pages",
                                                    Url = "Theme",
                                                    ContentSections = new [] { "Tile content" },
                                                    CssClasses = new [] { "bg-color-blueDark" }
                                                },
                                                new LiveTile
                                                {
                                                    Id = "HTSP",
                                                    Name = "Hotspots",
                                                    Url = "Hotspots",
                                                    ContentSections = new [] { "Hotspot content" },
                                                    CssClasses = new [] { "bg-color-greenLight" }
                                                },
                                                new LiveTile
                                                {
                                                    Id = "PRLX",
                                                    Name = "Parallax Effects",
                                                    Url = "Parallax",
                                                    ContentSections = new [] { "Parallax content", "Slider content", "And some more" },
                                                    CssClasses = new [] { "bg-color-teal" },
                                                    Attributes = new List<KeyValuePair<string, string>>
                                                    {
                                                        new KeyValuePair<string, string>("data-role", "tile-slider"),
                                                        new KeyValuePair<string, string>("data-param-period", "3000")
                                                    }
                                                }
                                            }
                                        }
                                }
                            }
                        }
                    },
                    new TileGroup
                    {
                        Id = "ExampleGrp",
                        Name = "Example Group",
                        Tiles = new List<LiveTile>
                        {
                            new LiveTile
                            {
                                Id = "HOM",
                                Name = "Homepage",
                                Url = "Home",
                                ContentSections = new [] { "Tile content" },
                                CssClasses = new [] { "bg-color-magenta" }
                            },
                            new LiveTile
                            {
                                Id = "ACT",
                                Name = "Actions",
                                Url = "Actions",
                                ContentSections = new [] { "Action content" },
                                CssClasses = new [] { "bg-color-orangeDark" }
                            },
                            new LiveTile
                            {
                                Id = "ART",
                                Name = "Articles",
                                Url = "Articles",
                                ContentSections = new [] { "Articles content", "Slider content", "And some more" },
                                CssClasses = new [] { "bg-color-redLight" },
                                Attributes = new List<KeyValuePair<string, string>>
                                {
                                    new KeyValuePair<string, string>("data-role", "tile-slider"),
                                    new KeyValuePair<string, string>("data-param-period", "3000")
                                }
                            }
                        }
                    }
            };
        }
    }
}