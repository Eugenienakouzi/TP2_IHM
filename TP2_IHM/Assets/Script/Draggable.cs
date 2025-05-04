using UnityEngine;
using TMPro;

public class Draggable : MonoBehaviour
{
    private Vector3 offset;
    private float zCoord;
    public bool finish = false;
    public GameObject GameManager;


    void OnMouseDown()
    {
        if (!finish)
        {
            zCoord = Camera.main.WorldToScreenPoint(transform.position).z;

            offset = transform.position - GetMouseWorldPos();
        }

    }

    private void OnMouseUp()
    {
        if(!finish)
        {
            GameObject zone;
            if (IsInsideAnyZone(out zone))
            {
                finish = true;
                GameManager.GetComponent<ChronoManager>().StopTimer();
                transform.position = transform.position + Vector3.up;
            }
            else
            {
                GameManager.GetComponent<GameManager>().nb_erreur += 1;
            }
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
            zCoord += 0.35f;
        }else if (wheel < -0.05f)
        {
            zCoord -= 0.3f;
        }
        mousePoint.z = zCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private bool IsInsideAnyZone(out GameObject validZone)
    {
        GameObject[] zones = GameObject.FindGameObjectsWithTag("Zone");
        Collider cubeCollider = GetComponent<Collider>();
        Bounds cubeBounds = cubeCollider.bounds;

        Vector3[] corners = GetCubeCorners(cubeBounds);

        foreach (GameObject zone in zones)
        {
            Collider zoneCollider = zone.GetComponent<Collider>();
            Bounds zoneBounds = zoneCollider.bounds;

            bool allInside = true;
            foreach (Vector3 corner in corners)
            {
                if (!zoneBounds.Contains(corner))
                {
                    allInside = false;
                    break;
                }
            }

            if (allInside)
            {
                validZone = zone;
                return true;
            }
        }

        validZone = null;
        return false;
    }

    private Vector3[] GetCubeCorners(Bounds bounds)
    {
        Vector3[] corners = new Vector3[4];

        Vector3 min = bounds.min;
        Vector3 max = bounds.max;

        corners[0] = new Vector3(min.x, min.y, min.z);
        corners[1] = new Vector3(min.x, min.y, max.z);
        corners[2] = new Vector3(max.x, min.y, min.z);
        corners[3] = new Vector3(max.x, min.y, max.z);

        return corners;
    }

}