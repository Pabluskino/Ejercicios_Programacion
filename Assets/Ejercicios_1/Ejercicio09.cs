using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        private void Start()
        {
            GameObject prevSphere = null;
            for (int i = 0; i < 12; i++)
            {
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.name = $"Esfera{i}";
                /* ❕ GameObject.Find gasta muchos recursos, hay que evitar usarlo
                if (i > 0)
                {
                    GameObject prevSphere = GameObject.Find($"Esfera{i-1}");
                    esfera.transform.localScale = prevSphere.transform.localScale*2f;
                }
                */
                if (prevSphere != null)
                {
                    esfera.transform.localScale = prevSphere.transform.localScale*2f;
                }
                prevSphere = esfera;
            }
        }
    } 
}
