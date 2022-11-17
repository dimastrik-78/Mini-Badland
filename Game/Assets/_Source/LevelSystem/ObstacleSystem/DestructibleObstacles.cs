using UnityEngine;

namespace _Source.LevelSystem.ObstacleSystem
{
    public class DestructibleObstacles : MonoBehaviour
    {
        [SerializeField] private int power;
    
        private Rigidbody2D _rb;
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();

            transform.parent = null; // чтобы при повороте объект выглядел нормально
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.layer == 3)
                _rb.AddForce(new Vector2(power , 0), ForceMode2D.Impulse);
        }
    }
}
