using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private GridManager baseTileLayerManager;
    [SerializeField] private LinkObjectManager linkObjectManager;

    private void Awake()
    {
        inputManager.Construct();
        baseTileLayerManager.Construct(inputManager);
        linkObjectManager.Construct();
    }
}
