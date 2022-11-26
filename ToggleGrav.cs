using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class ToggleGrav : MonoBehaviour
{
//apply script to contoller gameobject
        private XRController controller = null;
        public GameObject Player;
        public Rigidbody PlayerRB;
        public Transform Cam;
        //extra fly varibles and stuff because this has built in camera directon flying 
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
    //toggle gravity with A
                if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primary)) {
                    if (primary) {
                PlayerRB.useGravity = false;
                    }else {
                        PlayerRB.useGravity = true; 
                    }
                }
                //fly with B
                                if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool sec)) {
                    if (sec) {
                        if (fly) {
                        PlayerRB.AddForce(Cam.forward * speed);}
                     }   
    }
    }
}
