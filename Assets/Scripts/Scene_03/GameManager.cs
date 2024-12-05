using UnityEngine;
using UnityEngine.Events;

namespace Scene_03
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    GameObject gameManager = new GameObject();
                    gameManager.name = "GameManager";
                    instance = gameManager.AddComponent<GameManager>();

                    instance.EventsManager = new EventsManager();
                }

                return instance;
            }
        }

        // Submanager de eventos
        public EventsManager EventsManager;
    }
}
