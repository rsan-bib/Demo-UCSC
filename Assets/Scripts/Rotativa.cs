using UnityEngine;

public class DEMOPOLI : MonoBehaviour
{

public string nombrePoli = "JefePoli";
public float velocity = 1f;
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{

}

// Update is called once per frame
void Update()
{
// Debug.Log(this.transform.position);
// float dist = Vector3.Distance(this.transform.position, new Vector3(7, 3, 24)); //Calcular distancia de un objeto entre 2 vectores
// if (dist >= 1)
// {
// this.transform.Translate(velocity * (new Vector3(0, 0, 0.01f)));
// }

this.transform.Translate(velocity * (new Vector3(0, 0, 0)));
this.transform.Rotate(velocity * (new Vector3(0, 1f, 0)));
// this.gameObject.transform
}
}