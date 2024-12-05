using UnityEngine;
using UnityEngine.Events;

namespace Scene_02
{
    public class Switch : MonoBehaviour
    {
        public UnityEvent<bool> OnSwitchToggle = new UnityEvent<bool>();
        private bool isOn = false;

        void Update()
        {
            CheckToggle();
        }

        private void CheckToggle()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                // Si el interruptor está encendido lo apagamos, y al revés
                if (this.isOn)
                {
                    Debug.Log("Apagamos el interruptor");
                    this.isOn = false;
                }
                else
                {
                    Debug.Log("Encendemos el interruptor");
                    this.isOn = true;
                }

                // Invocamos el evento para propagarlo
                this.OnSwitchToggle.Invoke(this.isOn);
            }
        }
    }
}
