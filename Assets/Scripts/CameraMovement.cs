using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform CameraHolder;
    public float PlaneViewSensetivity = 10;
    public float RotationSensetivity = 100;

    public KeyCode RotationKey = KeyCode.Mouse1;
    private void Update()
    {
        PlaneMove();
        if(Input.GetKey(RotationKey)) RotMove();
    }
    void PlaneMove()
    {
        float xMove = Input.GetAxis("Horizontal") * PlaneViewSensetivity * Time.deltaTime;
        float yMove = Input.GetAxis("Vertical") * PlaneViewSensetivity * Time.deltaTime;

        CameraHolder.Translate(CameraHolder.InverseTransformDirection(CameraHolder.forward) * yMove);
        CameraHolder.Translate(CameraHolder.InverseTransformDirection(CameraHolder.right) * xMove);
    }
    void RotMove()
    {
        float xRot = Input.GetAxis("Mouse X") * RotationSensetivity * 10 * Time.deltaTime;
        float yRot = Input.GetAxis("Mouse Y") * RotationSensetivity * 10 * Time.deltaTime;

        CameraHolder.Rotate(Vector3.up * xRot);
    }
}
