using Scene_03;
using UnityEngine;

namespace Scene_01
{
    public class Lightbulb : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            // Obtenemos el sprteRenderer
            this.spriteRenderer = GetComponent<SpriteRenderer>();
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
