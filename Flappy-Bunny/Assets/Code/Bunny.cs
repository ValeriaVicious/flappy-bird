using UnityEngine;
using UnityEngine.SceneManagement;


namespace BunnyFlappy
{
    internal sealed class Bunny : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _force = 300;
        [SerializeField] private float _speed = 5.0f;

        private Rigidbody2D _rigidbody;

        #endregion


        #region UnityMethos

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
             MoveTheBunny();
        }

        private void Update()
        {
            CheckTheUserInput();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Constants.ObstacleTag))
            {
                SceneManager.LoadScene(Constants.NumberOfGameScene);
            }
            if (collision.gameObject.CompareTag(Constants.ColliderTag))
            {
                return;
            }

        }

        #endregion


        #region Methods

        private void CheckTheUserInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody.AddForce(Vector2.up * _force);
            }
        }

        private void MoveTheBunny()
        {
            _rigidbody.velocity = Vector2.right * _speed;
        }

        #endregion
    }
}
