using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class ToggleGrav : MonoBehaviour
{
        private XRController controller = null;
        public GameObject Player;
        public Rigidbody PlayerRB;
        public Transform Cam;
        public bool fly = false;
        public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
         controller = GetComponent<XRController>();

    }

    // Update is called once per frame
    void Update()
    {
                if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primary)) {
                    if (primary) {
                PlayerRB.useGravity = false;
                    }else {
                        PlayerRB.useGravity = true; 
                    }
                }
                                if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool sec)) {
                    if (sec) {
                        if (fly) {
                        PlayerRB.AddForce(Cam.forward * speed);}
                     }   
    }
    }
}
