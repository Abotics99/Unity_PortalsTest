
using UnityEngine;

public class PortalCamera : MonoBehaviour {

    public Transform playerCam;
    public Transform connectedPortal;
    Vector3 cameraPos;
    Quaternion cameraRot;
    public Vector3 rotationOffsets;
    public bool invertY;

    private void LateUpdate()
    {
        cameraPos.x = (connectedPortal.transform.InverseTransformPoint(playerCam.transform.position).x * connectedPortal.localScale.x) + connectedPortal.localPosition.x;
        cameraPos.y = (connectedPortal.transform.InverseTransformPoint(playerCam.transform.position).z * -connectedPortal.localScale.z) + connectedPortal.localPosition.y;
        cameraPos.z = (connectedPortal.transform.InverseTransformPoint(playerCam.transform.position).y * connectedPortal.localScale.y) + connectedPortal.localPosition.z;
        transform.localPosition = cameraPos;
        
        transform.localRotation = Quaternion.Euler(playerCam.transform.eulerAngles.x, -connectedPortal.eulerAngles.y + playerCam.transform.eulerAngles.y, 0) * Quaternion.Euler(rotationOffsets);
    }
}
