using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        //Fonksiyonu çaðýrýyorum.
        bolenleriBul(20, 80);

    }

    void bolenleriBul(int s1, int s2)
    {
        //Fonksiyonu tanýmlýyorum.
        
        ArrayList siralama = new ArrayList(); // Fonksiyonun çaðrýldýðý sayýlar arasýndaki deðerlerin hepsini sýralamak için array list oluþturuyorum.
        ArrayList IkiyeBolunen = new ArrayList();// Fonksiyonun çaðrýldýðý sayýlar arasýndaki deðerlerin ikiye bölünenleri sýralamak için array list oluþturuyorum
        ArrayList UceBolunen = new ArrayList(); //Fonksiyonun çaðrýldýðý sayýlar arasýndaki deðerlerin üçe bölünenleri sýralamak için array list oluþturuyorum
        ArrayList DordeBolunen = new ArrayList(); //Fonksiyonun çaðrýldýðý sayýlar arasýndaki deðerlerin dörde bölünenleri sýralamak için array list oluþturuyorum
        ArrayList BeseBolunen = new ArrayList(); //Fonksiyonun çaðrýldýðý sayýlar arasýndaki deðerlerin beþe bölünenleri sýralamak için array list oluþturuyorum

        for (int i = s1; i <= s2; i++)
            siralama.Add(i); // Fonksiyonun çaðrýldýðý sayýlar arasýndaki deðerlerin hepsini sýralama iþlemini burada yapýyorum. Eðer bu þekilde býrakýrsam alt alta sýralar.

        foreach (int sayi in siralama)
        {
            // Ýkiye, üçe, dörde ve beþe bölünen deðerleri belirlemiþ oluyorum aþaðýdaki ifler ile.
            if (sayi % 2 == 0)
                IkiyeBolunen.Add(sayi);
            if (sayi % 3 == 0)
                UceBolunen.Add(sayi);
            if (sayi % 4 == 0)
                DordeBolunen.Add(sayi);
            if (sayi % 5 == 0)
                BeseBolunen.Add(sayi);
        }
        // LÝstedeki sayýlarý yanyana yazmasý string'e dönüþtürüyoruz.
        string tanimlama = "";
        string iki = "";
        string uc = "";
        string dort = "";
        string bes = "";

        foreach (int deger in siralama)
        {
            tanimlama += " " + deger;
        }
        foreach (int deger in IkiyeBolunen)
        {
            iki += " " + deger;
        }
        foreach (int deger in UceBolunen)
        {
            uc += " " + deger;
        }
        foreach (int deger in DordeBolunen)
        {
            dort += " " + deger;
        }
        foreach (int deger in BeseBolunen)
        {
            bes += " " + deger;
        }
        // Son olarak da ekrana yazdýrýyoruz.
        print("Tüm liste: " +tanimlama);
        print("Ýkiye bölünenler: " +iki);
        print("Üçe bölünenler: " +uc);
        print("Dörde bölünenler: " +dort);
        print("Beþe bölünenler: " +bes);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

