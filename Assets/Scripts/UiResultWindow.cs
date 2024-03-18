using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class UiResultWindow : MonoBehaviour
    {
        public Text Header;
        public Text ResultText;
        public AudioClip[] FailJingles;
        public AudioClip[] WinJingles;
        public Button ButtonNewGame;

        public AudioSource As;

        public GameObject Fireworks;

        //////////////////////////
        // public methods
        /////////////////////////

        public void Show(bool win)
        {
            gameObject.SetActive(true);

            System.Random rnd=new System.Random();

            if (win)
            {
                Header.text = "¡Puerta Grande!";
                ResultText.text = string.Format("¡Tomaaaaa! El solitario se jugó con éxito en {0} minutos {1} segundos", Game.Instance.GameTimer.Minutes, Game.Instance.GameTimer.Seconds);
                As.clip = WinJingles[rnd.Next(WinJingles.Length)];

                Fireworks.SetActive(true);
            }
            else
            {
                Header.text = "¡Qué fracaso!";

                ResultText.text = string.Format("Desafortunadamente,has palmao, inténtalo de nuevo");
                As.clip = FailJingles[rnd.Next(FailJingles.Length)];
            }

            As.Play();
        }
        

        //////////////////////////
        // private methods
        /////////////////////////

        void Start ()
        {
            ButtonNewGame.onClick.AddListener((() =>
            {
                gameObject.SetActive(false);
                Game.Instance.Menu.Show(true);
                Fireworks.SetActive(false);
            }));
        }
	
        void Update () {
	
        }
    }
}
