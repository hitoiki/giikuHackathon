using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;

public class PlayerGridder : MonoBehaviour
{
    [SerializeField] PlayerState state;

    private void Start()
    {
        if (state == null) state = GetComponent<PlayerState>();
    }

    public void MoveGrid(Coordinate coor)
    {
        Debug.Log("CallMove");
        Collider[] cols = state.grid.GridCheck(coor.GetVector() + state.grid.CheckNowGrid(this.transform.position));
        if (cols.Any(x => GetComponent<Enemy>() != null))
        {

        }
        else
        {
            state.grid.GridMove(this.transform, coor.GetVector() + state.grid.CheckNowGrid(this.transform.position));
        }
    }
    public void AimGrid(Coordinate coor)
    {

    }
}
