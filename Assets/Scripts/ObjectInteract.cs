using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    Inventario inventario;
    
    void Start()
    {
        // Se mantiene la búsqueda
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // 🛑 ELIMINA CUALQUIER LÍNEA COMO: inventario.Cantidad = ... o inventario.Cantidad++;
            
            // ✅ CORRECCIÓN: Llama al método que añade el ítem a la lista.
            inventario.AñadirNuevoItem("Item Recogido"); 
            
            // Destruye el objeto recogido
            Destroy(gameObject);
        }  
    } 
}