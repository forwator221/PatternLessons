using UnityEngine;

namespace PatternLessons.GunTask
{
    public class Bootstrap: MonoBehaviour
    {
        [SerializeField] private Character _character;

        [Header("Gun Params")]
        [SerializeField] private GameObject _bullet;
        [SerializeField, Range(1, 100)] private int _commonGunAmmoCount;
        [SerializeField, Range(3, 99)] private int _tripleGunAmmoCount;

        private void Awake()
        {
            _character.Initialize(
                new CommonGun(_commonGunAmmoCount,_character.GunHolder, _bullet), 
                _bullet,
                _commonGunAmmoCount,
                _tripleGunAmmoCount
                );
        }
    }
}
