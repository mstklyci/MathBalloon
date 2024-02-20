using UnityEngine;
using UnityEngine.UI;


public class ModRastgeleBalon : MonoBehaviour
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
    public Text MS1, MS2, MS3, MS4, MS5, MS6, MS7, MS8, MS9, MS10;
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
        MS1.gameObject.SetActive(false);
        MS2.gameObject.SetActive(false);
        MS3.gameObject.SetActive(false);
        MS4.gameObject.SetActive(false);
        MS5.gameObject.SetActive(false);
        MS6.gameObject.SetActive(false);
        MS7.gameObject.SetActive(false);
        MS8.gameObject.SetActive(false);
        MS9.gameObject.SetActive(false);
        MS10.gameObject.SetActive(false);


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
                    MS1.gameObject.SetActive(true);

                    B1.tag = "Dogru"; B5.tag = "Yanlis"; B2.tag = "Yanlis"; B4.tag = "Yanlis"; B3.tag = "Yanlis";

                    B2an.runtimeAnimatorController = sol2Controller;
                    B3an.runtimeAnimatorController = sol1Controller;
                    B4an.runtimeAnimatorController = ortaController;
                    B1an.runtimeAnimatorController = sag1Controller;
                    B5an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B1, orta.transform.position, Quaternion.identity);
                    Instantiate(B2, orta.transform.position, Quaternion.identity);
                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    break;
                case 2:
                    MS2.gameObject.SetActive(true);

                    B2.tag = "Dogru"; B1.tag = "Yanlis"; B3.tag = "Yanlis"; B4.tag = "Yanlis"; B5.tag = "Yanlis";

                    B1an.runtimeAnimatorController = sol2Controller;
                    B2an.runtimeAnimatorController = sol1Controller;
                    B3an.runtimeAnimatorController = ortaController;
                    B4an.runtimeAnimatorController = sag1Controller;
                    B5an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B1, orta.transform.position, Quaternion.identity);
                    Instantiate(B2, orta.transform.position, Quaternion.identity);
                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);

                    break;
                case 3:
                    MS3.gameObject.SetActive(true);

                    B3.tag = "Dogru"; B2.tag = "Yanlis"; B1.tag = "Yanlis"; B5.tag = "Yanlis"; B4.tag = "Yanlis";

                    B1an.runtimeAnimatorController = sol2Controller;
                    B2an.runtimeAnimatorController = sol1Controller;
                    B3an.runtimeAnimatorController = ortaController;
                    B4an.runtimeAnimatorController = sag1Controller;
                    B5an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B1, orta.transform.position, Quaternion.identity);
                    Instantiate(B2, orta.transform.position, Quaternion.identity);
                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    break;
                case 4:
                    MS4.gameObject.SetActive(true);

                    B1.tag = "Dogru"; B2.tag = "Yanlis"; B3.tag = "Yanlis"; B5.tag = "Yanlis"; B4.tag = "Yanlis";

                    B3an.runtimeAnimatorController = sol2Controller;
                    B1an.runtimeAnimatorController = sol1Controller;
                    B2an.runtimeAnimatorController = ortaController;
                    B5an.runtimeAnimatorController = sag1Controller;
                    B4an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B1, orta.transform.position, Quaternion.identity);
                    Instantiate(B2, orta.transform.position, Quaternion.identity);
                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    break;
                case 5:
                    MS5.gameObject.SetActive(true);

                    B2.tag = "Dogru"; B1.tag = "Yanlis"; B3.tag = "Yanlis"; B5.tag = "Yanlis"; B4.tag = "Yanlis";

                    B2an.runtimeAnimatorController = sol2Controller;
                    B3an.runtimeAnimatorController = sol1Controller;
                    B1an.runtimeAnimatorController = ortaController;
                    B4an.runtimeAnimatorController = sag1Controller;
                    B5an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B1, orta.transform.position, Quaternion.identity);
                    Instantiate(B2, orta.transform.position, Quaternion.identity);
                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    break;
                case 6:
                    MS6.gameObject.SetActive(true);

                    B5.tag = "Dogru"; B6.tag = "Yanlis"; B4.tag = "Yanlis"; B3.tag = "Yanlis"; B2.tag = "Yanlis";

                    B2an.runtimeAnimatorController = sol2Controller;
                    B3an.runtimeAnimatorController = sol1Controller;
                    B4an.runtimeAnimatorController = ortaController;
                    B5an.runtimeAnimatorController = sag1Controller;
                    B6an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B2, orta.transform.position, Quaternion.identity);
                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    Instantiate(B6, orta.transform.position, Quaternion.identity);
                    break;
                case 7:
                    MS7.gameObject.SetActive(true);

                    B5.tag = "Dogru"; B4.tag = "Yanlis"; B6.tag = "Yanlis"; B3.tag = "Yanlis"; B7.tag = "Yanlis";

                    B7an.runtimeAnimatorController = sol2Controller;
                    B5an.runtimeAnimatorController = sol1Controller;
                    B6an.runtimeAnimatorController = ortaController;
                    B4an.runtimeAnimatorController = sag1Controller;
                    B3an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    Instantiate(B6, orta.transform.position, Quaternion.identity);
                    Instantiate(B7, orta.transform.position, Quaternion.identity);
                    break;
                case 8:
                    MS8.gameObject.SetActive(true);

                    B4.tag = "Dogru"; B5.tag = "Yanlis"; B6.tag = "Yanlis"; B3.tag = "Yanlis"; B7.tag = "Yanlis";

                    B3an.runtimeAnimatorController = sol2Controller;
                    B4an.runtimeAnimatorController = sol1Controller;
                    B5an.runtimeAnimatorController = ortaController;
                    B6an.runtimeAnimatorController = sag1Controller;
                    B7an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    Instantiate(B6, orta.transform.position, Quaternion.identity);
                    Instantiate(B7, orta.transform.position, Quaternion.identity);
                    break;
                case 9:
                    MS9.gameObject.SetActive(true);

                    B3.tag = "Dogru"; B5.tag = "Yanlis"; B6.tag = "Yanlis"; B4.tag = "Yanlis"; B7.tag = "Yanlis";

                    B4an.runtimeAnimatorController = sol2Controller;
                    B3an.runtimeAnimatorController = sol1Controller;
                    B6an.runtimeAnimatorController = ortaController;
                    B7an.runtimeAnimatorController = sag1Controller;
                    B5an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    Instantiate(B6, orta.transform.position, Quaternion.identity);
                    Instantiate(B7, orta.transform.position, Quaternion.identity);
                    break;
                case 10:
                    MS10.gameObject.SetActive(true);

                    B2.tag = "Dogru"; B1.tag = "Yanlis"; B3.tag = "Yanlis"; B5.tag = "Yanlis"; B4.tag = "Yanlis";

                    B3an.runtimeAnimatorController = sol2Controller;
                    B2an.runtimeAnimatorController = sol1Controller;
                    B4an.runtimeAnimatorController = ortaController;
                    B5an.runtimeAnimatorController = sag1Controller;
                    B1an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B1, orta.transform.position, Quaternion.identity);
                    Instantiate(B2, orta.transform.position, Quaternion.identity);
                    Instantiate(B3, orta.transform.position, Quaternion.identity);
                    Instantiate(B4, orta.transform.position, Quaternion.identity);
                    Instantiate(B5, orta.transform.position, Quaternion.identity);
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