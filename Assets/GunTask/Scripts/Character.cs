using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PatternLessons.GunTask
{
    public class Character : MonoBehaviour
    {
        private IGun _gun;
        private GameObject _bullet;
        private int _commonGunAmmoCount;
        private int _tripleGunAmmoCount;

        [SerializeField] private Transform _gunHolder;

        public Transform GunHolder => _gunHolder;

        public void Initialize(IGun gun, GameObject bullet, int commonGunAmmoCount, int tripleGunAmmoCount)
        {
            _gun = gun;
            _bullet = bullet;
            _commonGunAmmoCount = commonGunAmmoCount;
            _tripleGunAmmoCount = tripleGunAmmoCount;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _gun.Shoot();
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _gun = new CommonGun(_commonGunAmmoCount, GunHolder, _bullet);
                Debug.Log($"You change gun to {_gun}");
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _gun = new InfinityAmmoGun(GunHolder, _bullet);
                Debug.Log($"You change gun to {_gun}");
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _gun = new TripleShotGun(_tripleGunAmmoCount, GunHolder, _bullet);
                Debug.Log($"You change gun to {_gun}");
            }
        }

    }
}

