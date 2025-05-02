using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private int cpt = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cpt += 1;
        }
        timerText.text = "Nombre de click : " + cpt;

    }

    public int GetCpt()
    {
        return cpt;
    }
}
