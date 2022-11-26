using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class IronMonke : MonoBehaviour
{
//apply script to contoller gameobject
            private XRController controller = null;
        public GameObject Player;
        public Transform Hand;
        public Rigidbody PlayerRB;
        //player camera (unused)
        public Transform Cam;
        public float speed = 2f;
        //toggle this to true if left hand because the left hand has inverted values 
        public bool leftHand = false;
    // Start is called before the first frame update
    void Start()
    {
         controller = GetComponent<XRController>();
    }

    // Update is called once per frame
    void Update()
    {
          if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool sec)) {
                if (sec) {
                    if (!leftHand) {
                 PlayerRB.AddForce(Hand.right * speed);
                    }else {
                        PlayerRB.AddForce(-Hand.right * speed);
                    }
                    }   
             }
    }
}
