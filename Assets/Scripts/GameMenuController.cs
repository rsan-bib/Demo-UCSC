using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }
    public void TogglePauseMenu()
    {
        Scene opcionesScene = SceneManager.GetSceneByName("Opciones");

        if (opcionesScene.isLoaded)
        {
            
            Time.timeScale = 1f; 

            SceneManager.UnloadSceneAsync("Opciones");
        }
        else
        {
            
            Time.timeScale = 0f; 

            SceneManager.LoadScene("Opciones", LoadSceneMode.Additive);
        }
    }
}