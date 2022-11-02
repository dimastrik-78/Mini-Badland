using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace _Source.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Vector2 vector;
        [SerializeField] private float speedRotation;
        
        private PlayerModel _playerModel;
        private PlayerView _playerView;
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
        }
    }
}