using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class OnclickDrag : MonoBehaviour
{
    private Vector3 screenPoint; private Vector3 offset; private float _lockedYPosition;

    void OnMouseDown()
    {
        _lockedYPosition = screenPoint.y;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        Cursor.visible = false;

    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.x = _lockedYPosition;
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        Cursor.visible = true;
    }
}

