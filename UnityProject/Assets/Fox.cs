using UnityEngine;

namespace LP
{
    public class Fox : MonoBehaviour
    {
        #region 欄位
        [Header("移動速度"), Range(0, 50)]
        public float Speed;
        public Rigidbody2D Rig;
        public SpriteRenderer Sr;
        #endregion
        #region 方法
        
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

