using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ChronoManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer = 0f;
    public bool isTiming = false;
    public bool finished = false;
    public int nb_cube = 0;
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
        Debug.Log("Temps : " + timer.ToString("F2") + "s" + "\n" + "Nombre de click : " + GameManager.GetComponent<GameManager>().GetCpt() + "\n" + "Nombre d'erreur : " + GameManager.GetComponent<GameManager>().nb_erreur);

    }

    public float GetFinalTime()
    {
        return timer;
    }
}
