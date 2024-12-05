using UnityEngine;

namespace Scene_03
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Lightbulb : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            // Obtenemos el sprteRenderer
            this.spriteRenderer = GetComponent<SpriteRenderer>();

            // Nos suscribimos al evento
            GameManager.Instance.EventsManager.OnSwitchToggle.AddListener(ToggleLightbulb);
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
