using UnityEngine;

public class Zone : MonoBehaviour
{
    public ChronoManager chronoManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            chronoManager.StopTimer();

            other.GetComponent<Draggable>().enabled = false;
            other.transform.position = transform.position;
        }
    }
}
