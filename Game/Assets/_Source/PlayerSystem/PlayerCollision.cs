using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Source.PlayerSystem
{
    public class PlayerCollision : MonoBehaviour
    {
        public static Action OnFinishLevel;
        
        [SerializeField] private PlayerView playerView;
        private void OnCollisionEnter2D(Collision2D collision2D)
        {
            switch (collision2D.gameObject.layer)
            {
                case 6:
                    Player.OnEndGame?.Invoke();
                    break;
                case 7:
                    Destroy(collision2D.gameObject);
                    playerView.Increase();
                    break;
                case 8:
                    Destroy(collision2D.gameObject);
                    playerView.Reduction();
                    break;
                case 9:
                    OnFinishLevel?.Invoke();
                    SceneManager.LoadScene(0);
                    break;
            }
        }
    }
}
