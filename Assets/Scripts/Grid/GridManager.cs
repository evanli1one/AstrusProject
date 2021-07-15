using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Grid))]
public class GridManager : MonoBehaviour
{
    private List<TileObject> tileObjectList
        = new List<TileObject>();
    [SerializeField] private TilemapManager objectTilemap;
    [SerializeField] private TilemapManager groundTilemap;

    private Grid grid;
    private int cellSize;

    public void Construct(InputManager inputManager)
    {
        TileObject[] foundTileObjects = FindObjectsOfType<TileObject>();

        foreach(TileObject tileObject in foundTileObjects)
        {
            tileObjectList.Add(tileObject);
        }

        grid = gameObject.GetComponent<Grid>();
        cellSize = (int)grid.cellSize.x;

        objectTilemap.Construct(cellSize);
        groundTilemap.Construct(cellSize);

        foreach (TileObject tileObject in tileObjectList)
        {
            tileObject.Construct(objectTilemap, inputManager, this, cellSize);
        }
    }

    public bool TileAvailable(Vector3Int position)
    {
        TileBase objectTile = objectTilemap.GetTile(position);
        TileBase groundTile = groundTilemap.GetTile(position);

        if (objectTile != null || groundTile == null)
        {
            return false;
        }

        return true;
    }
}
