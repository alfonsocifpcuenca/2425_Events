using UnityEngine;

namespace Scene_03
{
    public class Switch : MonoBehaviour
    {
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

                // Invocamos el evento para propagarlo, en otras palabras decimos a la aplicación
                // que el evento OnSwitchToggle ha ocurrido, todos los gameobjects suscritos al mismo
                // reaccionarán
                GameManager.Instance.EventsManager.OnSwitchToggle.Invoke(this.isOn);
            }
        }
    }
}
