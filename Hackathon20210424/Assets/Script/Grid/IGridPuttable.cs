using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public interface IGridPuttable
{
    //Grid上に配置されるObject
    /*
    Grid上の位置を持っている
    GridManegerにList形式で所有される。
    
    */
    TileBase GetTileBase();
}