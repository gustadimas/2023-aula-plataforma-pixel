using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{   
    void Update()
    {
        if (ContadorColetaveis.contadorColetaveis == 7)
        {
            SceneManager.LoadScene("Cena2");
        }
    }
}



