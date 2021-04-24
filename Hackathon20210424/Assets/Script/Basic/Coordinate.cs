using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//あとで飛車の挙動ができるように改造する
[System.Serializable]
public class Coordinate
{
    public int xPosition;
    public int yPosition;

    public Vector3Int GetVector()
    {
        return new Vector3Int(xPosition, yPosition, 0);
    }
}

