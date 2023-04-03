using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    /// </summary>
    public class Ejercicio10 : MonoBehaviour
    {
        public string nombre;
        private void Start()
        {
            GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();
            foreach(GameObject gameObject in allObjects)
            {
                gameObject.name = nombre;
            }
        }
    } 
}
