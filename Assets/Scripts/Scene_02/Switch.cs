using UnityEngine;
using UnityEngine.Events;

namespace Scene_02
{
    public class Switch : MonoBehaviour
    {
        // Variable que contiene el evento que admite como parámetro un bool
        public UnityEvent<bool> OnSwitchToggle = new UnityEvent<bool>();

        // Variable para controlar si el interruptor está encendido o apagado
        private bool isOn = false;

        void Update()
        {
            CheckToggle();
        }

        /// <summary>
        /// Método que comprueba si hay que cambiar el estado del interruptor
        /// </summary>
        private void CheckToggle()
        {
            // Si el usuario pulsa la tecla "espacio"
            if (Input.GetKeyUp(KeyCode.Space))
            {
                // Si el interruptor está encendido lo apagamos, y al revés
                if (this.isOn)
                {
                    this.isOn = false;
                }
                else
                {
                    this.isOn = true;
                }

                // Invocamos el evento para propagarlo, es decir avisamos a todos los objetos
                // que estén suscritos a este evento que el evento ha ocurrido, ahora cada
                // objeto actuará como mas convenga. Además pasamos un parámetro
                this.OnSwitchToggle.Invoke(this.isOn);
            }
        }
    }
}
