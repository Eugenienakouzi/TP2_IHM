using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameManager gameManager;
    public ChronoManager chronoManager;

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    public void reset()
    {
        if (gameManager != null)
        {
            gameManager.nb_click = 0;
            gameManager.nb_erreur = 0;
            gameManager.isFinish = false;

            gameManager.clickText.text = "Nombre de click : " + gameManager.nb_click;
            gameManager.erreurText.text = "Nombre d'erreur : " + gameManager.nb_erreur;

            cube1.transform.position = new Vector3(0, 1, -8);
            cube2.transform.position = new Vector3(0, 1, -4);
            cube3.transform.position = new Vector3(0, 1, 0);

            chronoManager.timer = 0f;
            chronoManager.isTiming = false;
            chronoManager.finished = false;
            chronoManager.nb_cube = 0;
}
    }
}
