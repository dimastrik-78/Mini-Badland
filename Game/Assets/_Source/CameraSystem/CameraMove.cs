using UnityEngine;

namespace _Source.CameraSystem
{
    public class CameraMove
    {
        public void Move(Rigidbody rb, float speed)
        {
            rb.velocity = new Vector3(speed, 0);
        }
    }
}
