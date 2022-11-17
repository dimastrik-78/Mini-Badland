using System.Collections.Generic;
using _Source.GameUI;
using _Source.PlayerSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace _Source.Core
{
    public class Game
    {
        private System.Random _random;
        public Game(GameObject player, Transform playerSpawn, List<GameObject> levels, Transform levelSpawn)
        {
            _random = new System.Random();
            StartGame(player, playerSpawn, levels, levelSpawn);
        }

        private void StartGame(GameObject player, Transform playerSpawn, List<GameObject> levels, Transform levelSpawn)
        {
            Object.Instantiate(player, playerSpawn).name = "Player";
            Object.Instantiate(levels[_random.Next(0, levels.Count)], levelSpawn);
        
            Time.timeScale = 1;
        
            Pause.OnPause += PauseGame;
            Pause.OnRestart += EndGame;
            Player.OnEndGame += EndGame;
        }

        private void PauseGame()
        {
            Time.timeScale = 0;
        
            Pause.OnPause -= PauseGame;
            Pause.OnContinue += ContinueGame;
        }

        private void ContinueGame()
        {
            Time.timeScale = 1;
        
            Pause.OnContinue -= ContinueGame;
            Pause.OnPause += PauseGame;
        }

        private void EndGame()
        {
            SceneManager.LoadScene(0);
            
            Pause.OnRestart -= EndGame;
            Player.OnEndGame -= EndGame;
        }
    }
}
