using Scene_03;
using UnityEngine;

namespace Scene_02
{
    public class Lightbulb : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        private void Awake()
        {
            // Obtenemos el sprteRenderer
            this.spriteRenderer = GetComponent<SpriteRenderer>();

            // Nos suscribimos al evento del switch
            GameObject _switch = GameObject.FindGameObjectWithTag("Switch");
            if (_switch != null)
            {
                Switch _switchScript = _switch.GetComponent<Switch>();
                if (_switchScript != null)
                {
                    _switchScript.OnSwitchToggle.AddListener(ToggleLightbulb);
                }
            }
        }

        public void ToggleLightbulb(bool turnOn)
        {
            if (turnOn)
            {
                this.spriteRenderer.color = Color.yellow;
            }
            else
            {
                this.spriteRenderer.color = Color.gray;
            }
        }
    }
}
