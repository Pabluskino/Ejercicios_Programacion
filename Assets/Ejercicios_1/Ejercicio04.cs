using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere una esfera al inicio con un Rigidbody a�adido
    /// </summary>
    public class Ejercicio04 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera.AddComponent<Rigidbody>();
        }
    } 
}
