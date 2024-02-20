using UnityEngine;
using UnityEngine.UI;


public class BolmeRastgeleBalon : MonoBehaviour
{
    //animasyonlar
    public RuntimeAnimatorController sol2Controller;
    public RuntimeAnimatorController sol1Controller;
    public RuntimeAnimatorController ortaController;
    public RuntimeAnimatorController sag1Controller;
    public RuntimeAnimatorController sag2Controller;
    //sayac
    private float sure = 0f;
    //Secekler
    int rastgeleSayi;
    //ZorlukArtiriciZaman
    public float time = 0f;
    //GameObjectler
    public GameObject B1, B2, B3, B4, B5, B6, B7, B8, B9, B10;
    public GameObject B11, B12, B13, B14, B15, B16, B17, B18, B19, B20;
    public GameObject B21, B22, B23, B24, B25, B26, B27, B28, B29, B30;
    public GameObject B31, B32, B33, B34, B35, B36, B37, B38, B39, B40;
    public GameObject B41, B42, B43, B44, B45, B46, B47, B48, B49, B50;
    public GameObject B51, B52, B53, B54, B55, B56, B57, B58, B59, B60;
    public GameObject B61, B62, B63, B64, B65, B66, B67, B68, B69, B70;
    public GameObject B71, B72, B73, B74, B75, B76, B77, B78, B79, B80;
    public GameObject B81, B82, B83, B84, B85, B86, B87, B88, B89, B90;
    public GameObject B91, B92, B93, B94, B95, B96, B97, B98, B99, B100;
    public GameObject B101, B102, B103, B104, B105, B106, B107, B108, B109, B110;
    //Tranformlar
    public GameObject orta;
    //Textler
    public GameObject SonPuan;
    public Text BS1, BS2, BS3, BS4, BS5, BS6, BS7, BS8, BS9, BS10;
    public void Start()
    {
        InvokeRepeating("ToplamaSoru", 0f, 5f);
        InvokeRepeating("Sayac", 1f, 1f);
    }
    private void Sayac()
    {
        sure++;
    }
    private void ToplamaSoru()
    {
        BS1.gameObject.SetActive(false);
        BS2.gameObject.SetActive(false);
        BS3.gameObject.SetActive(false);
        BS4.gameObject.SetActive(false);
        BS5.gameObject.SetActive(false);
        BS6.gameObject.SetActive(false);
        BS7.gameObject.SetActive(false);
        BS8.gameObject.SetActive(false);
        BS9.gameObject.SetActive(false);
        BS10.gameObject.SetActive(false);


        //Animatorler
        Animator B1an = B1.GetComponent<Animator>();
        Animator B2an = B2.GetComponent<Animator>();
        Animator B3an = B3.GetComponent<Animator>();
        Animator B4an = B4.GetComponent<Animator>();
        Animator B5an = B5.GetComponent<Animator>();
        Animator B6an = B6.GetComponent<Animator>();
        Animator B7an = B7.GetComponent<Animator>();
        Animator B8an = B8.GetComponent<Animator>();
        Animator B9an = B9.GetComponent<Animator>();
        Animator B10an = B10.GetComponent<Animator>();
        Animator B11an = B11.GetComponent<Animator>();
        Animator B12an = B12.GetComponent<Animator>();
        Animator B13an = B13.GetComponent<Animator>();
        Animator B14an = B14.GetComponent<Animator>();
        Animator B15an = B15.GetComponent<Animator>();
        Animator B16an = B16.GetComponent<Animator>();
        Animator B17an = B17.GetComponent<Animator>();
        Animator B18an = B18.GetComponent<Animator>();
        Animator B19an = B19.GetComponent<Animator>();
        Animator B20an = B20.GetComponent<Animator>();
        Animator B21an = B21.GetComponent<Animator>();
        Animator B22an = B22.GetComponent<Animator>();
        Animator B23an = B23.GetComponent<Animator>();
        Animator B24an = B24.GetComponent<Animator>();
        Animator B25an = B25.GetComponent<Animator>();
        Animator B26an = B26.GetComponent<Animator>();
        Animator B27an = B27.GetComponent<Animator>();
        Animator B28an = B28.GetComponent<Animator>();
        Animator B29an = B29.GetComponent<Animator>();
        Animator B30an = B30.GetComponent<Animator>();
        Animator B31an = B31.GetComponent<Animator>();
        Animator B32an = B32.GetComponent<Animator>();
        Animator B33an = B33.GetComponent<Animator>();
        Animator B34an = B34.GetComponent<Animator>();
        Animator B35an = B35.GetComponent<Animator>();
        Animator B36an = B36.GetComponent<Animator>();
        Animator B37an = B37.GetComponent<Animator>();
        Animator B38an = B38.GetComponent<Animator>();
        Animator B39an = B39.GetComponent<Animator>();
        Animator B40an = B40.GetComponent<Animator>();
        Animator B41an = B41.GetComponent<Animator>();
        Animator B42an = B42.GetComponent<Animator>();
        Animator B43an = B43.GetComponent<Animator>();
        Animator B44an = B44.GetComponent<Animator>();
        Animator B45an = B45.GetComponent<Animator>();
        Animator B46an = B46.GetComponent<Animator>();
        Animator B47an = B47.GetComponent<Animator>();
        Animator B48an = B48.GetComponent<Animator>();
        Animator B49an = B49.GetComponent<Animator>();
        Animator B50an = B50.GetComponent<Animator>();
        Animator B51an = B51.GetComponent<Animator>();
        Animator B52an = B52.GetComponent<Animator>();
        Animator B53an = B53.GetComponent<Animator>();
        Animator B54an = B54.GetComponent<Animator>();
        Animator B55an = B55.GetComponent<Animator>();
        Animator B56an = B56.GetComponent<Animator>();
        Animator B57an = B57.GetComponent<Animator>();
        Animator B58an = B58.GetComponent<Animator>();
        Animator B59an = B59.GetComponent<Animator>();
        Animator B60an = B60.GetComponent<Animator>();
        Animator B61an = B61.GetComponent<Animator>();
        Animator B62an = B62.GetComponent<Animator>();
        Animator B63an = B63.GetComponent<Animator>();
        Animator B64an = B64.GetComponent<Animator>();
        Animator B65an = B65.GetComponent<Animator>();
        Animator B66an = B66.GetComponent<Animator>();
        Animator B67an = B67.GetComponent<Animator>();
        Animator B68an = B68.GetComponent<Animator>();
        Animator B69an = B69.GetComponent<Animator>();
        Animator B70an = B70.GetComponent<Animator>();
        Animator B71an = B71.GetComponent<Animator>();
        Animator B72an = B72.GetComponent<Animator>();
        Animator B73an = B73.GetComponent<Animator>();
        Animator B74an = B74.GetComponent<Animator>();
        Animator B75an = B75.GetComponent<Animator>();
        Animator B76an = B76.GetComponent<Animator>();
        Animator B77an = B77.GetComponent<Animator>();
        Animator B78an = B78.GetComponent<Animator>();
        Animator B79an = B79.GetComponent<Animator>();
        Animator B80an = B80.GetComponent<Animator>();
        Animator B81an = B81.GetComponent<Animator>();
        Animator B82an = B82.GetComponent<Animator>();
        Animator B83an = B83.GetComponent<Animator>();
        Animator B84an = B84.GetComponent<Animator>();
        Animator B85an = B85.GetComponent<Animator>();
        Animator B86an = B86.GetComponent<Animator>();
        Animator B87an = B87.GetComponent<Animator>();
        Animator B88an = B88.GetComponent<Animator>();
        Animator B89an = B89.GetComponent<Animator>();
        Animator B90an = B90.GetComponent<Animator>();
        Animator B91an = B91.GetComponent<Animator>();
        Animator B92an = B92.GetComponent<Animator>();
        Animator B93an = B93.GetComponent<Animator>();
        Animator B94an = B94.GetComponent<Animator>();
        Animator B95an = B95.GetComponent<Animator>();
        Animator B96an = B96.GetComponent<Animator>();
        Animator B97an = B97.GetComponent<Animator>();
        Animator B98an = B98.GetComponent<Animator>();
        Animator B99an = B99.GetComponent<Animator>();
        Animator B100an = B100.GetComponent<Animator>();
        Animator B101an = B101.GetComponent<Animator>();
        Animator B102an = B102.GetComponent<Animator>();
        Animator B103an = B103.GetComponent<Animator>();
        Animator B104an = B104.GetComponent<Animator>();
        Animator B105an = B105.GetComponent<Animator>();
        Animator B106an = B106.GetComponent<Animator>();
        Animator B107an = B107.GetComponent<Animator>();
        Animator B108an = B108.GetComponent<Animator>();
        Animator B109an = B109.GetComponent<Animator>();
        Animator B110an = B110.GetComponent<Animator>();


        //RandomSayi
        rastgeleSayi = Random.Range(1, 10);
        //
        if (sure >= 0 && sure < 45)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            switch (rastgeleSayi)
            {
                case 1:
                    BS1.gameObject.SetActive(true);

                    B24.tag = "Dogru"; B25.tag = "Yanlis"; B23.tag = "Yanlis"; B22.tag = "Yanlis"; B26.tag = "Yanlis";

                    B22an.runtimeAnimatorController = sol2Controller;
                    B23an.runtimeAnimatorController = sol1Controller;
                    B24an.runtimeAnimatorController = ortaController;
                    B25an.runtimeAnimatorController = sag1Controller;
                    B26an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B22, orta.transform.position, Quaternion.identity);
                    Instantiate(B23, orta.transform.position, Quaternion.identity);
                    Instantiate(B24, orta.transform.position, Quaternion.identity);
                    Instantiate(B25, orta.transform.position, Quaternion.identity);
                    Instantiate(B26, orta.transform.position, Quaternion.identity);
                    break;
                case 2:
                    BS2.gameObject.SetActive(true);

                    B8.tag = "Dogru"; B6.tag = "Yanlis"; B7.tag = "Yanlis"; B9.tag = "Yanlis"; B10.tag = "Yanlis";

                    B6an.runtimeAnimatorController = sol2Controller;
                    B7an.runtimeAnimatorController = sol1Controller;
                    B8an.runtimeAnimatorController = ortaController;
                    B9an.runtimeAnimatorController = sag1Controller;
                    B10an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B6, orta.transform.position, Quaternion.identity);
                    Instantiate(B7, orta.transform.position, Quaternion.identity);
                    Instantiate(B8, orta.transform.position, Quaternion.identity);
                    Instantiate(B9, orta.transform.position, Quaternion.identity);
                    Instantiate(B10, orta.transform.position, Quaternion.identity);

