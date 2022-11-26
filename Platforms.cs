using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class Platforms : MonoBehaviour
{
        private XRController controller = null;
        public float platDis = 0.07f;
        public Transform position;
        public GameObject PlatPref;
        private GameObject Platform;
        public bool pressed = false;
        public bool platforming = false;
    // Start is called before the first frame update
    void Start()
    {//  Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);

        Platform = Instantiate(PlatPref, position.position, Quaternion.identity);
              controller = GetComponent<XRController>();
    }

    // Update is called once per frame
    void Update()
    {
              if (controller.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool grip)) {
               if (grip) {
                   Debug.Log("Grip");
                   if (!pressed) {
                   pressed = true;
                   platforming = true;
                   Platform.SetActive(true);
                   Platform.transform.position = new Vector3(position.position.x,position.position.y,position.position.z);
                   Platform.transform.rotation = position.rotation;
                   Platform.transform.Rotate(new Vector3(0,0,90));
                   Platform.transform.Translate(0,platDis,0);
                   }
               }else {
                       pressed = false;
                       Platform.SetActive(false);
                   }
              }
    }
}
