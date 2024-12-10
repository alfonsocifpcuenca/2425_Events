using UnityEngine;

namespace Scene_02
{
    public class Lightbulb : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            // Obtenemos el spriteRenderer del GameObject
            this.spriteRenderer = GetComponent<SpriteRenderer>();

            // Buscamos el interruptor, obtenemos su script y si existen ambos nos suscribimos
            // al evento, es decir, cuando Switch invoque el evento, el componente actuar� llamando
            // a ToggleLightbulb
            GameObject _switch = GameObject.FindGameObjectWithTag("Switch");
            if (_switch != null)
            {
                Switch _switchScript = _switch.GetComponent<Switch>();
                if (_switchScript != null)
                {
                    // Cuando ocurra el evento, ejecutamos el m�todo indicado (ojo, el m�todo tiene un par�metro del
                    // mismo tipo que declaramos el UnityEvent en Switch.cs)
                    _switchScript.OnSwitchToggle.AddListener(ToggleLightbulb);
                }
            }
        }

        /// <summary>
        /// M�todo que cambia el estado de la bombilla en funci�n del parametro
        /// </summary>
        /// <param name="turnOn">Boolean para indicar si debemos encender o apagar la bombilla</param>
        public void ToggleLightbulb(bool turnOn)
        {
            if (turnOn)
            {
                // Cambiamos el color del sprite a amarillo (encendida)
                this.spriteRenderer.color = Color.yellow;
            }
            else
            {
                // Cambiamos el color del sprite a gris (apagada)
                this.spriteRenderer.color = Color.gray;
            }
        }
    }
}
