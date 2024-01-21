using UnityEngine;

namespace PatternLessons.GunTask
{
    public class CommonGun : IGun
    {
        private int _ammoCount;
        private Transform _shotPoint;
        private GameObject _bullet;

        public CommonGun(int ammoCount, Transform shotPoint, GameObject bullet)
        {
            _ammoCount = ammoCount;
            _shotPoint = shotPoint;
            _bullet = bullet;
        }

        public void Shoot()
        {
            if (_ammoCount == 0)
            {
                Debug.Log("Haven`t any ammo");
                return;
            }
                
            GameObject bullet = GameObject.Instantiate(_bullet, _shotPoint.position, Quaternion.identity) as GameObject;
            _ammoCount--;
        }
    }
}
