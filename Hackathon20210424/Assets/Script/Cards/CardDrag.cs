using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CardDrag : MonoBehaviour
{
    [SerializeField] private Vector2 boxSize = new Vector2(1, 1);
    private Vector3 boxSize3D => new Vector3(boxSize.x, boxSize.y, 0);

    [SerializeField] private Card card = null;

    private Vector3 origin;

    [SerializeField] Collider2D[] cols;


    RaycastHit hit;
    private void OnMouseDown()
    {
        origin = this.transform.position;

    }
    private void OnMouseDrag()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = ray.GetPoint(10f);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);


    }
    private void OnMouseUp()
    {


        cols = Physics2D.OverlapAreaAll(this.transform.position - (boxSize3D / 2), this.transform.position + (boxSize3D / 2));

        if (cols != null)
        {
            if (cols.Any(x => x.GetComponent<ICardReadable>() != null))
            {
                ICardReadable hitPiece = cols.Select(x => x.GetComponent<ICardReadable>()).Where(x => x != null).First();
                hitPiece.ReadCard(card);
            }
        }

        /*if (this.transform.position.x <= 2.4f)*/
        this.transform.position = origin;
    }
}
