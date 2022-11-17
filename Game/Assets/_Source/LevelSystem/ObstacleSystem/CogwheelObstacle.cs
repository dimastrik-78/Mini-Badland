using System;
using UnityEngine;

namespace _Source.LevelSystem.ObstacleSystem
{
    public class CogwheelObstacle : MonoBehaviour
    {
        [SerializeField] private float speedRotation;

        private void Start()
        {
            transform.parent = null; // чтобы при повороте объект выглядел нормально
        }

        private void Update()
        {
            gameObject.transform.Rotate(0, 0, -speedRotation);
        }
    }
}
