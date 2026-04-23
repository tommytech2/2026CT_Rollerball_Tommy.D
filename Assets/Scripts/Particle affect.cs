using UnityEngine;

public class LockRotation : MonoBehaviour
{
    private Quaternion fixedRotation;

    void Start()
    {
        fixedRotation = transform.rotation; // store starting rotation
    }

    void LateUpdate()
    {
        transform.rotation = fixedRotation; // force rotation to stay the same
    }
}
