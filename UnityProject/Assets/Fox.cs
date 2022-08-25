using UnityEngine;

namespace LP
{
    public class Fox : MonoBehaviour
    {
        #region ���
        [Header("���ʳt��"), Range(0, 50)]
        public float Speed;
        public Rigidbody2D Rig;
        public SpriteRenderer Sr;
        #endregion
        #region ��k
        
        private void move()
        {
            float Speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
            transform.Rotate(0, Speed, 0);
            Rig.AddForce(new Vector2(0, 0));
            Sr.flipX = true;
        }

        #endregion
        private void Update()
        {
            move() ;
        }
        private void Start()
        {
        }
    }
}

