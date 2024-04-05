// using System.Collections.Generic;
// using System.Linq;
// using UnityEngine;
// using UnityEngine.Tilemaps;
//
// namespace Elderland.MonoBehaviours;
//
// public class TilemapExpander : MonoBehaviour
// {
//     public Tilemap tilemap; // Your Tilemap
//     public TileBase tileToPlace; // The tile you want to place
//     public BoundsInt bounds;
//     public TileBase[] allTiles;
//
//     void Start()
//     {
//         tilemap = GetComponent<Tilemap>();
//         bounds = tilemap.cellBounds;
//         allTiles = tilemap.GetTilesBlock(bounds);
//         foreach (var tile in allTiles)
//         {
//             if (tile is null) continue;
//             Plugin.Log.LogWarning($"Tile: {tile.name}");
//         }
//         tileToPlace = allTiles[0];
//         ExpandTilemap();
//     }
//
//     void ExpandTilemap()
//     {
//         // Example: Calculate new bounds needed for 21:9 aspect ratio
//         // This is a simplistic approach; your actual implementation might need more complex calculations
//         // based on the camera's view and how you handle the tilemap's bounds.
//
//
//         int additionalColumns = CalculateAdditionalColumns(); // Implement this based on your tile size and screen width
//
//         for (int x = bounds.xMin; x < bounds.xMax + additionalColumns; x++)
//         {
//             for (int y = bounds.yMin; y < bounds.yMax; y++)
//             {
//                 Vector3Int tilePosition = new Vector3Int(x, y, 0);
//                 // if (tilemap.GetTile(tilePosition) == null)
//                 // {
//                     // Place a new tile if there's none already here
//                     tilemap.SetTile(tilePosition, tileToPlace);
//                 // }
//             }
//         }
//
//         // Optionally, refresh the Tilemap to update its visual appearance
//         tilemap.RefreshAllTiles();
//     }
//
//     int CalculateAdditionalColumns()
//     {
//         // Placeholder: Calculate the number of additional columns you need based on the camera width
//         // and tile size. This method needs to be implemented based on your specific needs.
//         return 200; // Example value
//     }
// }