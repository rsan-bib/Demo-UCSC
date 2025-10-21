using UnityEngine;

public class ControladorFuerza : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float fuerza = 1f;
    public Rigidbody rigidbody;
    [Range(0f, 100f)]
    public float durabilidad = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0f, 0f, fuerza);
        //this.transform.Translate(0f,0f,fuerza/10f);        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLISIONE CON ALGO ES EL OBJETO '" + collision.gameObject.name + "'");
    }
}
