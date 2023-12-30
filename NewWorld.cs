using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        //Fonksiyonu �a��r�yorum.
        bolenleriBul(20, 80);

    }

    void bolenleriBul(int s1, int s2)
    {
        //Fonksiyonu tan�ml�yorum.
        
        ArrayList siralama = new ArrayList(); // Fonksiyonun �a�r�ld��� say�lar aras�ndaki de�erlerin hepsini s�ralamak i�in array list olu�turuyorum.
        ArrayList IkiyeBolunen = new ArrayList();// Fonksiyonun �a�r�ld��� say�lar aras�ndaki de�erlerin ikiye b�l�nenleri s�ralamak i�in array list olu�turuyorum
        ArrayList UceBolunen = new ArrayList(); //Fonksiyonun �a�r�ld��� say�lar aras�ndaki de�erlerin ��e b�l�nenleri s�ralamak i�in array list olu�turuyorum
        ArrayList DordeBolunen = new ArrayList(); //Fonksiyonun �a�r�ld��� say�lar aras�ndaki de�erlerin d�rde b�l�nenleri s�ralamak i�in array list olu�turuyorum
        ArrayList BeseBolunen = new ArrayList(); //Fonksiyonun �a�r�ld��� say�lar aras�ndaki de�erlerin be�e b�l�nenleri s�ralamak i�in array list olu�turuyorum

        for (int i = s1; i <= s2; i++)
            siralama.Add(i); // Fonksiyonun �a�r�ld��� say�lar aras�ndaki de�erlerin hepsini s�ralama i�lemini burada yap�yorum. E�er bu �ekilde b�rak�rsam alt alta s�ralar.

        foreach (int sayi in siralama)
        {
            // �kiye, ��e, d�rde ve be�e b�l�nen de�erleri belirlemi� oluyorum a�a��daki ifler ile.
            if (sayi % 2 == 0)
                IkiyeBolunen.Add(sayi);
            if (sayi % 3 == 0)
                UceBolunen.Add(sayi);
            if (sayi % 4 == 0)
                DordeBolunen.Add(sayi);
            if (sayi % 5 == 0)
                BeseBolunen.Add(sayi);
        }
        // L�stedeki say�lar� yanyana yazmas� string'e d�n��t�r�yoruz.
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
        // Son olarak da ekrana yazd�r�yoruz.
        print("T�m liste: " +tanimlama);
        print("�kiye b�l�nenler: " +iki);
        print("��e b�l�nenler: " +uc);
        print("D�rde b�l�nenler: " +dort);
        print("Be�e b�l�nenler: " +bes);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

