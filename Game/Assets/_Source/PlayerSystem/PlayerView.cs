using UnityEngine;

namespace _Source.PlayerSystem
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private float scaleEdit;

        private Rigidbody2D _rb;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public void Increase()
        {
            gameObject.transform.localScale *= scaleEdit;
            _rb.mass *= scaleEdit;
        }

        public void Reduction()
        {
            gameObject.transform.localScale /= scaleEdit;
            _rb.mass /= scaleEdit;
        }
    }
}
