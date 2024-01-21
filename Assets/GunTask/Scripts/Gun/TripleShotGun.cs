using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PatternLessons.GunTask
{
    public class TripleShotGun : IGun
    {
        private int _ammoCount;
        private float _ammoInterval = 1f;
        private Transform _shotPoint;
        private GameObject _bullet;


        public TripleShotGun(int ammoCount, Transform shotPoint, GameObject bullet)
        {
            _ammoCount = ammoCount;
            _shotPoint = shotPoint;
            _bullet = bullet;
        }
        public void Shoot()
        {
            if (_ammoCount < 3)
            {
                Debug.Log("Haven`t any ammo");
                return;
            }

            GameObject rightBullet = GameObject.Instantiate(_bullet, _shotPoint.position + _shotPoint.right * _ammoInterval, Quaternion.identity) as GameObject;
            GameObject midleBullet = GameObject.Instantiate(_bullet, _shotPoint.position , Quaternion.identity) as GameObject;
            GameObject leftBullet = GameObject.Instantiate(_bullet, _shotPoint.position - _shotPoint.right * _ammoInterval, Quaternion.identity) as GameObject;
            _ammoCount -= 3;
        }
    }
}
