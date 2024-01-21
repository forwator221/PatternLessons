using UnityEngine;

namespace PatternLessons.GunTask
{
    public class InfinityAmmoGun : IGun
    {
        private Transform _shotPoint;
        private GameObject _bullet;

        public InfinityAmmoGun(Transform shotPoint, GameObject bullet)
        {
            _shotPoint = shotPoint;
            _bullet = bullet;
        }

        public void Shoot()
        {
            GameObject bullet = GameObject.Instantiate(_bullet, _shotPoint.position, Quaternion.identity) as GameObject;
        }
    }
}
