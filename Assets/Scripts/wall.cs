using UnityEngine;

public class SideToSide : MonoBehaviour
{
    public float speed = 3f;         
    public float distance = 3f;       

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * distance;
        transform.position = startPos + new Vector3(offset, 0, 0);
    }
}
