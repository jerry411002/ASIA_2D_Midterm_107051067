
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Text textcount;
    public int count;
    public GameObject final;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            final.SetActive(true);
        }
        if (collision.tag == "鑽石")
        {
            Destroy(collision.gameObject);
            count++;
            textcount.text = "Gem:" + count;
        }
    }


}
