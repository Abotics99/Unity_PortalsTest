using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class turnTest : MonoBehaviour {

    public Vector3 rotations;
    private FirstPersonController firstpersoncontroller;

    private void Start()
    {
        firstpersoncontroller = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update () {
        transform.rotation = Quaternion.Euler(rotations);
        firstpersoncontroller.mouseReset();
    }
}
