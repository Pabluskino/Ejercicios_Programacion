using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 30 GameObjects al inicio
    /// </summary>
    public class Ejercicio05 : MonoBehaviour
    {
        private void Start()
        {
            for(int i=0; i<30; i++)
            {
                new GameObject();
            }
        }
    } 
}
