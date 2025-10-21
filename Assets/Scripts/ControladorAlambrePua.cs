using UnityEngine;

public class ControladorAlambrePua : MonoBehaviour
{
    public Animator AnimatorPadre;
    public float danio = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ALGO COLISONÓ CONMIGO! Se llama'" + collision.gameObject.name + "'");
        AnimatorPadre.SetTrigger("hurt");
        if (collision.gameObject.tag == "Player")
        {
            //Estoy chocando con la bola!
            collision.gameObject.GetComponent<ControladorFuerza>().durabilidad -= danio;
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Estoy chocando con la bola!
            collision.gameObject.GetComponent<ControladorFuerza>().durabilidad -= (danio/10f);
        }
    }
}
