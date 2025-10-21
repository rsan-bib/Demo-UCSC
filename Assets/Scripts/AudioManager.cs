using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource musicinGameSource;
    
    [Header("Audio Clips")]
    public AudioClip menuMusic;
    public AudioClip gameMusic;


    private void Awake()
    {
        // Lógica corregida del Singleton:
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // El AudioManager debe persistir.
        }
        else
        {
            // Si ya hay una instancia, destruye este duplicado.
            Destroy(gameObject);
            return; 
        }
    }
    
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ChangeMusicBasedOnScene(scene.name);
    }
    
    public void ChangeMusicBasedOnScene(string sceneName)
    {
        if (sceneName == "Opciones")
        {
            return; 
        }

        musicSource.Stop();
        musicinGameSource.Stop();

        if (sceneName == "Menu")
        {
            musicSource.clip = menuMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
        else if (sceneName == "LOL")
        {
            musicinGameSource.clip = gameMusic;
            musicinGameSource.loop = true;
            musicinGameSource.Play();
        }
    }
}