using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private int boardWidth, boardHeight;
    [SerializeField] private TilesControl tilePrefab;
    [SerializeField] private Transform camTransform;

    void GenerateGrid()
    {
        // Transform tilesParent = GameObject.Find("/Tiles").transform;

        // for (int x = 0; x < boardWidth; x++)
        // {
        //     for (int y = 0; y < boardHeight; y++)
        //     {
        //         TilesControl spawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity, tilesParent);
        //         int i = x, j = 3 - y; // ONLY IN NORMAL BOARD!!
        //         spawnedTile.name = $"Tile {i} {j}";
        //         spawnedTile.coordinate.Set(i, j);

        //         bool isOffset = (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);
        //         spawnedTile.Init(isOffset);
        //     }
        // }

        // camTransform.transform.position = new Vector3((float)boardWidth/2-0.5f, (float)boardHeight/2-0.5f, -10);
    }

    void Start()
    {
        GenerateGrid();
    }
}
