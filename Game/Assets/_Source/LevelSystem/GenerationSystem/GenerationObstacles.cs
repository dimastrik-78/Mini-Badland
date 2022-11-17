using System.Collections.Generic;
using UnityEngine;

namespace _Source.LevelSystem.GenerationSystem
{
    public class GenerationObstacles : MonoBehaviour
    {
        [SerializeField] private List<GameObject> obstacles;
        [SerializeField] private int initialLimit;

        private System.Random _random;

        void Awake()
        {
            _random = new System.Random();
            
            SelectObstacles();
        }

        private void SelectObstacles()
        {
            int limitObstacles = 0;
            int randomObstacle;
            
            while (limitObstacles < obstacles.Count 
                   && limitObstacles < PlayerPrefs.GetInt("_score") + initialLimit)
            {
                randomObstacle = _random.Next(0, obstacles.Count);
                
                if (_random.Next(0, 2) == 1 && !obstacles[randomObstacle].activeSelf)
                {
                    obstacles[randomObstacle].SetActive(true);
                    
                    limitObstacles++;
                }
            }
        }
    }
}
