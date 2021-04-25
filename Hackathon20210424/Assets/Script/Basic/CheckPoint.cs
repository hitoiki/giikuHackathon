using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GridManeger grid;
    private void OnMouseDrag()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = ray.GetPoint(10f);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);


    }
    private void OnMouseUp()
    {
        Debug.Log(grid.CheckNowGrid(this.transform.position).ToString());
    }
}
