using UnityEngine;

namespace Somewhere {

    /// <summary>
    /// ???
    /// </summary>
    class LightSwitch : MonoBehaviour {

        public GameObject lightSwitchGameObj;

        /// <summary>
        /// Updates the object.
        /// </summary>
        private void Update() {
            if (Input.GetKeyDown(KeyCode.Space)) {
                lightSwitchGameObj.SetActive(!lightSwitchGameObj.activeSelf);
            }
        }
    }
}