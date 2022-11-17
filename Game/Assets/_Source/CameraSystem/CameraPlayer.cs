using UnityEngine;

namespace _Source.CameraSystem
{
    public class CameraPlayer : MonoBehaviour
    {
        [SerializeField] private float speed;
        
        private Transform _playerPosition;
        private CameraMove _cameraMove;
        private Rigidbody _rb;
        void Awake()
        {
            _cameraMove = new CameraMove();

            _rb = GetComponent<Rigidbody>();

            _playerPosition = GameObject.Find("Player").transform;
        }

        void Update()
        {
            if (_playerPosition.position.x >= Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x - 4)
            {
                _cameraMove.Move(_rb, speed + 2);
            }
            else
            {
                _cameraMove.Move(_rb, speed);
            }
        }
    }
}
