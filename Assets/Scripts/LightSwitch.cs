using UnityEngine;

namespace Somewhere {

    /// <summary>
    /// 
    /// </summary>
    class LightSwitch : MonoBehaviour {

        public GameObject gameObj;

        /// <summary>
        /// Updates the object.
        /// </summary>
        private void Update() {
            if (Input.GetKeyDown(KeyCode.Space)) {
                gameObj.SetActive(!gameObj.activeSelf);
            }
        }
    }
}