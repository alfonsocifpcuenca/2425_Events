using Scene_03;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Scene_01
{
    public class Switch : MonoBehaviour
    {
        // Variable para controlar si el interruptor est� encendido o apagado
        private bool isOn = false;

        void Update()
        {
            CheckToggle();
        }

        /// <summary>
        /// M�todo que comprueba si hay que cambiar el estado del interruptor
        /// </summary>
        private void CheckToggle()
        {
            // Si el usuario pulsa la tecla "espacio"
            if (Input.GetKeyUp(KeyCode.Space))
            {
                // Si est� encendido lo apagamos y al rev�s
                if (this.isOn)
                {
                    this.isOn = false;
                }
                else
                {
                    this.isOn = true;
                }

                // Buscamos todas las bombillas (gameobjects con el tag "Lightbulb")
                List<GameObject> lightbulbs = GameObject.FindGameObjectsWithTag("Lightbulb").ToList();

                // Recorremos las bombillas
                foreach (GameObject lightbulb in lightbulbs) { 

                    // Para cada bombilla, obtenemos su script Lightbulb
                    Lightbulb lightbulbScript = lightbulb.GetComponent<Lightbulb>();

                    // Si es distinto de null (para evitar errores) ejecutamos el m�todo que le hace encenderse o apagarse
                    if (lightbulbScript != null)
                    {
                        lightbulbScript.ToggleLightbulb(this.isOn);
                    }
                }
            }
        }
    }
}
