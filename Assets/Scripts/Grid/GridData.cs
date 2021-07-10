using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridData: MonoBehaviour
{
    [SerializeField] Tilemap dataTilemap;

    private void Awake()
    {
        BoundsInt bounds = dataTilemap.cellBounds;
        TileBase[] allTiles = dataTilemap.GetTilesBlock(bounds);

        print("bounds: " + bounds);
    }
}
