using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerGridder : MonoBehaviour
{
    [SerializeField] PlayerState state;

    private void Start()
    {
        if (state == null) state = GetComponent<PlayerState>();
    }

    public void MoveGrid(Coordinate movement)
    {
        Vector3Int grid = state.gridManeger.GridWrite(state, WorldToCell(state.transform.position));
    }
    public void AimGrid(Coordinate movement)
    {

    }
}
