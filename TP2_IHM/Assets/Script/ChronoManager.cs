using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChronoManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer = 0f;
    private bool isTiming = false;
    private bool finished = false;
    private int nb_cube = 0;
    public GameObject GameManager;


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
            }
        }
        timerText.text = "Temps : " + timer.ToString("F2") + "s";
    }

    public void StopTimer()
    {
        nb_cube += 1;
        if (nb_cube == 3)
        {
            isTiming = false;
            finished = true;
            GameManager.GetComponent<GameManager>().isFinish = true;
        }

    }

    public float GetFinalTime()
    {
        return timer;
    }
}
