using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    public void VolverAlMenu()
    {
        Time.timeScale = 1f; 

        SceneManager.UnloadSceneAsync("Opciones");
    }
}