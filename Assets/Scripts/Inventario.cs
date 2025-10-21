using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<string> itemsGuardados = new List<string>();
    public Text textoEnPantalla; 

    public void AñadirNuevoItem(string nombreDelItem)
    {
        itemsGuardados.Add(nombreDelItem);
        MostrarListaEnPantalla();
    }

    private void MostrarListaEnPantalla()
    {
        // 1. Obtiene la cantidad total de ítems de la lista.
        int cantidadTotal = itemsGuardados.Count;

        // 2. Construye el texto para mostrar. Por ejemplo: "DAVES: 5"
        // Si prefieres solo el número, usa: string textoConteo = cantidadTotal.ToString();
        string textoConteo = cantidadTotal.ToString(); 
        
        // 3. Asigna ese texto al componente de UI.
        if (textoEnPantalla != null)
        {
            textoEnPantalla.text = textoConteo;
        }
    }
    
    void Start()
    {
        MostrarListaEnPantalla();
    }
}