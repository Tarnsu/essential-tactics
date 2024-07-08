using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
    //instantiate the tile types from the TileType class
    TileType[] tileTypes;

    //create and array for the tiles
    int[,] tiles;

    //read the grid map and create a tile map that is equal in size and width (NOTE: CURRENTLY HARDCODED TO THE DEMO NUMBERS)
    int mapSizeX = 18;
    int mapSizeY = 10;

    void Start()
    {
        // Designate map tiles
        tiles = new int[mapSizeX, mapSizeY];

        //go through the 2d array for the map and initialize the TileType index based on the MapIndex.
        //This class will be passed a hashmap based on the gridmap to fill in this data, may currently hardcode just for testing purposes.
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                tiles[x, y] = MapIndex[x, y];
            }
        }
    }

}
