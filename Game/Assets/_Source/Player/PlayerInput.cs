using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace _Source.Player
{
    public class PlayerInput
    {
        private PlayerModel _playerModel;
        private PlayerController _playerController;
        public PlayerInput(PlayerModel playerModel, PlayerController playerController)
        {
            _playerModel = playerModel;
            _playerController = playerController;
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _playerController.Fly();
            }

            if (Input.GetAxis("Horizontal") != 0)
            {
                _playerController.Move();
            }
        }
    }
}
