using UnityEngine;

namespace PatternLessons.GunTask
{
    public class Bullet : MonoBehaviour, IBullet
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _lifeTime = 2f;

        private void Start()
        {
            Destroy(gameObject, _lifeTime);
        }

        private void Update()
        {
            Move();
        }

        public void Move()
        {
            transform.Translate(transform.forward * _speed * Time.deltaTime);
        }
    }
}
