using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolerSoft.Interatic
{
    public class Scaler : MonoBehaviour
    {
        #region Private Fields
        private const float SMALL_SCALE = 0.8f;
        #endregion Private Fields

        #region Public Methods

        public void MakeNormal()
        {
            transform.localScale = Vector3.one;
        }

        public void MakeSmaller()
        {
            transform.localScale = new Vector3(SMALL_SCALE, SMALL_SCALE, SMALL_SCALE);
        }

        #endregion Public Methods
    }
}