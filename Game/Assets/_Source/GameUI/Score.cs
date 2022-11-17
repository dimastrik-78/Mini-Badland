using _Source.PlayerSystem;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.GameUI
{
    public class Score : MonoBehaviour
    {
        [SerializeField] private Text text;
        
        private int _score;

        private void Awake()
        {
            PlayerCollision.OnFinishLevel += GetScore;
            Pause.OnRestart += ResetScore;
            
            if (PlayerPrefs.HasKey("_score"))
                _score = PlayerPrefs.GetInt("_score");
            
            UpdateScore();
        }

        private void ResetScore()
        {
            PlayerPrefs.SetInt("_score", 0);
            PlayerPrefs.Save();
            
            Pause.OnRestart -= ResetScore;
        }
        
        private void GetScore()
        {
            _score++;
            PlayerPrefs.SetInt("_score", _score);
            PlayerPrefs.Save();
            
            PlayerCollision.OnFinishLevel -= GetScore;
            
            UpdateScore();
        }
        private void UpdateScore() => text.text = _score.ToString();
    }
}
