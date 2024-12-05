using UnityEngine.Events;

namespace Scene_03
{
    public class EventsManager
    {
        public UnityEvent<bool> OnSwitchToggle = new UnityEvent<bool>();
    }
}
