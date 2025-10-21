using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float timer = 0;
    public Text textoTimer;    
    void Update()
    {
        timer += Time.deltaTime;

        textoTimer.text = "" + timer.ToString("f0")+" Seg";
    }
    
}
