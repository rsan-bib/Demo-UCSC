using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTrigger : MonoBehaviour
{
    [Header("Configuración de Victoria")]
    [SerializeField] private string nombreEscenaFinal = "Menu"; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Condición de final cumplida! Cargando escena final...");
            
            CargarEscenaFinal();

            Destroy(gameObject); 
        }
    }

    private void CargarEscenaFinal()
    {
        Time.timeScale = 1f; 
        
        SceneManager.LoadScene(nombreEscenaFinal);
    }
}