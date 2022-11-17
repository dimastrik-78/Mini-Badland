using UnityEngine;

namespace _Source.PlayerSystem
{
    public class PlayerController
    {
        private PlayerModel _playerModel;
        public PlayerController(PlayerModel playerModel)
        {
            _playerModel = playerModel;
        }
        public void Fly()
        {
            _playerModel.RB.AddForce(new Vector2(0, _playerModel.Vector.y), ForceMode2D.Impulse);

            if (_playerModel.RB.transform.eulerAngles.z > 180)
            {
                _playerModel.RB.AddTorque(_playerModel.SpeedRotation);
            }
            else if (_playerModel.RB.transform.eulerAngles.z < 180)
            {
                _playerModel.RB.AddTorque(-_playerModel.SpeedRotation);
            }
        }

        public void Move()
        {
            _playerModel.RB.velocity = new Vector2(Input.GetAxis("Horizontal") * _playerModel.Vector.x ,_playerModel.RB.velocity.y);
        }
    }
}
