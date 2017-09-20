using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PortalScript : MonoBehaviour {

    public GameObject playerObj;
    private GameObject playerCam;
    public Transform targetCam;
    bool playerInPortal;
    float playerDir;
    float playerPos1;
    float playerPos2;
    public Vector3 rotations;
    private FirstPersonController firstpersoncontroller;

    private void Start()
    {
        playerCam = playerObj.transform.GetChild(0).gameObject;
        firstpersoncontroller = playerObj.GetComponent<FirstPersonController>();
    }

    private void FixedUpdate()
    {
        playerDir = playerPos2 - transform.InverseTransformPoint(playerObj.transform.position).y;
        if (playerInPortal && playerDir > 0)
        {
            playerObj.transform.position = targetCam.transform.position + new Vector3(0, -playerCam.transform.localPosition.y, 0);
            //playerObj.transform.rotation = Quaternion.Euler(0, targetCam.transform.localEulerAngles.y, 0);
            //firstpersoncontroller.mouseReset();
        }
        playerPos2 = transform.InverseTransformPoint(playerObj.transform.position).y;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerInPortal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            playerInPortal = false;
        }
        
    }
}
