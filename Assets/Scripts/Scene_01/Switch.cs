using Scene_03;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Scene_01
{
    public class Switch : MonoBehaviour
    {
        private bool isOn = false;

        // Update is called once per frame
        void Update()
        {
            CheckToggle();

        }

        private void CheckToggle()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (this.isOn)
                {
                    this.isOn = false;
                }
                else
                {
                    this.isOn = true;
                }

                List<GameObject> lightbulbs = GameObject.FindGameObjectsWithTag("Lightbulb").ToList();

                foreach (GameObject lightbulb in lightbulbs) { 
                    Lightbulb lightbulbScript = lightbulb.GetComponent<Lightbulb>();

                    if (lightbulbScript != null)
                    {
                        lightbulbScript.ToggleLightbulb(this.isOn);
                    }
                }
            }
        }
    }
}
