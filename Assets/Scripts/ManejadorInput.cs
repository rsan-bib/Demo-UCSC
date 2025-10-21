using UnityEngine;
using UnityEngine.UI; 

public class ManejadorInput : MonoBehaviour
{
    public InputField campoParaEscribir; 
    public Inventario inventarioControl; 

    public void TomarTextoYAgregarItem()
    {
        if (campoParaEscribir != null && inventarioControl != null)
        {
            string textoEscrito = campoParaEscribir.text;

            if (!string.IsNullOrWhiteSpace(textoEscrito))
            {
                inventarioControl.AñadirNuevoItem(textoEscrito);
                campoParaEscribir.text = ""; 
            }
        }
    }
}