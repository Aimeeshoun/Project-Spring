using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dragifdropped : MonoBehaviour
{
    public GameObject weapon;

    private Vector3 screenPoint;
    private Vector3 offset;
    public bool IsDragable = false;
    public Transform transform_;


    public void Awake()
    {
        weapon =  this.gameObject;
        transform_ = weapon.transform;
        if (transform_.parent == null)
        {
            IsDragable = true;

        }
    }

    public void OnMouseDown()
    {
        if (IsDragable)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    public void OnMouseDrag()
    {
        if (IsDragable)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

}