using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio07 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera2.transform.position = new Vector3(100f,0f,0f);
            esfera3.transform.position = new Vector3(0f, 100f, 0f);
        }
    } 
}
