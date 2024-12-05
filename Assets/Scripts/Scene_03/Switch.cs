using UnityEngine;
using UnityEngine.Rendering;

namespace Scene_03
{
    public class Switch : MonoBehaviour
    {
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
                GameManager.Instance.EventsManager.OnSwitchToggle.Invoke(this.isOn);
            }
        }
    }
}
