using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public bool isInverted;
    public float smooth = 0.5f;
    public bool lookAtPlayer = false;
    public bool rotateAroundPlayer = true;
    public float rotationSpeed = 2.0f;
   


    void Start()
    {
        transform.position = player.position + offset;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        if (rotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(mouseX, Vector3.up);
            player.Rotate(Vector3.up, mouseX);
            offset = camTurnAngle * offset;
        }
        
        Vector3 newPos = player.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smooth);

        if (lookAtPlayer || rotateAroundPlayer)
        {
            transform.LookAt(player);
        }
    }

    void YInversion()
    {

    }
}
