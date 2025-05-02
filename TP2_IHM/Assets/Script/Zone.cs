using UnityEngine;

public class Zone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            other.GetComponent<Draggable>().enabled = false;
            other.transform.position = transform.position;
        }
    }
}
