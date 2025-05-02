using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChronoManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer = 0f;
    private bool isTiming = false;
    private bool finished = false;
    private int cpt = 0;

    private void Update()
    {
        if (!finished)
        {
            if (!isTiming && Input.GetMouseButtonDown(0))
            {
                isTiming = true;
            }

            if (isTiming)
            {
                timer += Time.deltaTime;
                timerText.text = "Temps : " + timer.ToString("F2") + "s";
            }
        }
    }

    public void StopTimer()
    {
        cpt += 1;
        if (cpt == 3)
        {
            isTiming = false;
            finished = true;
        }

    }

    public float GetFinalTime()
    {
        return timer;
    }
}
