using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Tilemap))]
public class TilemapManager : MonoBehaviour
{
    private Tilemap tilemap;
    private int cellSize;

    [SerializeField] private List<TileData> tileDataList
        = new List<TileData>();

    private Dictionary<TileBase, TileData> tileDataDictionary
        = new Dictionary<TileBase, TileData>();

    public void Construct(int cellSize)
    {
        this.cellSize = cellSize;

        tilemap = gameObject.GetComponent<Tilemap>();

        foreach (TileData tileData in tileDataList)
        {
            foreach (TileBase tileBase in tileData.tileList)
            {
                tileDataDictionary.Add(tileBase, tileData);
            }
        }
    }

    public Vector3Int GetGridPosition(Vector3 position)
    {
        return tilemap.WorldToCell(position);
    }

    public TileBase GetTile(Vector3 position)
    {
        Vector3Int gridPosition = tilemap.WorldToCell(position);
        return tilemap.GetTile(gridPosition);
    }

    public TileBase GetTile(Vector3Int position)
    {
        return tilemap.GetTile(position);
    }

    public TileData GetTileData(Vector3Int position)
    {
        TileBase tile = GetTile(position);
        return tileDataDictionary[tile];
    }

    public void MoveTile(Vector3Int toMove, Vector3Int destination)
    {
        TileBase toMoveTile = tilemap.GetTile(toMove);
        tilemap.SetTile(toMove, null);
        tilemap.SetTile(destination, toMoveTile);
    }
}
