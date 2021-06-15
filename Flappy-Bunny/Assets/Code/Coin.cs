using UnityEngine;
using UnityEngine.UI;


namespace BunnyFlappy
{
    internal sealed class Coin : MonoBehaviour
    {
        #region Fields

        [SerializeField] private int _score = 10;

        #endregion


        #region UnityMethods

        private void OnTriggerEnter2D(Collider2D collision)
        {
            CheckTheCollision(collision);
        }

        #endregion


        #region Methods

        private void CheckTheCollision(Collider2D collider)
        {
            if (collider.gameObject.CompareTag(Constants.CharacterTag))
            {
                Score.ScoreAmount += _score;
                Destroy(gameObject);
            }
        }

        #endregion
    }
}
