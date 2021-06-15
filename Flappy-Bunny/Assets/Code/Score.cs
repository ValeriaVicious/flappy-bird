using UnityEngine;
using UnityEngine.UI;


namespace BunnyFlappy
{
    internal sealed class Score : MonoBehaviour
    {
        #region Fields

        private Text _scoreText;
        public static int ScoreAmount;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _scoreText = GetComponent<Text>();
            ScoreAmount = 0;
        }

        private void Update()
        {
            UpdateTheText();
        }

        #endregion


        #region Methods

        private void UpdateTheText()
        {
            _scoreText.text = " x " + ScoreAmount;
        }

        #endregion
    }
}