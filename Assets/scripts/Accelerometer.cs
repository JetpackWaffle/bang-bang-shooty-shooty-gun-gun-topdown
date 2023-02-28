using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    float speed = 10.0f;

    void Update()
    {
        Vector3 dir = Vector3.zero;
        // we assume that the device is held parallel to the ground
        // and the Home button is on bottom

        dir.y = Input.acceleration.y;
        dir.x = Input.acceleration.x;

        // clamp acceleration vector to the unit sphere
        if (dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }
            

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        transform.Translate(dir * speed);
    }
}
