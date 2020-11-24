using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CustomClasses
{
    public class UIManager : MonoBehaviour
    {
        #region Singleton
        private static UIManager _instance;
        public static UIManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType<UIManager>();
                }
                return _instance;
            }
        }
        #endregion

        private void Awake()
        {
            
        }

        public Text name, fireRate, ammoCount;

        public void UpdateWeaponStats(WeaponStats weapon)
        {
            name.text += weapon.name;
            fireRate.text += weapon.fireRate;
            ammoCount.text += weapon.ammoCount;
        }
    }
}
