using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
    public class Boostrapper : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private Transform playerSpawn;
        [SerializeField] private List<GameObject> levelPrefabs;
        [SerializeField] private Transform levelSpawn;
    
        private Game _game;
        void Awake()
        {
            _game = new Game(playerPrefab, playerSpawn, levelPrefabs, levelSpawn);
        }
    }
}
