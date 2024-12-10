using UnityEngine;
using UnityEngine.Events;

namespace Scene_02
{
    public class Switch : MonoBehaviour
    {
        // Variable que contiene el evento que admite como par�metro un bool
        public UnityEvent<bool> OnSwitchToggle = new UnityEvent<bool>();

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
                // Si el interruptor est� encendido lo apagamos, y al rev�s
                if (this.isOn)
                {
                    this.isOn = false;
                }
                else
                {
                    this.isOn = true;
                }

                // Invocamos el evento para propagarlo, es decir avisamos a todos los objetos
                // que est�n suscritos a este evento que el evento ha ocurrido, ahora cada
                // objeto actuar� como mas convenga. Adem�s pasamos un par�metro
                this.OnSwitchToggle.Invoke(this.isOn);
            }
        }
    }
}
