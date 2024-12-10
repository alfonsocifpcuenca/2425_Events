using UnityEngine.Events;

namespace Scene_03
{
    /// <summary>
    /// Manager para centralizar los eventos
    /// </summary>
    public class EventsManager
    {
        // Variable que contiene el evento que admite como parámetro un bool
        public UnityEvent<bool> OnSwitchToggle = new UnityEvent<bool>();
    }
}
