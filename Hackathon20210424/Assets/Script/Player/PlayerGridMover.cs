using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;

public class PlayerGridMover : MonoBehaviour
{
    [SerializeField] PlayerState state;
    [SerializeField] PlayerItemManeger itemManeger = null;


    private void Start()
    {
        if (state == null) state = GetComponent<PlayerState>();
    }

    public bool MoveGrid(Coordinate coor)
    {
        Collider2D[] cols = state.grid.GridCheck(coor.GetVector() + state.grid.CheckNowGrid(this.transform.position));

        if (cols != null)
        {
            if (cols.Any(x => x.GetComponent<Enemy>() != null))
            {

            }
            else
            {
                if (cols.Any(x => x.GetComponent<Item>() != null))
                {

                    foreach (Item i in cols.Select(x => x.GetComponent<Item>()).Where(x => x != null))
                    {
                        itemManeger.DealItem(i);
                    }

                }

                state.grid.GridMove(this.transform, coor.GetVector() + state.grid.CheckNowGrid(this.transform.position));
                return true;
            }
        }
        return false;

    }
    public void WarpGrid(Coordinate coor)
    {
        Debug.Log("CallWarp");
        Collider2D[] cols = state.grid.GridCheck(coor.GetVector());
        if (cols != null)
        {
            if (cols.Any(x => GetComponent<Enemy>() != null))
            {

            }
            else
            {
                state.grid.GridMove(this.transform, coor.GetVector());
            }
        }
    }
}