                    break;
                case 3:
                    BS3.gameObject.SetActive(true);

                    B9.tag = "Dogru"; B8.tag = "Yanlis"; B11.tag = "Yanlis"; B12.tag = "Yanlis"; B10.tag = "Yanlis";

                    B9an.runtimeAnimatorController = sol2Controller;
                    B8an.runtimeAnimatorController = sol1Controller;
                    B11an.runtimeAnimatorController = ortaController;
                    B12an.runtimeAnimatorController = sag1Controller;
                    B10an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B10, orta.transform.position, Quaternion.identity);
                    Instantiate(B9, orta.transform.position, Quaternion.identity);
                    Instantiate(B8, orta.transform.position, Quaternion.identity);
                    Instantiate(B11, orta.transform.position, Quaternion.identity);
                    Instantiate(B12, orta.transform.position, Quaternion.identity);
                    break;
                case 4:
                    BS4.gameObject.SetActive(true);

                    B36.tag = "Dogru"; B35.tag = "Yanlis"; B37.tag = "Yanlis"; B38.tag = "Yanlis"; B39.tag = "Yanlis";

                    B35an.runtimeAnimatorController = sol2Controller;
                    B36an.runtimeAnimatorController = sol1Controller;
                    B37an.runtimeAnimatorController = ortaController;
                    B38an.runtimeAnimatorController = sag1Controller;
                    B39an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B35, orta.transform.position, Quaternion.identity);
                    Instantiate(B36, orta.transform.position, Quaternion.identity);
                    Instantiate(B37, orta.transform.position, Quaternion.identity);
                    Instantiate(B38, orta.transform.position, Quaternion.identity);
                    Instantiate(B39, orta.transform.position, Quaternion.identity);
                    break;
                case 5:
                    BS5.gameObject.SetActive(true);

                    B14.tag = "Dogru"; B11.tag = "Yanlis"; B12.tag = "Yanlis"; B13.tag = "Yanlis"; B15.tag = "Yanlis";

                    B11an.runtimeAnimatorController = sol2Controller;
                    B12an.runtimeAnimatorController = sol1Controller;
                    B13an.runtimeAnimatorController = ortaController;
                    B14an.runtimeAnimatorController = sag1Controller;
                    B15an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B11, orta.transform.position, Quaternion.identity);
                    Instantiate(B12, orta.transform.position, Quaternion.identity);
                    Instantiate(B13, orta.transform.position, Quaternion.identity);
                    Instantiate(B14, orta.transform.position, Quaternion.identity);
                    Instantiate(B15, orta.transform.position, Quaternion.identity);
                    break;
                case 6:
                    BS6.gameObject.SetActive(true);

                    B18.tag = "Dogru"; B19.tag = "Yanlis"; B17.tag = "Yanlis"; B20.tag = "Yanlis"; B21.tag = "Yanlis";

                    B19an.runtimeAnimatorController = sol2Controller;
                    B17an.runtimeAnimatorController = sol1Controller;
                    B18an.runtimeAnimatorController = ortaController;
                    B20an.runtimeAnimatorController = sag1Controller;
                    B21an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B17, orta.transform.position, Quaternion.identity);
                    Instantiate(B18, orta.transform.position, Quaternion.identity);
                    Instantiate(B19, orta.transform.position, Quaternion.identity);
                    Instantiate(B20, orta.transform.position, Quaternion.identity);
                    Instantiate(B21, orta.transform.position, Quaternion.identity);
                    break;
                case 7:
                    BS7.gameObject.SetActive(true);

                    B25.tag = "Dogru"; B24.tag = "Yanlis"; B26.tag = "Yanlis"; B27.tag = "Yanlis"; B28.tag = "Yanlis";

                    B25an.runtimeAnimatorController = sol2Controller;
                    B24an.runtimeAnimatorController = sol1Controller;
                    B26an.runtimeAnimatorController = ortaController;
                    B27an.runtimeAnimatorController = sag1Controller;
                    B28an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B25, orta.transform.position, Quaternion.identity);
                    Instantiate(B24, orta.transform.position, Quaternion.identity);
                    Instantiate(B26, orta.transform.position, Quaternion.identity);
                    Instantiate(B27, orta.transform.position, Quaternion.identity);
                    Instantiate(B28, orta.transform.position, Quaternion.identity);

                    break;
                case 8:
                    BS8.gameObject.SetActive(true);

                    B30.tag = "Dogru"; B31.tag = "Yanlis"; B32.tag = "Yanlis"; B33.tag = "Yanlis"; B34.tag = "Yanlis";

                    B31an.runtimeAnimatorController = sol2Controller;
                    B30an.runtimeAnimatorController = sol1Controller;
                    B33an.runtimeAnimatorController = ortaController;
                    B32an.runtimeAnimatorController = sag1Controller;
                    B34an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B31, orta.transform.position, Quaternion.identity);
                    Instantiate(B32, orta.transform.position, Quaternion.identity);
                    Instantiate(B33, orta.transform.position, Quaternion.identity);
                    Instantiate(B34, orta.transform.position, Quaternion.identity);
                    Instantiate(B30, orta.transform.position, Quaternion.identity);
                    break;
                case 9:
                    BS9.gameObject.SetActive(true);

                    B26.tag = "Dogru"; B33.tag = "Yanlis"; B30.tag = "Yanlis"; B28.tag = "Yanlis"; B32.tag = "Yanlis";

                    B30an.runtimeAnimatorController = sol2Controller;
                    B28an.runtimeAnimatorController = sol1Controller;
                    B33an.runtimeAnimatorController = ortaController;
                    B32an.runtimeAnimatorController = sag1Controller;
                    B26an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B26, orta.transform.position, Quaternion.identity);
                    Instantiate(B30, orta.transform.position, Quaternion.identity);
                    Instantiate(B28, orta.transform.position, Quaternion.identity);
                    Instantiate(B32, orta.transform.position, Quaternion.identity);
                    Instantiate(B33, orta.transform.position, Quaternion.identity);
                    break;
                case 10:
                    BS10.gameObject.SetActive(true);

                    B34.tag = "Dogru"; B33.tag = "Yanlis"; B32.tag = "Yanlis"; B35.tag = "Yanlis"; B36.tag = "Yanlis";

                    B34an.runtimeAnimatorController = sol2Controller;
                    B33an.runtimeAnimatorController = sol1Controller;
                    B35an.runtimeAnimatorController = ortaController;
                    B36an.runtimeAnimatorController = sag1Controller;
                    B32an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B34, orta.transform.position, Quaternion.identity);
                    Instantiate(B35, orta.transform.position, Quaternion.identity);
                    Instantiate(B36, orta.transform.position, Quaternion.identity);
                    Instantiate(B32, orta.transform.position, Quaternion.identity);
                    Instantiate(B33, orta.transform.position, Quaternion.identity);
                    break;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        else if (sure >= 45)
        {
            SonPuan.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}