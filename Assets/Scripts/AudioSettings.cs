using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;

    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            // Inicializa con un valor por defecto si no hay guardado
            musicSlider.value = 1f;
            SetMusicVolume(); 
        }
    }
    
    public void SetMusicVolume()
    {
        float volume = musicSlider.value;

        // Si el valor es cero (o cercano), establecemos el volumen del Mixer a -80 dB (Mute)
        if (volume <= 0.0001f)
        {
             myMixer.SetFloat("music", -80f); 
        }
        else
        {
            // La fórmula convierte el valor lineal del slider (0 a 1) a decibelios
            myMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        }
        
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    
    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SetMusicVolume();
    }
    
    // Dejo el Awake como está, pero ten cuidado con la persistencia.
    private void Awake()
    {
    }
}