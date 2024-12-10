using UnityEngine;

namespace Scene_03
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
                // Si el interruptor est� encendido lo apagamos, y al rev�s
                if (this.isOn)
                {
                    this.isOn = false;
                }
                else
                {
                    this.isOn = true;
                }

                // Invocamos el evento para propagarlo, en otras palabras decimos a la aplicaci�n
                // que el evento OnSwitchToggle ha ocurrido, todos los gameobjects suscritos al mismo
                // reaccionar�n
                GameManager.Instance.EventsManager.OnSwitchToggle.Invoke(this.isOn);
            }
        }
    }
}
