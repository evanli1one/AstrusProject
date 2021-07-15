using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "TileData", menuName = "GridData/TileData")]
public class TileData : ScriptableObject
{
    public List<TileBase> tileList = new List<TileBase>();

    public bool occupied = false;

    public bool accessible = true;
}
