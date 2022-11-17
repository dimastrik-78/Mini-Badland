using System;
using UnityEngine;

namespace _Source.PlayerSystem
{
    public class Player : MonoBehaviour
    {
        public static Action OnEndGame;
        
        [SerializeField] private Vector2 vector;
        [SerializeField] private float speedRotation;

        private PlayerModel _playerModel;
        private PlayerController _playerController;
        private PlayerInput _playerInput;
        
        void Awake()
        {
            _playerModel = new PlayerModel(gameObject.GetComponent<Rigidbody2D>(), vector, speedRotation);
            _playerController = new PlayerController(_playerModel);
            _playerInput = new PlayerInput(_playerModel, _playerController);
        }

        void Update()
        {
            _playerInput.Update();

            if (_playerModel.RB.transform.position.x < Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x) 
                OnEndGame?.Invoke();
        }
    }
}