// A - macierz współczynników ,
// c - wektor kosztów
// b - wektor ograniczeń
// Pj - kolumna macierzy A
// P0 = b
// CEL znalezc minimalizacje podanej funkcji, obliczenie zmiennych x1,x2,x3,x4,x5...

/*************************************]ALGORYTM[*****************************************/
//   KROK1 (znalezienie tablicy dualnie dopuszczalnej):                                  /
//   1 warunek dualnej dopuszczalnosci: yoj >= 0 dla j należącego do R;                  /
//                                                                                       /
//   KROK 2 (test optymalnosci):                                                         /
//   2 warunek dualnej dopuszczalności:  yio >= 0 dla i należącego {1,...,m}.            /
//                                                                                       /
//   KROK 3 (wybor zmiennej usuwanej z bazy):                                            /
//   wybrac z bazy taka zmiena Xb dla której yr0 <0.                                     /
//                                                                                       /
//   KROK 4 (wybor zmiennej wprowadzanej do bazy):                                       /
//   wybrac zmienna xk dla której stosunek y0k do y4k = max (y0j/yrj, yrj<0).            /
//                                                                                       /
//   KROK 5 (ELIMINACJA):                                                                /
//   Dualna iteracja sImpleksowa metodą eliminacji Gaussa poprzez wprowadzenie Xk;       /
//   do bazy oraz usunięcie Xb. Cofnij do kroku2.                                        /
/****************************************************************************************/

using System;
namespace std
{
    public class Simpleks : Matrix  //dziedziczenie po klasie Matrix
    {
        float Dopuszczalnosc {} //Krok1
        float Optymalnosc {} // Krok2
        float DzialaniaBaza {} // Krok3 i Krok4
        float EliminacjaGaussa {} // Krok 5
        float MinimumFunkcji {} //obliczanie minimum funkcji celu   
    }

    public class Matrix  // klasa pomocnicza do metody Elimincji
    {
        double[] TablicaNieOptymalna;
        double[] TablicaOptymalna;
        double[] TablicaWynikow;
}


class WywolanieProgramu
    {
        static void Main()
        {

            //Tu będzie test metody //
        }
    }








}