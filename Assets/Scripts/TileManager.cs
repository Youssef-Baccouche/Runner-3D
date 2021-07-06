using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLenght = 30;
    public int numberOfTiles = 5;

    void Start()
    {
        SpawnTile(0);
        SpawnTile(1);
        SpawnTile(2);
        SpawnTile(3);
        SpawnTile(4);
        SpawnTile(5);


    }

    void Update()
    {

    }
    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLenght;
    }
}