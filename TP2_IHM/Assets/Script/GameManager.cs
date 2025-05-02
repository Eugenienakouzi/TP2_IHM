using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI clickText;
    private int nb_click = 0;
    public TextMeshProUGUI erreurText;
    public int nb_erreur = 0;

    public bool isFinish = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isFinish)
        {
            nb_click += 1;
        }
        clickText.text = "Nombre de click : " + nb_click;
        erreurText.text = "Nombre d'erreur : " + nb_erreur;

    }

    public int GetCpt()
    {
        return nb_click;
    }
}
