#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>
#include <string.h>
typedef struct {
    char tcId[11];
    int numberOfColumns;
    int coupon[20][6];
    float spMoney;
    float acMoney;
    int threeTrueInColumn;
    int fourTrueInColumn;
    int fiveTrueInColumn;
    int sixTrueInColumn;
} USER;
typedef struct {
    char lotteryName[30];
    int oneColumnCost;
    long totalIncome;
    float X;
    float SIX;
    float FIVE;
    float FOUR;
    float THREE;
    long transferredMoney;
    int numberOfThreeColumns;
    int numberOfFourColumns;
    int numberOfFiveColumns;
    int numberOfSixColumns;
} LOTTERY;
void * realloc ( void * ptr, size_t size );
void KazananlariAcikla(USER *,int);
int main()
{
    srand(time(NULL));
    static int kisiSayisi=0,i,j,k,m,kazananSayisi,oynananKolonSayisi;
    static USER  *kisiler;
    static LOTTERY loto;
    static int sayilar[6];
    static long dagitilmayanPara;
    USER *kazananlar;
    static char tus;

    //Menuden cikis yapilana kadar dongu olmasi icin.
    while(1)
    {
        printf("\n");
        printf("1- Ayarlar\n");
        printf("2- Kisi Ekle\n");
        printf("3- Cekilisi Baslat\n");
        printf("4- Kimlik No Ile Bilgi Sorgula\n");
        printf("5- Cikis\n\n\n");
        tus=getch();
        switch(tus)
        {
            case '1':
            {
                int yuzdeYuz;
                do
                {
                    yuzdeYuz=1;
                    printf("Loto Ismi Giriniz(Birlesik Yaziniz)\n");
                    scanf("%s",loto.lotteryName);
                    printf("Bir kolon fiyati girin (Eskisi : %d) \n",loto.oneColumnCost);
                    scanf("%d",&(loto.oneColumnCost));
                    printf("Dagitilacak paranin yuzdesini girin (Eskisi : %0.2f)\n",loto.X);
                    scanf("%f",&(loto.X));
                    printf("6 da 6 yapanin alacagi yuzdesini girin (Eskisi : %0.2f)\n",loto.SIX);
                    scanf("%f",&(loto.SIX));
                    printf("6 da 5 yapanin alacagi yuzdesini girin (Eskisi : %0.2f)\n",loto.FIVE);
                    scanf("%f",&(loto.FIVE));
                    printf("6 da 4 yapanin alacagi yuzdesini girin (Eskisi : %0.2f)\n",loto.FOUR);
                    scanf("%f",&(loto.FOUR));
                    printf("6 da 3 yapanin alacagi yuzdesini girin (Eskisi : %0.2f)\n",loto.THREE);
                    scanf("%f",&(loto.THREE));
                    if ((loto.SIX + loto.FIVE + loto.FOUR + loto.THREE) != 100) // X ile agirliklandirilacagi icin 100.
                    {
                       yuzdeYuz=0;
                       printf("Kazananlarin alacagi yuzdeler 100 e esit degil. Tekrar giriniz.\n");
                    }
                 }while(yuzdeYuz!=1);
                 printf("Ayarlar kaydedildi.\n\n");
            }
            break;
            case '2':
            {
                int eklenecek;
                printf("Kac kisi eklenecek? (Suanki Durum:%d) \n",kisiSayisi);
                scanf("%d",&eklenecek);
                int toplamKisi=kisiSayisi+eklenecek;
                kisiler=(USER*)realloc(kisiler,toplamKisi*sizeof(USER));
                if(kisiler==NULL)
                {
                    printf("Tahammul edilemez hata!(Memory Allocation Exception)");
                    exit(EXIT_FAILURE);
                }


                int kolonSayisi;
                int ayniTc;
                for(i=kisiSayisi;i<toplamKisi;i++)
                {

                    kolonSayisi=(rand()%20)+1;
                    kisiler[i].numberOfColumns=kolonSayisi;
                    do
                    {
                        ayniTc=0;
                        printf("%d.Kisinin TC Nosunu giriniz.\n",i+1);
                        scanf("%s",kisiler[i].tcId);
                        j=0;
                        while(j<i)
                        {
                            if(strcmp(kisiler[i].tcId,kisiler[j].tcId)==0)
                            {
                                printf("Ayni TC Nosuna sahip biri var. Yeniden deneyin.\n");
                                ayniTc=1;
                                break;
                            }
                            j++;
                        }

                    }while(ayniTc==1);
                    kisiler[i].threeTrueInColumn=0;
                    kisiler[i].fourTrueInColumn=0;
                    kisiler[i].fiveTrueInColumn=0;
                    kisiler[i].sixTrueInColumn=0;

                    for(j=0;j<kolonSayisi;j++)
                    {
                        for(k=0;k<6;k++)
                        {
                              kisiler[i].coupon[j][k]=rand()%48 + 1;
                        }
                    }
                    oynananKolonSayisi+=kolonSayisi;
                    kisiler[i].spMoney=kolonSayisi*loto.oneColumnCost;
                    printf("%s TC li Kisinin Oynadigi Kolon Sayisi: %d \n",kisiler[i].tcId,kolonSayisi);

                }
                kisiSayisi=toplamKisi;
            }
            break;
            case '3':
            {
                // mSix -> 6 bilenlere verilecek toplam para, pSix -> 6 bilen bir kisinin alacacagi para
                int mSix,mFive,mFour,mThree,pSix=0,pFive=0,pFour=0,pThree=0;

                USER *tmp;
                if(kisiSayisi!=0 && loto.X!=0)
                {
                    loto.numberOfSixColumns=0;
                    loto.numberOfFiveColumns=0;
                    loto.numberOfFourColumns=0;
                    loto.numberOfThreeColumns=0;

                    int sayi;
                    int tutanSayi;
                    kazananSayisi=0;

                    i=0;
                    printf("%s cekilisi basladi..\n",loto.lotteryName);
                    printf("Sansli Numaralar: \n");
                    while(i<6)
                    {
                        sayi=rand()%48 + 1;
                        sayilar[i]=sayi;
                        printf("%d ",sayi);
                        i++;
                    }
                    printf("\n\n");
                    loto.totalIncome = oynananKolonSayisi * loto.oneColumnCost + loto.transferredMoney;
                    //Devredilen para gelire eklenirken 0 lanir.
                    loto.transferredMoney=0;
                    printf("Toplam Gelir : %ld (Devreden Tutar: %ld)\n",loto.totalIncome,loto.transferredMoney);
                    int tutturdu=0;
                    for (i=0;i<kisiSayisi;i++)
                    {
                        tutturdu=0;
                        for (j=0;j<(kisiler[i].numberOfColumns);j++)
                        {
                            tutanSayi=0;
                            for (k=0;k<6;k++)
                            {
                                for (m=0;m<6;m++)
                                {
                                    if(kisiler[i].coupon[j][k]==sayilar[m])
                                    {
                                        printf("%s TC li kisinin %d. kolonunda tutan sayi:%d \n",kisiler[i].tcId,j,sayilar[m]);

                                        tutanSayi++;
                                    }
                                }
                            }
                            if (tutanSayi==6)
                            {
                                tutturdu=1;
                                kisiler[i].sixTrueInColumn++;loto.numberOfSixColumns++;

                            }
                            else if ( tutanSayi==5)
                            {
                                tutturdu=1;
                                kisiler[i].fiveTrueInColumn++;loto.numberOfFiveColumns++;
                            }
                            else if ( tutanSayi==4)
                            {
                                tutturdu=1;
                                kisiler[i].fourTrueInColumn++;loto.numberOfFourColumns++;
                            }
                            else if ( tutanSayi==3)
                            {
                                tutturdu=1;
                                kisiler[i].threeTrueInColumn++;loto.numberOfThreeColumns++;
                            }
                        }
                        //Bir kisinin en az bir kolonunda 3,4,5 ya da 6 bildigi olduysa
                        if(tutturdu!=0)
                        {
                            if(kazananSayisi==0)
                                kazananlar = (USER*)malloc(1 * sizeof(USER));
                            else
                            {
                                //Segmentation Fault icin tmp kullanildi.
                                tmp = (USER*)realloc((USER*)kazananlar,(kazananSayisi+1)*sizeof(USER));
                                kazananlar=tmp;
                            }
                            if(kazananlar==NULL)
                            {
                                printf("Tahammul edilemez hata!(Memory Allocation Exception)");
                                exit(EXIT_FAILURE);
                            }
                            kazananSayisi++;
                            kazananlar[kazananSayisi-1]=kisiler[i];
                        }
                    }
                    printf("6/6 Tutan Kolon Sayisi: %d\n",loto.numberOfSixColumns);
                    printf("5/6 Tutan Kolon Sayisi: %d\n",loto.numberOfFiveColumns);
                    printf("4/6 Tutan Kolon Sayisi: %d\n",loto.numberOfFourColumns);
                    printf("3/6 Tutan Kolon Sayisi: %d\n",loto.numberOfThreeColumns);
                    dagitilmayanPara=(loto.totalIncome * (100 - loto.X))/100;
                    loto.transferredMoney +=dagitilmayanPara;  //Dagitilmayan para da devredildi.
                    mSix=loto.totalIncome * ((loto.X * loto.SIX)/10000);
                    mFive=loto.totalIncome * ((loto.X * loto.FIVE)/10000);
                    mFour=loto.totalIncome * ((loto.X * loto.FOUR)/10000);
                    mThree=loto.totalIncome * ((loto.X * loto.THREE)/10000);


                    if(loto.numberOfSixColumns==0)
                        loto.transferredMoney += mSix;
                    else
                        pSix=mSix/loto.numberOfSixColumns;
                    if(loto.numberOfFiveColumns==0)
                        loto.transferredMoney += mFive;
                    else
                        pFive=mFive/loto.numberOfFiveColumns;
                    if(loto.numberOfFourColumns==0)
                        loto.transferredMoney += mFour;
                    else
                        pFour=mFour/loto.numberOfFourColumns;
                    if(loto.numberOfThreeColumns==0)
                        loto.transferredMoney += mThree;
                    else
                        pThree=mThree/loto.numberOfThreeColumns;

                    printf("Devreden Tutar : %ld\n",loto.transferredMoney);
                    for(i=0;i<kazananSayisi;i++)
                    {
                        //Bir kisinin kazandigi paranin hesaplanmasi.
                        kazananlar[i].acMoney=pSix*kazananlar[i].sixTrueInColumn+pFive*kazananlar[i].fiveTrueInColumn+pFour*kazananlar[i].fourTrueInColumn+pThree*kazananlar[i].threeTrueInColumn;
                    }
                    KazananlariAcikla(kazananlar,kazananSayisi);
                    free(kazananlar);
                }
                else
                    printf("Ayarlar ve kisi ekleme yapilmadan cekilise baslanamaz.\n");
            }
            break;
            case '4':
            {
                char tc[11];
                printf("TC no giriniz. \n");
                scanf("%s",tc);
                i=0;
                j=0;
                while(i<kisiSayisi)
                {
                    if (strcmp(tc,kisiler[i].tcId)==0)
                    {
                        j=1;
                        printf("\n%s TC Nolu kisinin bilgileri\n",kisiler[i].tcId);
                        printf("Harcadigi Para : %0.2f\n",kisiler[i].spMoney);
                        printf("Kazandigi Para : %0.2f\n",kisiler[i].acMoney);
                        break;
                    }
                    i++;
                }
                if ( j!=1)
                {
                    printf("Kimse bulunamadi. \n");
                }
            }
            break;
            case '5':
            {
                free(kazananlar);
                free(kisiler);
                exit(EXIT_SUCCESS);
            }
            break;
            default:
                printf("Herhangi bir seçim yapmadiniz\n");
        }
    }
}
void KazananlariAcikla(USER * kazananlar,int kazananSayisi)
{
    int i=0,j=0;
    USER tmp;
    for(i=0;i<kazananSayisi;i++)
    {
        for(j=1;j<kazananSayisi;j++)
        {

            if(kazananlar[i].acMoney > kazananlar[j].acMoney)
            {
                tmp=kazananlar[i];
                kazananlar[i]=kazananlar[j];
                kazananlar[j]=kazananlar[i];
            }
        }
    }
    printf("\n-- Kazananlar Listesi -- \n\n");
    for(i=0;i<kazananSayisi;i++)
    {
        printf("TC: %s --> %0.2f\n",kazananlar[i].tcId,kazananlar[i].acMoney);
    }
    if(kazananSayisi==0)
        printf(" Kazanan Cikmadi. \n");
}
