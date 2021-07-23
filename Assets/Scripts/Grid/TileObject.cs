using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileObject : MonoBehaviour
{
    private TilemapManager tilemapManager;
    private InputManager inputManager;
    private GridManager gridManager;
    private int cellSize;

    private TileBase tileMarker;
    private Vector3Int gridPosition;

    public void Construct(TilemapManager tilemapManager, InputManager inputManager, GridManager gridManager, int cellSize)
    {
        this.tilemapManager = tilemapManager;
        this.inputManager = inputManager;
        this.cellSize = cellSize;
        this.gridManager = gridManager;

        gridPosition = tilemapManager.GetGridPosition(gameObject.transform.position);
        tileMarker = tilemapManager.GetTile(gameObject.transform.position);

        inputManager.gameplayControls.PlayerActionMap.MoveHCell.performed
            += context => MoveHorizontal(context.ReadValue<float>());
    }

    private void Move(Vector2Int direction, int tileDistance)
    {
        Vector3Int oldPosition = gridPosition;
        Vector3Int tileDisplacement = new Vector3Int(direction.x, 0, direction.y) * tileDistance;
        Vector3Int destinationTile = oldPosition + tileDisplacement;

        if (gridManager.TileAvailable(destinationTile))
        {
            int distance = cellSize * tileDistance;
            Vector2 displacement2D = direction * distance;
            Vector3 displacement3D = new Vector3(displacement2D.x, 0, displacement2D.y);

            gameObject.transform.position += displacement3D;

            gridPosition = tilemapManager.GetGridPosition(gameObject.transform.position);

            tilemapManager.MoveTile(oldPosition, gridPosition);
        }
    }

    private void MoveHorizontal(float direction)
    {
        Move(new Vector2Int(1, 0), (int)direction);
    }
}
