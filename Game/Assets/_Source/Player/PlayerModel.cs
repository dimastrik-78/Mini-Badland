using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Player
{
    public class PlayerModel
    {
        public Rigidbody2D RB;
        public Vector2 Vector;
        public float SpeedRotation;
        public PlayerModel(Rigidbody2D rb, Vector2 vector, float speedRotation)
        {
            RB = rb;
            Vector = vector;
            SpeedRotation = speedRotation;
        }
    }
}