using UnityEngine;

public class Draggable : MonoBehaviour
{
    private Vector3 offset;
    private float zCoord;
    public bool finish = false;
    
   

    void OnMouseDown()
    {
        if (!finish)
        {
            zCoord = Camera.main.WorldToScreenPoint(transform.position).z;

            offset = transform.position - GetMouseWorldPos();
        }
    }

    void OnMouseDrag()
    {
        if (!finish)
        {
        transform.position = GetMouseWorldPos() + offset;
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        float wheel = Input.GetAxis("Mouse ScrollWheel");
        if (wheel > 0.05f)
        {
            zCoord += 1;
        }else if (wheel < -0.05f)
        {
            zCoord -= 1;
        }
        mousePoint.z = zCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

}