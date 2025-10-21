using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void EscenaJuego()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("LOL");
    }
    
        public void AbrirOpcionesAditivo()
    {
        SceneManager.LoadScene("Opciones", LoadSceneMode.Additive);
    }
    
  
    public void Salir()
    {
        Application.Quit();
    }
    
}