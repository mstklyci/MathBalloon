using UnityEngine;
using UnityEngine.UI;


public class RastgeleBalon : MonoBehaviour
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
    public Text TS1, TS2, TS3, TS4, TS5, TS6, TS7, TS8, TS9, TS10; 
    public Text TS11, TS12, TS13, TS14, TS15, TS16, TS17, TS18, TS19, TS20;
    public Text TS21, TS22, TS23, TS24, TS25, TS26, TS27, TS28, TS29, TS30;
    public Text TS31, TS32, TS33, TS34, TS35, TS36, TS37, TS38, TS39, TS40;
    public Text TS41, TS42, TS43, TS44, TS45, TS46, TS47, TS48, TS49, TS50;
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
        TS1.gameObject.SetActive(false);
        TS2.gameObject.SetActive(false);
        TS3.gameObject.SetActive(false);
        TS4.gameObject.SetActive(false);
        TS5.gameObject.SetActive(false);
        TS6.gameObject.SetActive(false);
        TS7.gameObject.SetActive(false);
        TS8.gameObject.SetActive(false);
        TS9.gameObject.SetActive(false);
        TS10.gameObject.SetActive(false);
        TS11.gameObject.SetActive(false);
        TS12.gameObject.SetActive(false);
        TS13.gameObject.SetActive(false);
        TS14.gameObject.SetActive(false);
        TS15.gameObject.SetActive(false);
        TS16.gameObject.SetActive(false);
        TS17.gameObject.SetActive(false);
        TS18.gameObject.SetActive(false);
        TS19.gameObject.SetActive(false);
        TS20.gameObject.SetActive(false);
        TS21.gameObject.SetActive(false);
        TS22.gameObject.SetActive(false);
        TS23.gameObject.SetActive(false);
        TS24.gameObject.SetActive(false);
        TS25.gameObject.SetActive(false);
        TS26.gameObject.SetActive(false);
        TS27.gameObject.SetActive(false);
        TS28.gameObject.SetActive(false);
        TS29.gameObject.SetActive(false);
        TS30.gameObject.SetActive(false);
        TS31.gameObject.SetActive(false);
        TS32.gameObject.SetActive(false);
        TS33.gameObject.SetActive(false);
        TS34.gameObject.SetActive(false);
        TS35.gameObject.SetActive(false);
        TS36.gameObject.SetActive(false);
        TS37.gameObject.SetActive(false);
        TS38.gameObject.SetActive(false);
        TS39.gameObject.SetActive(false);
        TS40.gameObject.SetActive(false);
        TS41.gameObject.SetActive(false);
        TS42.gameObject.SetActive(false);
        TS43.gameObject.SetActive(false);
        TS44.gameObject.SetActive(false);
        TS45.gameObject.SetActive(false);
        TS46.gameObject.SetActive(false);
        TS47.gameObject.SetActive(false);
        TS48.gameObject.SetActive(false);
        TS49.gameObject.SetActive(false);
        TS50.gameObject.SetActive(false);


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
                    TS1.gameObject.SetActive(true);

                    B5.tag = "Dogru"; B2.tag = "Yanlis"; B3.tag = "Yanlis"; B4.tag = "Yanlis"; B1.tag = "Yanlis";

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
                case 2:
                    TS2.gameObject.SetActive(true);

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
                    TS3.gameObject.SetActive(true);

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
                    TS4.gameObject.SetActive(true);

                    B6.tag = "Dogru"; B5.tag = "Yanlis"; B7.tag = "Yanlis"; B8.tag = "Yanlis"; B9.tag = "Yanlis";

                    B5an.runtimeAnimatorController = sol2Controller;
                    B6an.runtimeAnimatorController = sol1Controller;
                    B7an.runtimeAnimatorController = ortaController;
                    B8an.runtimeAnimatorController = sag1Controller;
                    B9an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B5, orta.transform.position, Quaternion.identity);
                    Instantiate(B6, orta.transform.position, Quaternion.identity);
                    Instantiate(B7, orta.transform.position, Quaternion.identity);
                    Instantiate(B8, orta.transform.position, Quaternion.identity);
                    Instantiate(B9, orta.transform.position, Quaternion.identity);
                    break;
                case 5:
                    TS5.gameObject.SetActive(true);

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
                    TS6.gameObject.SetActive(true);

                    B19.tag = "Dogru"; B18.tag = "Yanlis"; B17.tag = "Yanlis"; B20.tag = "Yanlis"; B21.tag = "Yanlis";

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
                    TS7.gameObject.SetActive(true);

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
                    TS8.gameObject.SetActive(true);

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
                    TS9.gameObject.SetActive(true);

                    B29.tag = "Dogru"; B28.tag = "Yanlis"; B30.tag = "Yanlis"; B31.tag = "Yanlis"; B32.tag = "Yanlis";

                    B30an.runtimeAnimatorController = sol2Controller;
                    B31an.runtimeAnimatorController = sol1Controller;
                    B33an.runtimeAnimatorController = ortaController;
                    B32an.runtimeAnimatorController = sag1Controller;
                    B29an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B29, orta.transform.position, Quaternion.identity);
                    Instantiate(B30, orta.transform.position, Quaternion.identity);
                    Instantiate(B31, orta.transform.position, Quaternion.identity);
                    Instantiate(B32, orta.transform.position, Quaternion.identity);
                    Instantiate(B33, orta.transform.position, Quaternion.identity);
                    break;
                case 10:
                    TS10.gameObject.SetActive(true);

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
        else if (sure >= 45 && sure <95)
        {
            switch (rastgeleSayi)
            {
                case 1:
                    TS11.gameObject.SetActive(true);

                    B37.tag = "Dogru"; B36.tag = "Yanlis"; B38.tag = "Yanlis"; B39.tag = "Yanlis"; B40.tag = "Yanlis";

                    B38an.runtimeAnimatorController = sol2Controller;
                    B36an.runtimeAnimatorController = sol1Controller;
                    B37an.runtimeAnimatorController = ortaController;
                    B39an.runtimeAnimatorController = sag1Controller;
                    B40an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B36, orta.transform.position, Quaternion.identity);
                    Instantiate(B37, orta.transform.position, Quaternion.identity);
                    Instantiate(B38, orta.transform.position, Quaternion.identity);
                    Instantiate(B39, orta.transform.position, Quaternion.identity);
                    Instantiate(B40, orta.transform.position, Quaternion.identity);
                    break;
                case 2:
                    TS12.gameObject.SetActive(true);

                    B20.tag = "Dogru"; B21.tag = "Yanlis"; B22.tag = "Yanlis"; B19.tag = "Yanlis"; B23.tag = "Yanlis";

                    B19an.runtimeAnimatorController = sol2Controller;
                    B21an.runtimeAnimatorController = sol1Controller;
                    B22an.runtimeAnimatorController = ortaController;
                    B20an.runtimeAnimatorController = sag1Controller;
                    B23an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B19, orta.transform.position, Quaternion.identity);
                    Instantiate(B20, orta.transform.position, Quaternion.identity);
                    Instantiate(B21, orta.transform.position, Quaternion.identity);
                    Instantiate(B22, orta.transform.position, Quaternion.identity);
                    Instantiate(B23, orta.transform.position, Quaternion.identity);

                    break;
                case 3:
                    TS13.gameObject.SetActive(true);

                    B35.tag = "Dogru"; B34.tag = "Yanlis"; B25.tag = "Yanlis"; B36.tag = "Yanlis"; B37.tag = "Yanlis";

                    B35an.runtimeAnimatorController = sol2Controller;
                    B25an.runtimeAnimatorController = sol1Controller;
                    B34an.runtimeAnimatorController = ortaController;
                    B36an.runtimeAnimatorController = sag1Controller;
                    B37an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B35, orta.transform.position, Quaternion.identity);
                    Instantiate(B25, orta.transform.position, Quaternion.identity);
                    Instantiate(B34, orta.transform.position, Quaternion.identity);
                    Instantiate(B36, orta.transform.position, Quaternion.identity);
                    Instantiate(B37, orta.transform.position, Quaternion.identity);
                    break;
                case 4:
                    TS14.gameObject.SetActive(true);

                    B40.tag = "Dogru"; B41.tag = "Yanlis"; B42.tag = "Yanlis"; B43.tag = "Yanlis"; B45.tag = "Yanlis";

                    B45an.runtimeAnimatorController = sol2Controller;
                    B41an.runtimeAnimatorController = sol1Controller;
                    B42an.runtimeAnimatorController = ortaController;
                    B43an.runtimeAnimatorController = sag1Controller;   
                    B40an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B40, orta.transform.position, Quaternion.identity);
                    Instantiate(B41, orta.transform.position, Quaternion.identity);
                    Instantiate(B42, orta.transform.position, Quaternion.identity);
                    Instantiate(B43, orta.transform.position, Quaternion.identity);
                    Instantiate(B45, orta.transform.position, Quaternion.identity);
                    break;
                case 5:
                    TS15.gameObject.SetActive(true);

                    B40.tag = "Dogru"; B39.tag = "Yanlis"; B41.tag = "Yanlis"; B42.tag = "Yanlis"; B43.tag = "Yanlis";

                    B39an.runtimeAnimatorController = sol2Controller;
                    B42an.runtimeAnimatorController = sol1Controller;
                    B40an.runtimeAnimatorController = ortaController;
                    B41an.runtimeAnimatorController = sag1Controller;
                    B43an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B40, orta.transform.position, Quaternion.identity);
                    Instantiate(B39, orta.transform.position, Quaternion.identity);
                    Instantiate(B41, orta.transform.position, Quaternion.identity);
                    Instantiate(B42, orta.transform.position, Quaternion.identity);
                    Instantiate(B43, orta.transform.position, Quaternion.identity);
                    break;
                case 6:
                    TS16.gameObject.SetActive(true);

                    B70.tag = "Dogru"; B71.tag = "Yanlis"; B69.tag = "Yanlis"; B72.tag = "Yanlis"; B73.tag = "Yanlis";

                    B71an.runtimeAnimatorController = sol2Controller;
                    B70an.runtimeAnimatorController = sol1Controller;
                    B69an.runtimeAnimatorController = ortaController;
                    B73an.runtimeAnimatorController = sag1Controller;
                    B72an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B71, orta.transform.position, Quaternion.identity);
                    Instantiate(B72, orta.transform.position, Quaternion.identity);
                    Instantiate(B73, orta.transform.position, Quaternion.identity);
                    Instantiate(B70, orta.transform.position, Quaternion.identity);
                    Instantiate(B69, orta.transform.position, Quaternion.identity);
                    break;
                case 7:
                    TS17.gameObject.SetActive(true);

                    B80.tag = "Dogru"; B75.tag = "Yanlis"; B70.tag = "Yanlis"; B90.tag = "Yanlis"; B85.tag = "Yanlis";

                    B85an.runtimeAnimatorController = sol2Controller;
                    B75an.runtimeAnimatorController = sol1Controller;
                    B70an.runtimeAnimatorController = ortaController;
                    B80an.runtimeAnimatorController = sag1Controller;
                    B90an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B85, orta.transform.position, Quaternion.identity);
                    Instantiate(B75, orta.transform.position, Quaternion.identity);
                    Instantiate(B70, orta.transform.position, Quaternion.identity);
                    Instantiate(B80, orta.transform.position, Quaternion.identity);
                    Instantiate(B90, orta.transform.position, Quaternion.identity);

                    break;
                case 8:
                    TS18.gameObject.SetActive(true);

                    B90.tag = "Dogru"; B92.tag = "Yanlis"; B93.tag = "Yanlis"; B95.tag = "Yanlis"; B91.tag = "Yanlis";

                    B91an.runtimeAnimatorController = sol2Controller;
                    B92an.runtimeAnimatorController = sol1Controller;
                    B90an.runtimeAnimatorController = ortaController;
                    B95an.runtimeAnimatorController = sag1Controller;
                    B93an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    Instantiate(B91, orta.transform.position, Quaternion.identity);
                    Instantiate(B92, orta.transform.position, Quaternion.identity);
                    Instantiate(B93, orta.transform.position, Quaternion.identity);
                    Instantiate(B95, orta.transform.position, Quaternion.identity);
                    break;
                case 9:
                    TS19.gameObject.SetActive(true);

                    B90.tag = "Dogru"; B89.tag = "Yanlis"; B91.tag = "Yanlis"; B92.tag = "Yanlis"; B93.tag = "Yanlis";

                    B90an.runtimeAnimatorController = sol2Controller;
                    B91an.runtimeAnimatorController = sol1Controller;
                    B92an.runtimeAnimatorController = ortaController;
                    B93an.runtimeAnimatorController = sag1Controller;
                    B89an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    Instantiate(B91, orta.transform.position, Quaternion.identity);
                    Instantiate(B92, orta.transform.position, Quaternion.identity);
                    Instantiate(B93, orta.transform.position, Quaternion.identity);
                    Instantiate(B89, orta.transform.position, Quaternion.identity);
                    break;
                case 10:
                    TS20.gameObject.SetActive(true);

                    B90.tag = "Dogru"; B89.tag = "Yanlis"; B80.tag = "Yanlis"; B79.tag = "Yanlis"; B85.tag = "Yanlis";

                    B90an.runtimeAnimatorController = sol2Controller;
                    B89an.runtimeAnimatorController = sol1Controller;
                    B80an.runtimeAnimatorController = ortaController;
                    B79an.runtimeAnimatorController = sag1Controller;
                    B85an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    Instantiate(B89, orta.transform.position, Quaternion.identity);
                    Instantiate(B80, orta.transform.position, Quaternion.identity);
                    Instantiate(B79, orta.transform.position, Quaternion.identity);
                    Instantiate(B85, orta.transform.position, Quaternion.identity);
                    break;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        else if (sure >= 95 && sure <145)
        {
            switch (rastgeleSayi)
            {
                case 1:
                    TS21.gameObject.SetActive(true);

                    B90.tag = "Dogru"; B85.tag = "Yanlis"; B70.tag = "Yanlis"; B80.tag = "Yanlis"; B100.tag = "Yanlis";

                    B85an.runtimeAnimatorController = sol2Controller;
                    B100an.runtimeAnimatorController = sol1Controller;
                    B70an.runtimeAnimatorController = ortaController;
                    B80an.runtimeAnimatorController = sag1Controller;
                    B90an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B85, orta.transform.position, Quaternion.identity);
                    Instantiate(B80, orta.transform.position, Quaternion.identity);
                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    Instantiate(B100, orta.transform.position, Quaternion.identity);
                    Instantiate(B70, orta.transform.position, Quaternion.identity);
                    break;
                case 2:
                    TS22.gameObject.SetActive(true);

                    B52.tag = "Dogru"; B51.tag = "Yanlis"; B53.tag = "Yanlis"; B54.tag = "Yanlis"; B50.tag = "Yanlis";

                    B50an.runtimeAnimatorController = sol2Controller;
                    B51an.runtimeAnimatorController = sol1Controller;
                    B52an.runtimeAnimatorController = ortaController;
                    B53an.runtimeAnimatorController = sag1Controller;
                    B54an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B50, orta.transform.position, Quaternion.identity);
                    Instantiate(B51, orta.transform.position, Quaternion.identity);
                    Instantiate(B52, orta.transform.position, Quaternion.identity);
                    Instantiate(B53, orta.transform.position, Quaternion.identity);
                    Instantiate(B54, orta.transform.position, Quaternion.identity);

                    break;
                case 3:
                    TS23.gameObject.SetActive(true);

                    B63.tag = "Dogru"; B64.tag = "Yanlis"; B65.tag = "Yanlis"; B60.tag = "Yanlis"; B62.tag = "Yanlis";

                    B62an.runtimeAnimatorController = sol2Controller;
                    B65an.runtimeAnimatorController = sol1Controller;
                    B60an.runtimeAnimatorController = ortaController;
                    B63an.runtimeAnimatorController = sag1Controller;
                    B64an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B62, orta.transform.position, Quaternion.identity);
                    Instantiate(B65, orta.transform.position, Quaternion.identity);
                    Instantiate(B60, orta.transform.position, Quaternion.identity);
                    Instantiate(B63, orta.transform.position, Quaternion.identity);
                    Instantiate(B64, orta.transform.position, Quaternion.identity);
                    break;
                case 4:
                    TS24.gameObject.SetActive(true);

                    B55.tag = "Dogru"; B51.tag = "Yanlis"; B52.tag = "Yanlis"; B53.tag = "Yanlis"; B60.tag = "Yanlis";

                    B55an.runtimeAnimatorController = sol2Controller;
                    B60an.runtimeAnimatorController = sol1Controller;
                    B53an.runtimeAnimatorController = ortaController;
                    B51an.runtimeAnimatorController = sag1Controller;
                    B52an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B60, orta.transform.position, Quaternion.identity);
                    Instantiate(B51, orta.transform.position, Quaternion.identity);
                    Instantiate(B52, orta.transform.position, Quaternion.identity);
                    Instantiate(B53, orta.transform.position, Quaternion.identity);
                    Instantiate(B55, orta.transform.position, Quaternion.identity);
                    break;
                case 5:
                    TS25.gameObject.SetActive(true);

                    B66.tag = "Dogru"; B65.tag = "Yanlis"; B64.tag = "Yanlis"; B63.tag = "Yanlis"; B67.tag = "Yanlis";

                    B65an.runtimeAnimatorController = sol2Controller;
                    B63an.runtimeAnimatorController = sol1Controller;
                    B64an.runtimeAnimatorController = ortaController;
                    B67an.runtimeAnimatorController = sag1Controller;
                    B66an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B63, orta.transform.position, Quaternion.identity);
                    Instantiate(B64, orta.transform.position, Quaternion.identity);
                    Instantiate(B65, orta.transform.position, Quaternion.identity);
                    Instantiate(B66, orta.transform.position, Quaternion.identity);
                    Instantiate(B67, orta.transform.position, Quaternion.identity);
                    break;
                case 6:
                    TS26.gameObject.SetActive(true);

                    B82.tag = "Dogru"; B81.tag = "Yanlis"; B83.tag = "Yanlis"; B84.tag = "Yanlis"; B85.tag = "Yanlis";

                    B81an.runtimeAnimatorController = sol2Controller;
                    B82an.runtimeAnimatorController = sol1Controller;
                    B83an.runtimeAnimatorController = ortaController;
                    B84an.runtimeAnimatorController = sag1Controller;
                    B85an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B81, orta.transform.position, Quaternion.identity);
                    Instantiate(B82, orta.transform.position, Quaternion.identity);
                    Instantiate(B83, orta.transform.position, Quaternion.identity);
                    Instantiate(B84, orta.transform.position, Quaternion.identity);
                    Instantiate(B85, orta.transform.position, Quaternion.identity);
                    break;
                case 7:
                    TS27.gameObject.SetActive(true);

                    B38.tag = "Dogru"; B37.tag = "Yanlis"; B39.tag = "Yanlis"; B40.tag = "Yanlis"; B41.tag = "Yanlis";

                    B41an.runtimeAnimatorController = sol2Controller;
                    B40an.runtimeAnimatorController = sol1Controller;
                    B39an.runtimeAnimatorController = ortaController;
                    B38an.runtimeAnimatorController = sag1Controller;
                    B37an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B37, orta.transform.position, Quaternion.identity);
                    Instantiate(B38, orta.transform.position, Quaternion.identity);
                    Instantiate(B39, orta.transform.position, Quaternion.identity);
                    Instantiate(B40, orta.transform.position, Quaternion.identity);
                    Instantiate(B41, orta.transform.position, Quaternion.identity);

                    break;
                case 8:
                    TS28.gameObject.SetActive(true);

                    B21.tag = "Dogru"; B20.tag = "Yanlis"; B22.tag = "Yanlis"; B23.tag = "Yanlis"; B24.tag = "Yanlis";

                    B21an.runtimeAnimatorController = sol2Controller;
                    B20an.runtimeAnimatorController = sol1Controller;
                    B22an.runtimeAnimatorController = ortaController;
                    B23an.runtimeAnimatorController = sag1Controller;
                    B24an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B21, orta.transform.position, Quaternion.identity);
                    Instantiate(B20, orta.transform.position, Quaternion.identity);
                    Instantiate(B22, orta.transform.position, Quaternion.identity);
                    Instantiate(B23, orta.transform.position, Quaternion.identity);
                    Instantiate(B24, orta.transform.position, Quaternion.identity);
                    break;
                case 9:
                    TS29.gameObject.SetActive(true);

                    B110.tag = "Dogru"; B100.tag = "Yanlis"; B105.tag = "Yanlis"; B95.tag = "Yanlis"; B90.tag = "Yanlis";

                    B90an.runtimeAnimatorController = sol2Controller;
                    B110an.runtimeAnimatorController = sol1Controller;
                    B100an.runtimeAnimatorController = ortaController;
                    B95an.runtimeAnimatorController = sag1Controller;
                    B105an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    Instantiate(B95, orta.transform.position, Quaternion.identity);
                    Instantiate(B100, orta.transform.position, Quaternion.identity);
                    Instantiate(B105, orta.transform.position, Quaternion.identity);
                    Instantiate(B110, orta.transform.position, Quaternion.identity);
                    break;
                case 10:
                    TS30.gameObject.SetActive(true);

                    B28.tag = "Dogru"; B29.tag = "Yanlis"; B27.tag = "Yanlis"; B26.tag = "Yanlis"; B30.tag = "Yanlis";

                    B30an.runtimeAnimatorController = sol2Controller;
                    B29an.runtimeAnimatorController = sol1Controller;
                    B28an.runtimeAnimatorController = ortaController;
                    B27an.runtimeAnimatorController = sag1Controller;
                    B26an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B26, orta.transform.position, Quaternion.identity);
                    Instantiate(B27, orta.transform.position, Quaternion.identity);
                    Instantiate(B28, orta.transform.position, Quaternion.identity);
                    Instantiate(B29, orta.transform.position, Quaternion.identity);
                    Instantiate(B30, orta.transform.position, Quaternion.identity);
                    break;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        else if (sure >= 145 && sure <195)
        {
            switch (rastgeleSayi)
            {
                case 1:
                    TS31.gameObject.SetActive(true);

                    B88.tag = "Dogru"; B86.tag = "Yanlis"; B87.tag = "Yanlis"; B89.tag = "Yanlis"; B90.tag = "Yanlis";

                    B90an.runtimeAnimatorController = sol2Controller;
                    B86an.runtimeAnimatorController = sol1Controller;
                    B88an.runtimeAnimatorController = ortaController;
                    B87an.runtimeAnimatorController = sag1Controller;
                    B89an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B86, orta.transform.position, Quaternion.identity);
                    Instantiate(B87, orta.transform.position, Quaternion.identity);
                    Instantiate(B88, orta.transform.position, Quaternion.identity);
                    Instantiate(B89, orta.transform.position, Quaternion.identity);
                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    break;
                case 2:
                    TS32.gameObject.SetActive(true);

                    B75.tag = "Dogru"; B76.tag = "Yanlis"; B74.tag = "Yanlis"; B77.tag = "Yanlis"; B73.tag = "Yanlis";

                    B73an.runtimeAnimatorController = sol2Controller;
                    B77an.runtimeAnimatorController = sol1Controller;
                    B76an.runtimeAnimatorController = ortaController;
                    B74an.runtimeAnimatorController = sag1Controller;
                    B75an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B73, orta.transform.position, Quaternion.identity);
                    Instantiate(B74, orta.transform.position, Quaternion.identity);
                    Instantiate(B75, orta.transform.position, Quaternion.identity);
                    Instantiate(B76, orta.transform.position, Quaternion.identity);
                    Instantiate(B77, orta.transform.position, Quaternion.identity);

                    break;
                case 3:
                    TS33.gameObject.SetActive(true);

                    B91.tag = "Dogru"; B90.tag = "Yanlis"; B89.tag = "Yanlis"; B92.tag = "Yanlis"; B93.tag = "Yanlis";

                    B90an.runtimeAnimatorController = sol2Controller;
                    B89an.runtimeAnimatorController = sol1Controller;
                    B92an.runtimeAnimatorController = ortaController;
                    B93an.runtimeAnimatorController = sag1Controller;
                    B91an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    Instantiate(B91, orta.transform.position, Quaternion.identity);
                    Instantiate(B89, orta.transform.position, Quaternion.identity);
                    Instantiate(B92, orta.transform.position, Quaternion.identity);
                    Instantiate(B93, orta.transform.position, Quaternion.identity);
                    break;
                case 4:
                    TS34.gameObject.SetActive(true);

                    B81.tag = "Dogru"; B80.tag = "Yanlis"; B89.tag = "Yanlis"; B82.tag = "Yanlis"; B79.tag = "Yanlis";

                    B81an.runtimeAnimatorController = sol2Controller;
                    B79an.runtimeAnimatorController = sol1Controller;
                    B89an.runtimeAnimatorController = ortaController;
                    B82an.runtimeAnimatorController = sag1Controller;
                    B80an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B81, orta.transform.position, Quaternion.identity);
                    Instantiate(B80, orta.transform.position, Quaternion.identity);
                    Instantiate(B89, orta.transform.position, Quaternion.identity);
                    Instantiate(B82, orta.transform.position, Quaternion.identity);
                    Instantiate(B79, orta.transform.position, Quaternion.identity);
                    break;
                case 5:
                    TS35.gameObject.SetActive(true);

                    B93.tag = "Dogru"; B91.tag = "Yanlis"; B92.tag = "Yanlis"; B94.tag = "Yanlis"; B95.tag = "Yanlis";

                    B91an.runtimeAnimatorController = sol2Controller;
                    B94an.runtimeAnimatorController = sol1Controller;
                    B93an.runtimeAnimatorController = ortaController;
                    B92an.runtimeAnimatorController = sag1Controller;
                    B95an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B91, orta.transform.position, Quaternion.identity);
                    Instantiate(B92, orta.transform.position, Quaternion.identity);
                    Instantiate(B93, orta.transform.position, Quaternion.identity);
                    Instantiate(B94, orta.transform.position, Quaternion.identity);
                    Instantiate(B95, orta.transform.position, Quaternion.identity);
                    break;
                case 6:
                    TS36.gameObject.SetActive(true);

                    B54.tag = "Dogru"; B51.tag = "Yanlis"; B53.tag = "Yanlis"; B52.tag = "Yanlis"; B55.tag = "Yanlis";

                    B51an.runtimeAnimatorController = sol2Controller;
                    B52an.runtimeAnimatorController = sol1Controller;
                    B53an.runtimeAnimatorController = ortaController;
                    B54an.runtimeAnimatorController = sag1Controller;
                    B55an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B51, orta.transform.position, Quaternion.identity);
                    Instantiate(B52, orta.transform.position, Quaternion.identity);
                    Instantiate(B53, orta.transform.position, Quaternion.identity);
                    Instantiate(B54, orta.transform.position, Quaternion.identity);
                    Instantiate(B55, orta.transform.position, Quaternion.identity);
                    break;
                case 7:
                    TS37.gameObject.SetActive(true);

                    B79.tag = "Dogru"; B77.tag = "Yanlis"; B79.tag = "Yanlis"; B80.tag = "Yanlis"; B81.tag = "Yanlis";

                    B81an.runtimeAnimatorController = sol2Controller;
                    B80an.runtimeAnimatorController = sol1Controller;
                    B79an.runtimeAnimatorController = ortaController;
                    B78an.runtimeAnimatorController = sag1Controller;
                    B77an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B77, orta.transform.position, Quaternion.identity);
                    Instantiate(B78, orta.transform.position, Quaternion.identity);
                    Instantiate(B79, orta.transform.position, Quaternion.identity);
                    Instantiate(B80, orta.transform.position, Quaternion.identity);
                    Instantiate(B81, orta.transform.position, Quaternion.identity);

                    break;
                case 8:
                    TS38.gameObject.SetActive(true);

                    B38.tag = "Dogru"; B37.tag = "Yanlis"; B36.tag = "Yanlis"; B39.tag = "Yanlis"; B40.tag = "Yanlis";

                    B40an.runtimeAnimatorController = sol2Controller;
                    B38an.runtimeAnimatorController = sol1Controller;
                    B37an.runtimeAnimatorController = ortaController;
                    B36an.runtimeAnimatorController = sag1Controller;
                    B39an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B36, orta.transform.position, Quaternion.identity);
                    Instantiate(B37, orta.transform.position, Quaternion.identity);
                    Instantiate(B38, orta.transform.position, Quaternion.identity);
                    Instantiate(B39, orta.transform.position, Quaternion.identity);
                    Instantiate(B40, orta.transform.position, Quaternion.identity);
                    break;
                case 9:
                    TS39.gameObject.SetActive(true);

                    B57.tag = "Dogru"; B56.tag = "Yanlis"; B58.tag = "Yanlis"; B59.tag = "Yanlis"; B60.tag = "Yanlis";

                    B57an.runtimeAnimatorController = sol2Controller;
                    B56an.runtimeAnimatorController = sol1Controller;
                    B58an.runtimeAnimatorController = ortaController;
                    B59an.runtimeAnimatorController = sag1Controller;
                    B60an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B57, orta.transform.position, Quaternion.identity);
                    Instantiate(B58, orta.transform.position, Quaternion.identity);
                    Instantiate(B59, orta.transform.position, Quaternion.identity);
                    Instantiate(B56, orta.transform.position, Quaternion.identity);
                    Instantiate(B60, orta.transform.position, Quaternion.identity);
                    break;
                case 10:
                    TS40.gameObject.SetActive(true);

                    B99.tag = "Dogru"; B98.tag = "Yanlis"; B97.tag = "Yanlis"; B96.tag = "Yanlis"; B95.tag = "Yanlis";

                    B95an.runtimeAnimatorController = sol2Controller;
                    B96an.runtimeAnimatorController = sol1Controller;
                    B97an.runtimeAnimatorController = ortaController;
                    B98an.runtimeAnimatorController = sag1Controller;
                    B99an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B95, orta.transform.position, Quaternion.identity);
                    Instantiate(B96, orta.transform.position, Quaternion.identity);
                    Instantiate(B97, orta.transform.position, Quaternion.identity);
                    Instantiate(B98, orta.transform.position, Quaternion.identity);
                    Instantiate(B99, orta.transform.position, Quaternion.identity);
                    break;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        else if (sure >= 195 && sure < 245)
        {
            switch (rastgeleSayi)
            {
                case 1:
                    TS41.gameObject.SetActive(true);

                    B82.tag = "Dogru"; B80.tag = "Yanlis"; B81.tag = "Yanlis"; B83.tag = "Yanlis"; B84.tag = "Yanlis";

                    B80an.runtimeAnimatorController = sol2Controller;
                    B81an.runtimeAnimatorController = sol1Controller;
                    B82an.runtimeAnimatorController = ortaController;
                    B83an.runtimeAnimatorController = sag1Controller;
                    B84an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B80, orta.transform.position, Quaternion.identity);
                    Instantiate(B81, orta.transform.position, Quaternion.identity);
                    Instantiate(B82, orta.transform.position, Quaternion.identity);
                    Instantiate(B83, orta.transform.position, Quaternion.identity);
                    Instantiate(B84, orta.transform.position, Quaternion.identity);
                    break;
                case 2:
                    TS42.gameObject.SetActive(true);

                    B77.tag = "Dogru"; B75.tag = "Yanlis"; B76.tag = "Yanlis"; B78.tag = "Yanlis"; B79.tag = "Yanlis";

                    B75an.runtimeAnimatorController = sol2Controller;
                    B76an.runtimeAnimatorController = sol1Controller;
                    B78an.runtimeAnimatorController = ortaController;
                    B79an.runtimeAnimatorController = sag1Controller;
                    B77an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B75, orta.transform.position, Quaternion.identity);
                    Instantiate(B76, orta.transform.position, Quaternion.identity);
                    Instantiate(B77, orta.transform.position, Quaternion.identity);
                    Instantiate(B78, orta.transform.position, Quaternion.identity);
                    Instantiate(B79, orta.transform.position, Quaternion.identity);

                    break;
                case 3:
                    TS43.gameObject.SetActive(true);

                    B59.tag = "Dogru"; B56.tag = "Yanlis"; B57.tag = "Yanlis"; B58.tag = "Yanlis"; B60.tag = "Yanlis";

                    B56an.runtimeAnimatorController = sol2Controller;
                    B57an.runtimeAnimatorController = sol1Controller;
                    B59an.runtimeAnimatorController = ortaController;
                    B60an.runtimeAnimatorController = sag1Controller;
                    B58an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B56, orta.transform.position, Quaternion.identity);
                    Instantiate(B57, orta.transform.position, Quaternion.identity);
                    Instantiate(B58, orta.transform.position, Quaternion.identity);
                    Instantiate(B59, orta.transform.position, Quaternion.identity);
                    Instantiate(B60, orta.transform.position, Quaternion.identity);
                    break;
                case 4:
                    TS44.gameObject.SetActive(true);

                    B87.tag = "Dogru"; B88.tag = "Yanlis"; B89.tag = "Yanlis"; B90.tag = "Yanlis"; B91.tag = "Yanlis";

                    B87an.runtimeAnimatorController = sol2Controller;
                    B88an.runtimeAnimatorController = sol1Controller;
                    B89an.runtimeAnimatorController = ortaController;
                    B90an.runtimeAnimatorController = sag1Controller;
                    B91an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B87, orta.transform.position, Quaternion.identity);
                    Instantiate(B88, orta.transform.position, Quaternion.identity);
                    Instantiate(B89, orta.transform.position, Quaternion.identity);
                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    Instantiate(B91, orta.transform.position, Quaternion.identity);
                    break;
                case 5:
                    TS45.gameObject.SetActive(true);

                    B37.tag = "Dogru"; B35.tag = "Yanlis"; B34.tag = "Yanlis"; B38.tag = "Yanlis"; B36.tag = "Yanlis";

                    B35an.runtimeAnimatorController = sol2Controller;
                    B34an.runtimeAnimatorController = sol1Controller;
                    B36an.runtimeAnimatorController = ortaController;
                    B37an.runtimeAnimatorController = sag1Controller;
                    B38an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B35, orta.transform.position, Quaternion.identity);
                    Instantiate(B36, orta.transform.position, Quaternion.identity);
                    Instantiate(B37, orta.transform.position, Quaternion.identity);
                    Instantiate(B38, orta.transform.position, Quaternion.identity);
                    Instantiate(B34, orta.transform.position, Quaternion.identity);
                    break;
                case 6:
                    TS46.gameObject.SetActive(true);

                    B63.tag = "Dogru"; B64.tag = "Yanlis"; B65.tag = "Yanlis"; B66.tag = "Yanlis"; B67.tag = "Yanlis";

                    B63an.runtimeAnimatorController = sol2Controller;
                    B64an.runtimeAnimatorController = sol1Controller;
                    B65an.runtimeAnimatorController = ortaController;
                    B66an.runtimeAnimatorController = sag1Controller;
                    B67an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B63, orta.transform.position, Quaternion.identity);
                    Instantiate(B64, orta.transform.position, Quaternion.identity);
                    Instantiate(B65, orta.transform.position, Quaternion.identity);
                    Instantiate(B66, orta.transform.position, Quaternion.identity);
                    Instantiate(B67, orta.transform.position, Quaternion.identity);
                    break;
                case 7:
                    TS47.gameObject.SetActive(true);

                    B89.tag = "Dogru"; B90.tag = "Yanlis"; B91.tag = "Yanlis"; B92.tag = "Yanlis"; B93.tag = "Yanlis";

                    B91an.runtimeAnimatorController = sol2Controller;
                    B90an.runtimeAnimatorController = sol1Controller;
                    B92an.runtimeAnimatorController = ortaController;
                    B89an.runtimeAnimatorController = sag1Controller;
                    B93an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B91, orta.transform.position, Quaternion.identity);
                    Instantiate(B90, orta.transform.position, Quaternion.identity);
                    Instantiate(B92, orta.transform.position, Quaternion.identity);
                    Instantiate(B93, orta.transform.position, Quaternion.identity);
                    Instantiate(B89, orta.transform.position, Quaternion.identity);

                    break;
                case 8:
                    TS48.gameObject.SetActive(true);

                    B31.tag = "Dogru"; B32.tag = "Yanlis"; B33.tag = "Yanlis"; B34.tag = "Yanlis"; B35.tag = "Yanlis";

                    B32an.runtimeAnimatorController = sol2Controller;
                    B33an.runtimeAnimatorController = sol1Controller;
                    B34an.runtimeAnimatorController = ortaController;
                    B31an.runtimeAnimatorController = sag1Controller;
                    B35an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B21, orta.transform.position, Quaternion.identity);
                    Instantiate(B20, orta.transform.position, Quaternion.identity);
                    Instantiate(B22, orta.transform.position, Quaternion.identity);
                    Instantiate(B23, orta.transform.position, Quaternion.identity);
                    Instantiate(B24, orta.transform.position, Quaternion.identity);
                    break;
                case 9:
                    TS49.gameObject.SetActive(true);

                    B57.tag = "Dogru"; B58.tag = "Yanlis"; B59.tag = "Yanlis"; B56.tag = "Yanlis"; B60.tag = "Yanlis";

                    B57an.runtimeAnimatorController = sol2Controller;
                    B60an.runtimeAnimatorController = sol1Controller;
                    B58an.runtimeAnimatorController = ortaController;
                    B59an.runtimeAnimatorController = sag1Controller;
                    B56an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B57, orta.transform.position, Quaternion.identity);
                    Instantiate(B60, orta.transform.position, Quaternion.identity);
                    Instantiate(B58, orta.transform.position, Quaternion.identity);
                    Instantiate(B59, orta.transform.position, Quaternion.identity);
                    Instantiate(B56, orta.transform.position, Quaternion.identity);
                    break;
                case 10:
                    TS50.gameObject.SetActive(true);

                    B63.tag = "Dogru"; B62.tag = "Yanlis"; B66.tag = "Yanlis"; B64.tag = "Yanlis"; B65.tag = "Yanlis";

                    B62an.runtimeAnimatorController = sol2Controller;
                    B63an.runtimeAnimatorController = sol1Controller;
                    B64an.runtimeAnimatorController = ortaController;
                    B65an.runtimeAnimatorController = sag1Controller;
                    B66an.runtimeAnimatorController = sag2Controller;

                    Instantiate(B62, orta.transform.position, Quaternion.identity);
                    Instantiate(B63, orta.transform.position, Quaternion.identity);
                    Instantiate(B64, orta.transform.position, Quaternion.identity);
                    Instantiate(B65, orta.transform.position, Quaternion.identity);
                    Instantiate(B66, orta.transform.position, Quaternion.identity);
                    break;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        else if (sure >= 245 && sure < 295)
        {
            SonPuan.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}