using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CardDrag : MonoBehaviour
{
    [SerializeField] private Vector2 boxSize = new Vector2(1, 1);

    [SerializeField] private Card card;

    RaycastHit hit;
    private void OnMouseDrag()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = ray.GetPoint(10f);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
    private void OnMouseUpAsButton()
    {

        var cols = Physics2D.OverlapAreaAll(this.transform.position, boxSize);

        if (cols != null)
        {
            if (cols.Any(x => x.GetComponent<ICardReadable>() != null))
            {
                Debug.Log("d");
                ICardReadable hitPiece = cols.Select(x => x.GetComponent<ICardReadable>()).Where(x => x != null).First();
                hitPiece.ReadCard(card);
            }
        }
    }
}
