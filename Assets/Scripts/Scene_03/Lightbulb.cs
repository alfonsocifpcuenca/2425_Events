using UnityEngine;

namespace Scene_03
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Lightbulb : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            // Obtenemos el spriteRenderer del GameObject
            this.spriteRenderer = GetComponent<SpriteRenderer>();

            // Nos suscribimos al evento OnSwitchToggle del GameManager, es decir, cuando este evento
            // se invoque, este objeto reaccionará ejecutando ToggleLightbulb
            GameManager.Instance.EventsManager.OnSwitchToggle.AddListener(ToggleLightbulb);
        }

        /// <summary>
        /// Método que cambia el estado de la bombilla en función del parametro
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
