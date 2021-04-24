using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrag : MonoBehaviour
{
    [SerializeField] private Vector3 boxSize = new Vector3(1, 1, 0);

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
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.BoxCast(ray.origin, boxSize, ray.direction, out hit))
        {
            ICardReadable hitPiece = hit.collider.GetComponent<ICardReadable>();
            if (hitPiece != null)
            {
                hitPiece.ReadCard(card);
            }
        }
    }
}
