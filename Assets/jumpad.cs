using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 15f;
    public Vector3 launchDirection = new Vector3(0, 1, 1); // up + forward

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();

        if (player != null)
        {
            Vector3 dir = launchDirection.normalized; // make sure it's a clean direction
            player.LaunchUpward(jumpForce, dir);
        }
    }

}

