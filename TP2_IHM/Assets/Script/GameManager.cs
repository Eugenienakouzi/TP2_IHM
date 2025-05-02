using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI clickText;
    public int nb_click = 0;
    public TextMeshProUGUI erreurText;
    public int nb_erreur = 0;

    public GameObject zone1;
    public GameObject zone2;
    public GameObject zone3;

    public bool isFinish = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isFinish)
        {
            nb_click += 1;
        }
        clickText.text = "Nombre de click : " + nb_click;
        erreurText.text = "Nombre d'erreur : " + nb_erreur;

    }

    public void facile()
    {
        zone1.transform.position = new Vector3(10, 0, -8);
        zone2.transform.position = new Vector3(10, 0, -4);
        zone3.transform.position = new Vector3(10, 0, 0);
        zone1.transform.localScale = new Vector3(2, 0.4f, 2);
        zone2.transform.localScale = new Vector3(2, 0.4f, 2);
        zone3.transform.localScale = new Vector3(2, 0.4f, 2);
    }

    public void moyen()
    {
        zone1.transform.position = new Vector3(16, 0, -8);
        zone2.transform.position = new Vector3(16, 0, -4);
        zone3.transform.position = new Vector3(16, 0, 0);
        zone1.transform.localScale = new Vector3(1, 0.4f, 1);
        zone2.transform.localScale = new Vector3(1, 0.4f, 1);
        zone3.transform.localScale = new Vector3(1, 0.4f, 1);

    }
    public void difficile()
    {
        zone1.transform.position = new Vector3(16, 2, -12);
        zone2.transform.position = new Vector3(16, 2, -4);
        zone3.transform.position = new Vector3(16, 2, 4);
        zone1.transform.localScale = new Vector3(1, 0.2f, 1);
        zone2.transform.localScale = new Vector3(1, 0.2f, 1);
        zone3.transform.localScale = new Vector3(1, 0.2f, 1);
    }

    public int GetCpt()
    {
        return nb_click;
    }
}
