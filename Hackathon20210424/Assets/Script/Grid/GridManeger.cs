using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;

public class GridManeger : MonoBehaviour
{
    //Tilemapに大量の情報が集いそうな気配を感じるため、TileMapのマス目とクラスを紐づけたい
    //Gridに物を置く、消す、動かす処理は全てここを介して行う
    //動かす流れとして、まずGridManegerは位置情報とGridItemをセットにしたListを持つ。
    //
    [SerializeField] Tilemap fieldTile = null;
    [SerializeField] Vector2 gridSize = new Vector2(0.9f, 0.9f);
    Vector3 gridSize3D;

    private void Start()
    {
        gridSize3D = new Vector3(gridSize.x, gridSize.y, fieldTile.transform.position.z);
    }

    public Vector3Int CheckNowGrid(Vector3 pos)
    {

        Vector3Int vector = fieldTile.WorldToCell(pos);
        return vector;
    }

    public Collider2D[] GridCheck(Vector3Int vec)
    {
        if (fieldTile.HasTile(vec))
        {

            return Physics2D.OverlapAreaAll(fieldTile.GetCellCenterWorld(vec) - (gridSize3D / 2), fieldTile.GetCellCenterWorld(vec) + (gridSize3D / 2));
        }
        else return null;
    }

    public bool GridMove(Transform trans, Vector3Int vec)
    {
        if (fieldTile.HasTile(vec))
        {
            trans.position = fieldTile.GetCellCenterWorld(vec) - Vector3.forward;
            return true;
        }
        else return false;


    }


}


