using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Board : MonoBehaviour {

    [SerializeField] GameObject tilePrefab;

    public Dictionary<Point, Tile> tiles = new Dictionary<Point, Tile>();

    public void Load(LevelData data) {
        for (int i = 0; i < data.tiles.Count; ++i) {
            GameObject instance = Instantiate(tilePrefab) as GameObject;
            Tile t = instance.GetComponent<Tile>();
            t.Load(data.tiles[i]);
            tiles.Add(t.pos, t);
        }
    }

    public List<Tile> Search(Tile start, Func<Tile, Tile, bool> addTile) {
        List<Tile> retValue = new List<Tile>();
        retValue.Add(start);

        ClearSearch();
        Queue<Tile> checkNext = new Queue<Tile>();
        Queue<Tile> checkNow = new Queue<Tile>();

        start.distance = 0;
        checkNow.Enqueue(start);

        // Add more code here

        return retValue;
    }

    void ClearSearch() {
        foreach (Tile t in tiles.Values) {
            t.prev = null;
            t.distance = int.MaxValue;
        }
    }
}