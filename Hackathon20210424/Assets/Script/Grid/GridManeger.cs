using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManeger : MonoBehaviour
{
    //Tilemapに大量の情報が集いそうな気配を感じるため、TileMapのマス目とクラスを紐づけたい
    //PuttableにTile上の位置情報を持っててもらう
    //各自ここを通して自身の持つ位置を更新する
    //
    private IGridPuttable Piece;
    [SerializeField] Tilemap fieldTile;
    public Tilemap itemtile;

    private void Start()
    {

    }

    public void GridWrite(IGridPuttable gridPut, Coordinate coor)
    {
        if (fieldTile.HasTile(coor.GetVector()))
        {
            fieldTile.SetTile(coor.GetVector(), gridPut.GetTileBase());
        }
    }

}
