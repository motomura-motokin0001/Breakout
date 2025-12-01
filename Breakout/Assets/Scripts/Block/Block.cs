using BrickBreaker.Event;
using UnityEngine;

namespace BrickBreaker.Block
{
    public class Block : MonoBehaviour
    {
        private int DefaultScore = 10;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
            if (collision.gameObject.tag == "Ball")
            {
                EventService.AddScore(DefaultScore);
                Destroy(this.gameObject);
            }
        }
    }
}
